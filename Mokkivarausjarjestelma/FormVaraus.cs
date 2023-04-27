using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class FormVaraus : Form
    {
        public FormVaraus(string VarausMokinNimi)
        {
            InitializeComponent();
            lblVarausMokinNimi.Text = VarausMokinNimi;
            string selectQuery = "SELECT * FROM varaus";
            DataTable datatable = new DataTable();
            MySqlConnection myconnection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti");
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, myconnection);
            dgMokkiVaraukset.DataSource = datatable;
            adapter.Fill(datatable);
            myconnection.Close();

        }
        //"INSERT INTO palvelu(palvelu_id, nimi, tyyppi, kuvaus, hinta, alv) VALUES("+palveluid+",'"+tbPalvelunimi.Text+"','"  +tyyppi+",'"+rtbPalvelukuvaus+"','"+hinta+",'"+alv+")";
        private void btnValmisVaraus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMokinVarausVahvista_Click(object sender, EventArgs e)
        {
            DateTime dtFrom = Convert.ToDateTime(dateTimeMokinVarausAlkuPvm.Text);
            DateTime dtTo = Convert.ToDateTime(dateTimeMokinVarausLoppuPvm.Text);

            /*
            MySqlConnection myconnection = new MySqlConnection("datasource=localhost;port=3307;username=root;password=Ruutti");
            command = new MySqlCommand(query, myconnection);
            DataSet ds = new DataSet();
            mda.Fill(ds);
            dbgrid1.DataSource = ds;
            dbgrid1.Refresh
            myconnection.Close();
            */
            btnValmisVaraus.Enabled = true;
        }
    }
}
