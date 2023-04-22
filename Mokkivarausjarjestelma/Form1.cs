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

            populateDGV();
        }

        public void populateDGV() 
        {
            //hae dataa
            string selectQuery = "SELECT * FROM palvelut";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvPalvelut.DataSource = table;
            dgvPalvelut.Update();
        }











































        //Maunon koodirivit 100-150
        //BLAA BLAA BLAA

    }
}