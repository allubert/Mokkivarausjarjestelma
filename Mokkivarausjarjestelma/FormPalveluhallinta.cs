using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        MySqlCommand command;

        public void populatedgvPalvelut()
        {
            //hae dataa
            string selectQuery = "SELECT * FROM palvelu";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvPalvelut.DataSource = table;
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

        private void btnPalveluLisaa_Click(object sender, EventArgs e)
        {
            //Palvelu tietojen lisääminen tietokantaan sekä datagridviewiin, tiedon lisääminen ei onnistu mikäli käyttäjä yrittää käyttää samaa palveluID:tä

            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (tb.Text == "")
                {
                    tb.Focus();
                    MessageBox.Show("Et ole täyttänyt kaikkia kenttiä!");
                    return;
                }
            }

            int palveluid = int.Parse(tbPalveluID.Text);
            int alueid = int.Parse(tbAlueID.Text);
            string nimi = tbPalvelunimi.Text;
            int tyyppi = int.Parse(tbPalvelutyyppi.Text);
            string palvelukuvaus = rtbPalvelukuvaus.Text;
            double hinta = double.Parse(tbPalveluhinta.Text);
            double alv = double.Parse(tbPalvelualv.Text);

            string insertQuery = "INSERT INTO palvelu(palvelu_id, alue_id, nimi, tyyppi, kuvaus, hinta, alv) VALUES (@palveluid, @alueid, @nimi, @tyyppi, @palvelukuvaus, @hinta, @alv)";


            using (connection)
            {
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    try
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
                        populatedgvPalvelut();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Alue ID:si on väärin, syötä jo olemassa oleva alueID");
                    }
                }
        
            }
        }

        private void btnPalveluPaivita_Click(object sender, EventArgs e)
        {
            try
            {
                using (connection)
                {
                    string query = "UPDATE palvelu SET alue_id=@alueid, nimi=@nimi, tyyppi=@tyyppi, kuvaus=@palvelukuvaus, hinta=@hinta, alv=@alv WHERE palvelu_id=@palveluid";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@alueid", tbAlueID.Text);
                        command.Parameters.AddWithValue("@nimi", tbPalvelunimi.Text);
                        command.Parameters.AddWithValue("@tyyppi", tbPalvelutyyppi.Text);
                        command.Parameters.AddWithValue("@palvelukuvaus", rtbPalvelukuvaus.Text);
                        command.Parameters.AddWithValue("@hinta", tbPalveluhinta.Text);
                        command.Parameters.AddWithValue("@alv", tbPalvelualv.Text);
                        command.Parameters.AddWithValue("@palveluid", tbPalveluID.Text);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();
                        populatedgvPalvelut();
                    }
                }
                MessageBox.Show("Tietokannan päivittäminen onnistui", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) 
            {
                MessageBox.Show("Tietokannan päivittäminen epäonnistui");
            }

        }

        private void btnPalveluPoista_Click(object sender, EventArgs e)
        {
            //poistaa tiedot datagridviewistä sekä tietokannasta

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

        private void FormPalveluhallinta_Load(object sender, EventArgs e)
        {
            //päivittää datagridviewin heti sovelluksen käynnistäessä

            populatedgvPalvelut();
        }
        public void EmptyTB(Control con)
        {
            //määritellään tekstikenttien tyhjennys
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is RichTextBox) 
                {
                    ((RichTextBox)c).Clear();
                }
                else
                {
                    EmptyTB(c);
                }
            }
        }

        private void btnPalveluTyhj_Click(object sender, EventArgs e)
        {
            //varmistaa käyttäjältä haluaako hän tyhjentää napin painalluksellaan kaikki tekstikentät tyhjiksi

            DialogResult result = MessageBox.Show("Oletko varma, että haluat tyhjentää kaikki tekstikentät?", "Vahvista valintasi!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EmptyTB(this);
            }
        }

        private void btnHae_Click(object sender, EventArgs e)
        {
            //hakee tiedot palveluid kautta datagridviewistä ja maalaa kyseisen rivin datagridviewistä

            try
            {
                string hakuQuery = "SELECT * FROM palvelu WHERE palvelu_id = @palveluid";
                string palveluid = tbPalveluID.Text;

                DataTable datatable = new DataTable();
                using (connection)
                {
                    MySqlCommand command = new MySqlCommand(hakuQuery, connection);
                    command.Parameters.AddWithValue("@palveluid", palveluid);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(datatable);
                }

                if (datatable.Rows.Count > 0)
                {
                    dgvPalvelut.DataSource = datatable;
                    foreach (DataGridViewRow row in dgvPalvelut.Rows)
                    {
                        if (row.Cells["palvelu_id"].Value.ToString() == palveluid)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ei tuloksia.");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMokit_Click(object sender, EventArgs e)
        {
            Form formmokit = new FormMokitJaMokkivaraukset();
            this.Hide();

            formmokit.ShowDialog();
            this.Close();
        }

        private void btnVarauspalvelut_Click(object sender, EventArgs e)
        {
            Form varauspalvelut = new FormVarauksenpalvelut();
            this.Hide();

            varauspalvelut.ShowDialog();
            this.Close();
        }

        private void tbPalveluID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("ID pitää syöttää numeromuodossa!");
                e.Handled = true;
            }
        }

        private void tbAlueID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("ID pitää syöttää numeromuodossa!");
                e.Handled = true;
            }
        }

        private void tbPalvelutyyppi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("ID pitää syöttää numeromuodossa!");
                e.Handled = true;
            }
        }

        private void tbPalvelunimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
