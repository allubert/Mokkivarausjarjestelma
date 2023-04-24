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
            adapter.Fill(table); //ongelma kun yritt‰‰ syˆtt‰‰ tietoa
            dgvPalvelut.DataSource = table;
        }

        private void dgvPalvelut_MouseClick(object sender, MouseEventArgs e)
        {
            //siirt‰‰ datagridviewiss‰ olevan rivin tiedot takaisin textboxeihin

            tbPalveluID.Text = dgvPalvelut.CurrentRow.Cells[0].Value.ToString();
            tbPalvelunimi.Text = dgvPalvelut.CurrentRow.Cells[1].Value.ToString();
            tbPalvelutyyppi.Text = dgvPalvelut.CurrentRow.Cells[2].Value.ToString();
            rtbPalvelukuvaus.Text = dgvPalvelut.CurrentRow.Cells[3].Value.ToString();
            tbPalveluhinta.Text = dgvPalvelut.CurrentRow.Cells[4].Value.ToString();
            tbPalvelualv.Text = dgvPalvelut.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnPalveluLisaa_Click(object sender, EventArgs e)
        {
            //Palvelu tietojen lis‰‰minen tietokannan tauluun "palvelu"

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
                    MessageBox.Show("Kysely‰ ei suoritettu");
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
    }
}