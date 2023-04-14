namespace Mokkivarausjarjestelma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}