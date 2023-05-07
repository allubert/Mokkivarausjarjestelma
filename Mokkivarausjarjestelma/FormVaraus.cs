using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokkivarausjarjestelma
{
    public partial class FormVaraus : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti");
        private DateTime vahvistuspvm;

        public FormVaraus()
        {
            InitializeComponent();
            using (connection)
            {
                try
                {
                    // täyttää asiakas_id comboboxin
                    string asiakasnimetQuery = "SELECT asiakas_id, etunimi, sukunimi FROM asiakas";
                    MySqlDataAdapter asiakasAdapter = new MySqlDataAdapter(asiakasnimetQuery, connection);
                    DataTable asiakasDt = new DataTable();
                    asiakasAdapter.Fill(asiakasDt);

                    var asiakasData = asiakasDt.AsEnumerable()
                        .Select(row => new
                        {
                            asiakas_id = row.Field<uint>("asiakas_id"),
                            FullName = row.Field<string>("etunimi") + " " + row.Field<string>("sukunimi")
                        })
                        .ToList();

                    cmbUusiVarausValitseAsiakas.DisplayMember = "FullName";
                    cmbUusiVarausValitseAsiakas.ValueMember = "asiakas_id";
                    cmbUusiVarausValitseAsiakas.DataSource = asiakasData;


                    // täyttää mokki_id comboboxin
                    string mokkinimiQuery = "SELECT mokki_id, mokkinimi FROM mokki";
                    MySqlDataAdapter mokkiAdapter = new MySqlDataAdapter(mokkinimiQuery, connection);
                    DataSet mokkiDs = new DataSet();
                    mokkiAdapter.Fill(mokkiDs, "mokki");
                    cmbUusiVarausValitseMokki.DisplayMember = "mokkinimi";
                    cmbUusiVarausValitseMokki.ValueMember = "mokki_id";
                    cmbUusiVarausValitseMokki.DataSource = mokkiDs.Tables["mokki"];
                }
                catch (Exception ex)
                {
                    // tietokantaan ei ole lisätty mökkejä, tai asiakkaita.
                    MessageBox.Show("Varausta ei voi tehdä, koska tietokannasta luultavasti puuttuu mökin ja/tai asiakkaan tiedot\n " + ex.ToString()); ;
                    return;
                }
            }
            string selectQuery = "SELECT * FROM varaus";
            DataTable datatable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            dgMokkiVaraukset.DataSource = datatable;
            adapter.Fill(datatable);
            connection.Close();

        }
        
        private void btnValmisVaraus_Click(object sender, EventArgs e)
        {
        
            if(Convert.ToDateTime(dateTimeMokinVarausLoppuPvm.Text) > DateTime.Now) // varauksen loppupvm ei voi olla menneisyydessä
            {
                DateTime varattuloppupvm = Convert.ToDateTime(dateTimeMokinVarausLoppuPvm.Text);
                if (Convert.ToDateTime(dateTimeMokinVarausAlkuPvm.Text) > DateTime.Now) //varauksen alkupvm ei voi olla menneisyydessä
                {
                    DateTime varattualkupvm = Convert.ToDateTime(dateTimeMokinVarausAlkuPvm.Text);

                    if (varattuloppupvm > varattualkupvm) //varauksen loppupvm ei voi olla ennen alkupvm:ää
                    {
                        int asiakasid = Convert.ToInt32(cmbUusiVarausValitseAsiakas.SelectedValue);
                        int mokkimokkiid = Convert.ToInt32(cmbUusiVarausValitseMokki.SelectedValue);
                        try
                        {
                            int varausid = int.Parse(tbUusiVarausVarausID.Text);
                            using (connection)
                            {
                                connection.Open();

                                string paallekkaisVarausQuery = "SELECT COUNT(*) " +
                                                          "FROM varaus " +
                                                          "WHERE mokki_mokki_id = @mokkimokkiid " +
                                                          "AND varattu_alkupvm <= @varattuloppupvm " +
                                                          "AND varattu_loppupvm >= @varattualkupvm;";

                                using (MySqlCommand checkCommand = new MySqlCommand(paallekkaisVarausQuery, connection))
                                {
                                    checkCommand.Parameters.AddWithValue("@mokkimokkiid", mokkimokkiid);
                                    checkCommand.Parameters.AddWithValue("@varattualkupvm", varattualkupvm);
                                    checkCommand.Parameters.AddWithValue("@varattuloppupvm", varattuloppupvm);

                                    int overlappingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                                    if (overlappingCount > 0)
                                    {
                                        MessageBox.Show("Tätä varausta ei voi suorittaa. Päivämäärät menevät päällekkäin aiemman varauksen kanssa.");
                                        return;
                                    }
                                }

                                string VarauksentiedotInsertQuery = "INSERT INTO varaus(varaus_id, asiakas_id, mokki_mokki_id, varattu_pvm, vahvistus_pvm, " +
                                    "varattu_alkupvm, varattu_loppupvm)" +
                                "VALUES (@varausid, @asiakasid, @mokkimokkiid, @varattupvm, @vahvistuspvm, @varattualkupvm, @varattuloppupvm)";

                                using (MySqlCommand command = new MySqlCommand(VarauksentiedotInsertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@varausid", varausid);
                                    command.Parameters.AddWithValue("@asiakasid", asiakasid);
                                    command.Parameters.AddWithValue("@mokkimokkiid", mokkimokkiid);
                                    command.Parameters.AddWithValue("@varattupvm", DateTime.Now);
                                    command.Parameters.AddWithValue("@vahvistuspvm", vahvistuspvm);
                                    command.Parameters.AddWithValue("@varattualkupvm", varattualkupvm);
                                    command.Parameters.AddWithValue("@varattuloppupvm", varattuloppupvm);
                                    command.ExecuteNonQuery();
                                }
                                connection.Close();
                            }
                            UpdatedgMokkiVaraukset();
                            btnValmisVaraus.Enabled= false;
                        }
                        catch
                        {
                            MessageBox.Show("Varaus_ID on virheellinen");
                            btnValmisVaraus.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valitettavasti varauksen täytyy kestää vähintään yksi vuorokausi");
                        btnValmisVaraus.Enabled = false;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ei voida lisätä varausta, jonka alkupäivä olisi menneisyydessä/varauksentekopäivänä");
                    btnValmisVaraus.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Ei voida lisätä varausta, jonka loppupäivä on menneisyydessä/varauksentekopäivänä");
                btnValmisVaraus.Enabled = false;
            }

            
        }
        private void UpdatedgMokkiVaraukset()
        {
            //Varauksen hallinnan datagridviewiin tietojen vienti
            string selectQuery = "SELECT * FROM varaus";
            DataTable datatable = new DataTable();
            using (connection)
            {
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(datatable);
                    connection.Close();
                }
            }
            dgMokkiVaraukset.DataSource = datatable;

        }
        //Käyttäjä 'vahvistaa' varauksen
        private void btnMokinVarausVahvista_Click(object sender, EventArgs e)
        {
            vahvistuspvm = DateTime.Now;
            btnValmisVaraus.Enabled = true;
        }
        private void btnTakaisinAloitusFormiin_Click(object sender, EventArgs e)
        {
            Form formaloitus = new FormMokitJaMokkivaraukset();
            this.Hide();
            this.Close();
        }
    }
}
