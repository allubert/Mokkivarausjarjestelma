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
        private bool isUpdating = false;

        public FormMokitJaMokkivaraukset()
        {
            InitializeComponent();
            dgMokkiLista.AutoGenerateColumns = true;
            UpdatedgMokkiLista();
            this.Shown += Form_Shown; // ilman tätä dgv:n tietorivi on automaattisesti valittuna, kun käyttäjä avaa formin
            btnMuokkaaValitunMokinTietoja.Enabled = false;
        }
        // ilman tätä dgv:n tietorivi on automaattisesti valittuna, kun käyttäjä avaa formin
        private void Form_Shown(object sender, EventArgs e)
        {
            dgMokkiLista.ClearSelection();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog='vn';username=root;password=Ruutti");

        private void btnUusiVaraus_Click(object sender, EventArgs e)
        {
            var VarausForm = new FormVaraus();
            VarausForm.Show();
        }
        private void UpdatedgMokkiLista()
        {
            // Mökkivarausten hallinnan datagridviewiin tietojen vienti
            string selectQuery = "SELECT * FROM mokki";
            DataTable datatable = new DataTable();
            using (connection)
            {
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(datatable);
                connection.Close();
            }
            dgMokkiLista.DataSource = datatable;
        }

        //Lisää uuden mökin tiedot tietokantaan
        private void btnLisaaMokinTiedot_Click(object sender, EventArgs e)
        {
            if (btnLisaaMokinTiedot.Text == "Lisää mökin tiedot")
            {
                if (ValidateTextBoxes())
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
                    using (connection)
                    {
                        using (MySqlCommand command = new MySqlCommand(MokintiedotInsertQuery, connection))
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
                            connection.Open();
                            try
                            {
                                command.ExecuteNonQuery();
                            }
                            catch (MySqlException ex)
                            {
                                if (ex.Number == 1062) // ID on jo käytössä
                                {
                                    MessageBox.Show("Mökki ID on jo olemassa. Valitse uusi ID.");
                                }
                                else
                                {
                                    MessageBox.Show("Virhe tiedonsiirrossa: " + ex.Message);
                                }
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                    UpdatedgMokkiLista();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Tarkasta tekstikenttien täyttö");
                }
            }
            else if (btnLisaaMokinTiedot.Text == "Tyhjennä tekstikentät")
            {
                ClearTextBoxes();
                tbValittuMokkiMokkiID.ReadOnly = false;
                tbValittuMokkiAlueID.ReadOnly = false;
                tbValittuMokkiPostiNro.ReadOnly = false;
                tbValittuMokkiNimi.ReadOnly = false;
                tbValittuMokkiOsoite.ReadOnly = false;
                tbValittuMokkiHintaVrk.ReadOnly = false;
                rtbValittuMokkiKuvaus.ReadOnly = false;
                tbValittuMokkiHloMaara.ReadOnly = false;
                rtbValittuMokkiVarustelu.ReadOnly = false;
                isUpdating = false;
                btnLisaaMokinTiedot.Text = "Lisää mökin tiedot";
                btnMuokkaaValitunMokinTietoja.Enabled = false;
            }
        }
        private void ClearTextBoxes()
        {
            tbValittuMokkiMokkiID.Clear();
            tbValittuMokkiAlueID.Clear();
            tbValittuMokkiPostiNro.Clear();
            tbValittuMokkiNimi.Clear();
            tbValittuMokkiOsoite.Clear();
            tbValittuMokkiHintaVrk.Clear();
            rtbValittuMokkiKuvaus.Clear();
            tbValittuMokkiHloMaara.Clear();
            rtbValittuMokkiVarustelu.Clear();
        }

        private void dgMokkiLista_SelectionChanged(object sender, EventArgs e)
        {
            if (dgMokkiLista.SelectedRows.Count > 0 && dgMokkiLista.Focused && !isUpdating)
            {
                tbValittuMokkiMokkiID.ReadOnly = true;
                tbValittuMokkiAlueID.ReadOnly = true;
                tbValittuMokkiPostiNro.ReadOnly = true;
                tbValittuMokkiNimi.ReadOnly = true;
                tbValittuMokkiOsoite.ReadOnly = true;
                tbValittuMokkiHintaVrk.ReadOnly = true;
                rtbValittuMokkiKuvaus.ReadOnly = true;
                tbValittuMokkiHloMaara.ReadOnly = true;
                rtbValittuMokkiVarustelu.ReadOnly = true;

                tbValittuMokkiMokkiID.Text = dgMokkiLista.CurrentRow.Cells[0].Value.ToString();
                tbValittuMokkiAlueID.Text = dgMokkiLista.CurrentRow.Cells[1].Value.ToString();
                tbValittuMokkiPostiNro.Text = dgMokkiLista.CurrentRow.Cells[2].Value.ToString();
                tbValittuMokkiNimi.Text = dgMokkiLista.CurrentRow.Cells[3].Value.ToString();
                tbValittuMokkiOsoite.Text = dgMokkiLista.CurrentRow.Cells[4].Value.ToString();
                tbValittuMokkiHintaVrk.Text = dgMokkiLista.CurrentRow.Cells[5].Value.ToString();
                rtbValittuMokkiKuvaus.Text = dgMokkiLista.CurrentRow.Cells[6].Value.ToString();
                tbValittuMokkiHloMaara.Text = dgMokkiLista.CurrentRow.Cells[7].Value.ToString();
                rtbValittuMokkiVarustelu.Text = dgMokkiLista.CurrentRow.Cells[8].Value.ToString();
                btnMuokkaaValitunMokinTietoja.Enabled = true;
                btnLisaaMokinTiedot.Text = "Tyhjennä tekstikentät";
            }
            else
            {
                btnLisaaMokinTiedot.Text = "Lisää mökin tiedot";
            }
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
                    string TarkastaMahdollisetVarauksetMokilleQuery = "SELECT * FROM varaus WHERE mokki_mokki_id = @mokkiid";

                    using (connection)
                    {
                        using (MySqlCommand checkCommand = new MySqlCommand(TarkastaMahdollisetVarauksetMokilleQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@mokkiid", mokkiid);
                            connection.Open();
                            MySqlDataReader reader = checkCommand.ExecuteReader();

                            if (!reader.HasRows) // true = Mökille ei varauksia, joten sen voi poistaa
                            {
                                reader.Close();
                                string PoistaMokinTiedotQuery = "DELETE FROM mokki WHERE mokki_id = @mokkiid";
                                using (MySqlCommand command = new MySqlCommand(PoistaMokinTiedotQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@mokkiid", mokkiid);
                                    command.ExecuteNonQuery();
                                }
                                UpdatedgMokkiLista();
                                ClearTextBoxes();
                            }
                            else
                            {
                                MessageBox.Show("Mökki on varattu. Sitä ei voi poistaa tietokannasta.");
                            }
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Valitse mökki, jonka haluat poistaa. Kokeile sitten uudelleen.");
            }
        }

        
        private void btnTakaisinAloitusFormiin_Click(object sender, EventArgs e)
        {
            Form formaloitus = new Form1();
            this.Hide();

            formaloitus.ShowDialog();
            this.Close();
        }
        private void btnMuokkaaValitunMokinTietoja_Click(object sender, EventArgs e)
        {
            if (!isUpdating)
            {
                // muokkaustila
                btnLisaaMokinTiedot.Enabled = false;
                btnMuokkaaValitunMokinTietoja.Text = "Valmis";
                tbValittuMokkiMokkiID.ReadOnly = false;
                tbValittuMokkiAlueID.ReadOnly = false;
                tbValittuMokkiPostiNro.ReadOnly = false;
                tbValittuMokkiNimi.ReadOnly = false;
                tbValittuMokkiOsoite.ReadOnly = false;
                tbValittuMokkiHintaVrk.ReadOnly = false;
                rtbValittuMokkiKuvaus.ReadOnly = false;
                tbValittuMokkiHloMaara.ReadOnly = false;
                rtbValittuMokkiVarustelu.ReadOnly = false;
                isUpdating = true;
            }
            else
            {
                if (ValidateTextBoxes())
                {
                    // tietokanta ja dgv päivittyvät
                    UpdateDatabaseAndDataGridView();
                    // pois muokkaustilasta
                    btnLisaaMokinTiedot.Enabled = true;
                    btnLisaaMokinTiedot.Text = "Tyhjennä tekstikentät";
                    btnMuokkaaValitunMokinTietoja.Text = "Muokkaa";
                    tbValittuMokkiMokkiID.ReadOnly = true;
                    tbValittuMokkiAlueID.ReadOnly = true;
                    tbValittuMokkiPostiNro.ReadOnly = true;
                    tbValittuMokkiNimi.ReadOnly = true;
                    tbValittuMokkiOsoite.ReadOnly = true;
                    tbValittuMokkiHintaVrk.ReadOnly = true;
                    rtbValittuMokkiKuvaus.ReadOnly = true;
                    tbValittuMokkiHloMaara.ReadOnly = true;
                    rtbValittuMokkiVarustelu.ReadOnly = true;
                    // Set ReadOnly properties to true for all textboxes
                    isUpdating = false;
                    btnMuokkaaValitunMokinTietoja.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Tarkasta tekstikenttien täyttö");
                }
                
            }
        }
        private void UpdateDatabaseAndDataGridView()
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

            string updateQuery = "UPDATE mokki SET alue_id=@alueid, postinro=@postinro, mokkinimi=@mokkinimi, katuosoite=@katuosoite, hinta=@hinta, kuvaus=@mokinkuvaus, henkilomaara=@hlomaara, varustelu=@mokinvarustelu WHERE mokki_id=@mokkiid";

            using (connection)
            {
                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
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

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            UpdatedgMokkiLista();
        }
        private bool ValidateTextBoxes()
        {
            int mokkiid;
            int alueid;
            double hinta;
            int hlomaara;

            // tarkastaa int-tekstikentät
            if (!int.TryParse(tbValittuMokkiMokkiID.Text, out mokkiid) ||
                !int.TryParse(tbValittuMokkiAlueID.Text, out alueid) ||
                !int.TryParse(tbValittuMokkiHloMaara.Text, out hlomaara))
            {
                return false;
            }

            // tarkastaa double-tekstikentät
            if (!double.TryParse(tbValittuMokkiHintaVrk.Text, out hinta))
            {
                return false;
            }

            // tarkastaa string-tekstikentät
            if (string.IsNullOrWhiteSpace(tbValittuMokkiPostiNro.Text) ||
                string.IsNullOrWhiteSpace(tbValittuMokkiNimi.Text) ||
                string.IsNullOrWhiteSpace(tbValittuMokkiOsoite.Text) ||
                string.IsNullOrWhiteSpace(rtbValittuMokkiKuvaus.Text) ||
                string.IsNullOrWhiteSpace(rtbValittuMokkiVarustelu.Text))
            {
                return false;
            }

            return true;
        }


    }
}
