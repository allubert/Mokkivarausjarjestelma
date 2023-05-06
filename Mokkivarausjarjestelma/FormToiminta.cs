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
    public partial class FormToiminta : Form
    {
        public FormToiminta()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti");
        MySqlCommand command;
        public void populatedgvToiminta()
        {
            //hae dataa
            string selectQuery = "SELECT * FROM palvelu";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvToiminta.DataSource = table;
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

        private void btnToimintaLisaaAlue_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (tb.Text == "")
                {
                    tb.Focus();
                    MessageBox.Show("Et ole täyttänyt kaikkia kenttiä!");
                    return;
                }
            }

            string nimi = tbToimintaAlue.Text;
            int alueid = int.Parse(tbToimintaAlueid.Text);  
            string postinro = tbToimintaPostinro.Text;
            string toimipaikka = tbToimintaToimip.Text;
            

            string insertQuery = "INSERT INTO alue(nimi, alue_id, postinro, toimipaikka) VALUES (@nimi, @alueid, @postinro, @toimipaikka)";

            try
            {
                using (connection)
                {
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@nimi", nimi);
                        command.Parameters.AddWithValue("@alueid", alueid);   
                        command.Parameters.AddWithValue("@postinro", postinro);
                        command.Parameters.AddWithValue("@toimipaikka", toimipaikka);

                        connection.Open();
                        command.ExecuteNonQuery();
                        populatedgvToiminta();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe");
            }
        }

        private void btnToimintaPaivita_Click(object sender, EventArgs e)
        {
           
                try
                {
                    using (connection)
                    {
                        string query = "UPDATE alue SET alue_id=@alueid, nimi=@nimi, postinro=@postinro, toimipaikka=@toimipaikka";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                        command.Parameters.AddWithValue("@nimi", tbToimintaAlue.Text);
                        command.Parameters.AddWithValue("@alueid", tbToimintaAlueid.Text);
                        command.Parameters.AddWithValue("@postinro", tbToimintaPostinro.Text);
                        command.Parameters.AddWithValue("@toimipaikka", tbToimintaToimip.Text);
                        connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();
                            populatedgvToiminta();
                        }
                    }
                    MessageBox.Show("Tietokannan päivittäminen onnistui", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Tietokannan päivittäminen epäonnistui");
                }

            }

        private void FormToiminta_Load(object sender, EventArgs e)
        {
            populatedgvToiminta();
        }

        private void dgvToiminta_MouseClick(object sender, MouseEventArgs e)
        {
            tbToimintaAlue.Text = dgvToiminta.CurrentRow.Cells[0].Value.ToString();
            tbToimintaAlueid.Text = dgvToiminta.CurrentRow.Cells[1].Value.ToString();
            tbToimintaPostinro.Text = dgvToiminta.CurrentRow.Cells[2].Value.ToString();
            tbToimintaPostinro.Text = dgvToiminta.CurrentRow.Cells[3].Value.ToString();
           
        }
    }
    }
    

