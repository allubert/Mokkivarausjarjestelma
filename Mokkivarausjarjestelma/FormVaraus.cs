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
        
            DateTime varattualkupvm = Convert.ToDateTime(dateTimeMokinVarausAlkuPvm.Text);
            DateTime varattuloppupvm = Convert.ToDateTime(dateTimeMokinVarausLoppuPvm.Text);

            int asiakasid = int.Parse(cmbUusiVarausValitseAsiakas.Text);
            int mokkimokkiid = int.Parse(cmbUusiVarausValitseMokki.Text);
            int varausid = int.Parse(tbUusiVarausVarausID.Text);
            using (connection)
            {
                connection.Open();
                string VarauksentiedotInsertQuery = "INSERT INTO varaus(varaus_id, asiakas_id, mokki_mokki_id, varattu_pvm, vahvistus_pvm, " +
                    "varattu_alkupvm, varattu_loppupvm)" +
                "VALUES (@varausid, @asiakasid, @mokkimokkiid, @varattupvm, @vahvistuspvm, @varattualkupvm, @varattuloppupvm)";

                using (MySqlCommand command = new MySqlCommand(VarauksentiedotInsertQuery, connection))
                {
                    command.Parameters.AddWithValue("@varausid", varausid);
                    command.Parameters.AddWithValue("@asiakasid", asiakasid);
                    command.Parameters.AddWithValue("@mokkimokkiid", mokkimokkiid);
                    command.Parameters.AddWithValue("@varattupvm", DateTime.Now);
                    command.Parameters.AddWithValue("@vahvistuspvm", DateTime.Now);
                    command.Parameters.AddWithValue("@varattualkupvm", varattualkupvm);
                    command.Parameters.AddWithValue("@varattuloppupvm", varattuloppupvm);

                    command.ExecuteNonQuery();
                }
                connection.Close();

            }
            UpdatedgMokkiVaraukset();
        
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
        //Lukitsee annetut tiedot varauksen tietokantaan viemistä varten.
        private void btnMokinVarausVahvista_Click(object sender, EventArgs e)
        {
            btnValmisVaraus.Enabled = true;
        }

        //Tarkastaa, etteivät varaukset mene päällekäin.
        private void btnMokinVarausTarkistaPvm_Click(object sender, EventArgs e)
        {
            btnMokinVarausVahvista.Enabled = true;
        }
    }
}
