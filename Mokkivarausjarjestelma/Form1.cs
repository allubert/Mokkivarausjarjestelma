using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Mokkivarausjarjestelma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog='vn';username=root;password=Ruutti");
        
        MySqlCommand command;

        private void btnPalvelu_Click(object sender, EventArgs e)
        {
            tbcHallinta.SelectedTab = tbpgPalveluhallinta;
        }

        private void btnToiminta_Click(object sender, EventArgs e)
        {
            tbcHallinta.SelectedTab = tbpgToimintaaluehallinta;
        }

        private void btnLasku_Click(object sender, EventArgs e)
        {
            tbcHallinta.SelectedTab = tbpgLaskujenhallinta;
        }
        
        private void btnMokkivaraus_Click(object sender, EventArgs e)
        {
            tbcHallinta.SelectedTab = tbpgMokkivaraushallinta;
        }

        private void btnAsiakas_Click(object sender, EventArgs e)
        {
            tbcHallinta.SelectedTab = tbpgAsiakashallinta;
        }

        private void tbpgPalveluhallinta_Click(object sender, EventArgs e)
        {
            populatedgvPalvelut();
        }

        public void populatedgvPalvelut()
        {
            //hae dataa
            string selectQuery = "SELECT * FROM palvelu";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table); //ongelma kun yrittää syöttää tietoa
            dgvPalvelut.DataSource = table;
        }

        public void populatedgvAsiakkaat()
        {
            string query = "SELECT * FROM asiakas";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dgvAsiakashallinta.DataSource = table;
        }

        private void dgvPalvelut_MouseClick(object sender, MouseEventArgs e)
        {
            //siirtää datagridviewissä olevan rivin tiedot takaisin textboxeihin

            tbPalveluID.Text = dgvPalvelut.CurrentRow.Cells[0].Value.ToString();
            tbPalvelunimi.Text = dgvPalvelut.CurrentRow.Cells[1].Value.ToString();
            tbPalvelutyyppi.Text = dgvPalvelut.CurrentRow.Cells[2].Value.ToString();
            rtbPalvelukuvaus.Text = dgvPalvelut.CurrentRow.Cells[3].Value.ToString();
            tbPalveluhinta.Text = dgvPalvelut.CurrentRow.Cells[4].Value.ToString();
            tbPalvelualv.Text = dgvPalvelut.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnPalveluLisaa_Click(object sender, EventArgs e)
        {
            //Palvelu tietojen lisääminen tietokannan tauluun "palvelu"

            int palveluid = int.Parse(tbPalveluID.Text);
            int tyyppi = int.Parse(tbPalvelutyyppi.Text);
            double hinta = double.Parse(tbPalveluhinta.Text);
            double alv = double.Parse(tbPalvelualv.Text);

            string insertQuery = "INSERT INTO palvelu(palvelu_id, nimi, tyyppi, kuvaus, hinta, alv) VALUES("+palveluid+",'"+tbPalvelunimi.Text+"','"
                +tyyppi+",'"+rtbPalvelukuvaus+"','"+hinta+",'"+alv+")";

            ExecuteMyQuery(insertQuery);

            populatedgvPalvelut();
        }

        private void btnPalveluPaivita_Click(object sender, EventArgs e)
        {
            dgvPalvelut.Update();
        }

        public void ExecuteMyQuery(string query) 
        {
            try
            {
                AvaaYhteys();

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
                SuljeYhteys();
            }
        }

        public void AvaaYhteys() 
        {
            //avaa tietokanta yhteyden tarkistettuaan onko yhteys kiinni
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void SuljeYhteys() 
        {
            //sulkee tietokanta yhteyden tarkistettuaan onko yhteys auki
            if (connection.State == ConnectionState.Open) 
            {
                connection.Close();
            }
        }

        private void btnToimintaLisaaAlue_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in pnlToiminta.Controls.OfType<TextBox>())
            {
                if (tb.Text == "") // Tarkistaa onko panelin sisällä olevat textiboxit täytetty, jos ei ole antaa virheilmoituksen.
                {
                    tb.Focus();
                    MessageBox.Show("Kaikkia kenttiä ei ole täytetty oikein.");
                    return;
                }
            }
            connection.Open(); // Avaa tietokanta yhteyden

            string insertQuery = "insert into toimintaalue(nimi) values (" + "'" + tbToimintaNimi.Text + "')";
        }

        private void btnUusiVaraus_Click(object sender, EventArgs e)
        {
            string VarausMokinNimi = tbValittuMokkiNimi.Text.ToString();
            var VarausForm = new FormVaraus(VarausMokinNimi);
            VarausForm.Show();
        }

        private void tbcHallinta_Selected(object sender, TabControlEventArgs e)
        {
            dgMokkiLista.AutoGenerateColumns = true;

            UpdatedgMokkiLista();
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

            String MokintiedotInsertQuery = ("INSERT INTO mokki(mokki_id, alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu) VALUES (mokkiid, alueid, postinro, mokkinimi, katuosoite, hinta, mokinkuvaus, hlomaara, mokinvarustelu)");
            MySqlConnection myconnection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti");
            command = new MySqlCommand(MokintiedotInsertQuery, myconnection);
            myconnection.Close();
            UpdatedgMokkiLista();
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

        private void btnAsiakasLisaa_Click(object sender, EventArgs e)
        {
            int asiakasid = int.Parse(tbAsiakasid.Text);

            string insertQuery = "insert into asiakas(asiakas_id, postinro, etunimi, sukunimi, lahiosoite, email, puhelinnro)values"+asiakasid+", '"
             +tbasiakasPostinumero.Text+"','"+tbAsiakasEtunimi.Text+"','"+tbAsiakasSukunimi.Text+"','"+tbAsiakasLahiosoite.Text+"','"
                + tbAsiakasSahkoposti.Text+"','"+tbAsiakasPuhelinnumero.Text+"')";
            MySqlConnection myconnection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti");
            command = new MySqlCommand(insertQuery, myconnection);
            myconnection.Close();
            UpdateAsiakkaat();
        }
        private void UpdateAsiakkaat()
        {
            string query = "SELECT * FROM asiakas";
            DataTable datatable = new DataTable();
            using (MySqlConnection myconnection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti"))
            {
                using (MySqlCommand command = new MySqlCommand(query, myconnection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(datatable);
                    connection.Close();
                }
            }
            dgvAsiakashallinta.DataSource = datatable; 
        }

        private void dgvAsiakashallinta_Click(object sender, EventArgs e)
        {
            tbAsiakasid.Text = dgvAsiakashallinta.CurrentRow.Cells[0].Value.ToString();
            int asiakasid = int.Parse(tbAsiakasid.Text);
            tbasiakasPostinumero.Text = dgvAsiakashallinta.CurrentRow.Cells[1].Value.ToString();
            tbAsiakasEtunimi.Text = dgvAsiakashallinta.CurrentRow.Cells[2].Value.ToString();
            tbAsiakasSukunimi.Text = dgvAsiakashallinta.CurrentRow.Cells[3].Value.ToString();
            tbAsiakasLahiosoite.Text = dgvAsiakashallinta.CurrentRow.Cells[4].Value.ToString();
            tbAsiakasSahkoposti.Text = dgvAsiakashallinta.CurrentRow.Cells[5].Value.ToString();
            tbAsiakasPuhelinnumero.Text = dgvAsiakashallinta.CurrentRow.Cells[6].Value.ToString(); 
        }
    }
}