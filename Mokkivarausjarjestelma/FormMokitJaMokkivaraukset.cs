using MySql.Data.MySqlClient;
using System;
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
    public partial class FormMokitJaMokkivaraukset : Form
    {
        public FormMokitJaMokkivaraukset()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog='vn';username=root;password=Ruutti");

        private void btnUusiVaraus_Click(object sender, EventArgs e)
        {
            var VarausForm = new FormVaraus();
            VarausForm.Show();
        }
        private void UpdatedgMokkiLista()
        {
            //Mökkivarausten hallinnan datagridviewiin tietojen vienti
            string selectQuery = "SELECT * FROM mokki";
            DataTable datatable = new DataTable();
            using (MySqlConnection myconnection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti"))
            {
                using (MySqlCommand command = new MySqlCommand(selectQuery, myconnection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(datatable);
                    connection.Close();
                }
            }
            dgMokkiLista.DataSource = datatable;

        }
        //Lisää uuden mökin tiedot tietokantaan
        private void btnLisaaMokinTiedot_Click(object sender, EventArgs e)
        {
            int mokkiid = int.Parse(tbValittuMokkiMokkiID.Text);
            int alueid = int.Parse(tbValittuMokkiAlueID.Text);
            string postinro = tbValittuMokkiPostiNro.Text.ToString();
            string mokkinimi = tbValittuMokkiNimi.Text.ToString();
            string katuosoite = tbValittuMokkiOsoite.Text.ToString();
            double hinta = double.Parse(tbValittuMokkiHintaVrk.Text);
            string mokinkuvaus = rtbValittuMokkiKuvaus.Text.ToString();
            int hlomaara = int.Parse(tbValittuMokkiHloMaara.Text);
            string mokinvarustelu = rtbValittuMokkiVarustelu.Text.ToString();
            string MokintiedotInsertQuery = "INSERT INTO mokki(mokki_id, alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu) VALUES (@mokkiid, @alueid, @postinro, @mokkinimi, @katuosoite, @hinta, @mokinkuvaus, @hlomaara, @mokinvarustelu)";
            using (MySqlConnection myconnection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti"))
            {
                using (MySqlCommand command = new MySqlCommand(MokintiedotInsertQuery, myconnection))
                {
                    command.Parameters.AddWithValue("@mokkiid", mokkiid);
                    command.Parameters.AddWithValue("@alueid", alueid);
                    command.Parameters.AddWithValue("@postinro", postinro);
                    command.Parameters.AddWithValue("@mokkinimi", mokkinimi);
                    command.Parameters.AddWithValue("@katuosoite", katuosoite);
                    command.Parameters.AddWithValue("@hinta", hinta);
                    command.Parameters.AddWithValue("@mokinkuvaus", mokinkuvaus);
                    command.Parameters.AddWithValue("@hlomaara", hlomaara);
                    command.Parameters.AddWithValue("@mokinvarustelu", mokinvarustelu);

                    myconnection.Open();
                    command.ExecuteNonQuery();
                    myconnection.Close();
                }
            }
            UpdatedgMokkiLista();
        }

        private void btnPoistaValittuMokkiListalta_Click(object sender, EventArgs e)
        {
            if (dgMokkiLista.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Haluatko varmasti poistaa valitun mökin tietokannasta?", "Oletko varma?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int selectedIndex = dgMokkiLista.SelectedRows[0].Index;
                    int mokkiid = int.Parse(dgMokkiLista[0, selectedIndex].Value.ToString());
                    string MokkiDeleteQuery = "DELETE FROM mokki WHERE mokki_id = @mokkiid";

                    using (connection)
                    {
                        using (MySqlCommand command = new MySqlCommand(MokkiDeleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@mokkiid", mokkiid);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    UpdatedgMokkiLista();
                }
            }
            else
            {
                MessageBox.Show("Valitse mökki, jonka haluat poistaa. Kokeile sitten uudelleen.");
            }
        }




    }
}
