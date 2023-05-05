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
    public partial class FormPalveluhallinta : Form
    {
        public FormPalveluhallinta()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti");

        public void populatedgvPalvelut()
        {
            //hae dataa
            string selectQuery = "SELECT * FROM palvelu";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvPalvelut.DataSource = table;
        }

        private void btnPalveluLisaa_Click(object sender, EventArgs e)
        {
            //Palvelu tietojen lisääminen tietokannan tauluun "palvelu"

            int palveluid = int.Parse(tbPalveluID.Text);
            int alueid = int.Parse(tbAlueID.Text);
            string nimi = tbPalvelunimi.Text.ToString();
            int tyyppi = int.Parse(tbPalvelutyyppi.Text);
            string palvelukuvaus = rtbPalvelukuvaus.Text.ToString();
            double hinta = double.Parse(tbPalveluhinta.Text);
            double alv = double.Parse(tbPalvelualv.Text);


            string insertQuery = "INSERT INTO palvelu(palvelu_id, alue_id, nimi, tyyppi, kuvaus, hinta, alv) VALUES (@palveluid, @alueid, @nimi, @tyyppi, @palvelukuvaus, @hinta, @alv)";
            using (connection)
            {
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@palveluid", palveluid);
                    command.Parameters.AddWithValue("@alueid", alueid);
                    command.Parameters.AddWithValue("@nimi", nimi);
                    command.Parameters.AddWithValue("@tyyppi", tyyppi);
                    command.Parameters.AddWithValue("@palvelukuvaus", palvelukuvaus);
                    command.Parameters.AddWithValue("@hinta", hinta);
                    command.Parameters.AddWithValue("@alv", alv);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            populatedgvPalvelut();
        }

        private void btnPalveluPaivita_Click(object sender, EventArgs e)
        {
            populatedgvPalvelut();
        }

        private void btnPalveluPoista_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM palvelu WHERE palvelu_id = @id";

            if (dgvPalvelut.SelectedRows.Count > 0) 
            {
                int valittuIndex = dgvPalvelut.SelectedRows[0].Index;
                int poistoID = Convert.ToInt32(dgvPalvelut[0, valittuIndex].Value);

                DialogResult result = MessageBox.Show("Oletko varma, että haluat poistaa kyseisen rivin tietokannastasi? Tämä poistaa kaikki syöttämäsi tiedot tietokantaan.", "Vahvista valintasi!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (connection) 
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(deleteQuery, connection)) 
                        {
                            command.Parameters.AddWithValue("@id", poistoID);
                            command.ExecuteNonQuery();
                        }
                    }
                    dgvPalvelut.Rows.RemoveAt(valittuIndex);
                    populatedgvPalvelut();
                }
            }
        }

        private void dgvPalvelut_MouseClick(object sender, MouseEventArgs e)
        {
            //siirtää datagridviewissä olevan rivin tiedot takaisin textboxeihin

            tbPalveluID.Text = dgvPalvelut.CurrentRow.Cells[0].Value.ToString();
            tbAlueID.Text = dgvPalvelut.CurrentRow.Cells[1].Value.ToString();
            tbPalvelunimi.Text = dgvPalvelut.CurrentRow.Cells[2].Value.ToString();
            tbPalvelutyyppi.Text = dgvPalvelut.CurrentRow.Cells[3].Value.ToString();
            rtbPalvelukuvaus.Text = dgvPalvelut.CurrentRow.Cells[4].Value.ToString();
            tbPalveluhinta.Text = dgvPalvelut.CurrentRow.Cells[5].Value.ToString();
            tbPalvelualv.Text = dgvPalvelut.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnTakaisinAloitusFormiin_Click(object sender, EventArgs e)
        {
            Form formaloitus = new Form1();
            this.Hide();

            formaloitus.ShowDialog();
            this.Close();
        }
    }
}
