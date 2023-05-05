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
    public partial class FormAsiakashallinta : Form
    {
        public FormAsiakashallinta()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog='vn';username=root;password=Ruutti");
        MySqlCommand command;

        public void populatedgvAsiakkaat()
        {
            string query = "SELECT * FROM asiakas";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvAsiakashallinta.DataSource = table;
        }

        public void ExecuteMyQuery(string query)
        {
            try
            {
                connection.Open();

                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kysely suoritettu");
                }
                else
                {
                    MessageBox.Show("Kyselyä ei suoritettu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void btnTakaisinAloitusFormiin_Click(object sender, EventArgs e)
        {
            Form formaloitus = new Form1();
            this.Hide();

            formaloitus.ShowDialog();
            this.Close();
        }

        private void btnAsiakasHae_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti");

            string query = "SELECT * FROM asiakas WHERE asiakas_id = @asiakasid";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@asiakasid", tbAsiakasid.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                tbasiakasPostinumero.Text = row["postinro"].ToString();
                tbAsiakasEtunimi.Text = row["etunimi"].ToString();
                tbAsiakasSukunimi.Text = row["sukunimi"].ToString();
                tbAsiakasLahiosoite.Text = row["lahiosoite"].ToString();
                tbAsiakasSahkoposti.Text = row["email"].ToString();
                tbAsiakasPuhelinnumero.Text = row["puhelinnro"].ToString();
            }
            btnAsiakasPaivita.Visible = true;
            btnAsiakasPoista.Visible = true;
        }

        private void btnAsiakasPoista_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(tbasiakasPostinumero.Text);
            string deletequery = "DELETE FROM asiakas WHERE asiakas_id = " + tbAsiakasid.Text;
            ExecuteMyQuery(deletequery);
            populatedgvAsiakkaat();
        }

        private void btnAsiakasLisaa_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (tb.Text == "")
                {
                    tb.Focus();
                    MessageBox.Show("Kaikkia kenttiä ei ole täytetty");
                    return;
                }
            }
            int asiakasid = int.Parse(tbAsiakasid.Text);
            string insertQuery = "INSERT INTO asiakas(asiakas_id, postinro, etunimi, sukunimi, lahiosoite, email, puhelinnro) VALUES (@asiakasid, @postinro, @etunimi, @sukunimi, @lahiosoite, @email, @puhelinnro)";
            string insertPostiQuery = "INSERT INTO posti(postinro, toimipaikka) VALUES (@postinro, @toimipaikka)";
            try
            {
                using (MySqlConnection myconnection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti"))
                {
                    using (MySqlCommand command = new MySqlCommand(insertQuery, myconnection))
                    {
                        myconnection.Open();
                        command.Parameters.AddWithValue("@asiakasid", asiakasid);
                        command.Parameters.AddWithValue("@postinro", tbasiakasPostinumero.Text);
                        command.Parameters.AddWithValue("@etunimi", tbAsiakasEtunimi.Text);
                        command.Parameters.AddWithValue("@sukunimi", tbAsiakasSukunimi.Text);
                        command.Parameters.AddWithValue("@lahiosoite", tbAsiakasLahiosoite.Text);
                        command.Parameters.AddWithValue("@email", tbAsiakasSahkoposti.Text);
                        command.Parameters.AddWithValue("@puhelinnro", tbAsiakasPuhelinnumero.Text);

                        // tarkistaa onko postinro jo olemassa  posti taulussa 
                        string checkPostiQuery = "SELECT COUNT(*) FROM posti WHERE postinro = @postinro";
                        using (MySqlCommand komento = new MySqlCommand(checkPostiQuery, myconnection))
                        {
                            komento.Parameters.AddWithValue("@postinro", tbasiakasPostinumero.Text);
                            int postiCount = Convert.ToInt32(komento.ExecuteScalar());
                            if (postiCount == 0)
                            {
                                // lisää postitauluun
                                using (MySqlCommand posti = new MySqlCommand(insertPostiQuery, myconnection))
                                {
                                    posti.Parameters.AddWithValue("@postinro", tbasiakasPostinumero.Text);
                                    posti.ExecuteNonQuery();
                                }
                            }
                        }
                        command.ExecuteNonQuery();
                        populatedgvAsiakkaat();
                    }
                }
                MessageBox.Show("Mahtavaa", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAsiakasPaivita.Visible = true;
                btnAsiakasPoista.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ei voi lisätä päällekkäin. Tsekkaa postinumero ja id.");
            }
        }
    }
}
