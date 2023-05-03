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
        public string VarausmokinNimi;
        public FormVaraus(string VarausMokinNimi)
        {
            InitializeComponent();
            lblVarausMokinNimi.Text = VarausMokinNimi;
            VarausmokinNimi = VarausMokinNimi;
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
        
            DateTime varattualkupvm = Convert.ToDateTime(dateTimeMokinVarausAlkuPvm.Text);
            DateTime varattuloppupvm = Convert.ToDateTime(dateTimeMokinVarausLoppuPvm.Text);

            int asiakasid;
            int mokkimokkiid;

            // Kriteerit mokki_mokki_id ja 
            string asiakasKriteerit = "";
            string mokkiKriteerit = "mokkinimi = " + VarausmokinNimi;

            string GetIdsQuery = $@"SELECT asiakas.asiakas_id, mokki.mokki_id
                            FROM asiakas, mokki
                            WHERE asiakas.criteria = '{asiakasKriteerit}' AND mokki.criteria = '{mokkiKriteerit}'";

            using (MySqlConnection myconnection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti"))
            {
                myconnection.Open();

                using (MySqlCommand getIdCommand = new MySqlCommand(GetIdsQuery, myconnection))
                {
                    using (MySqlDataReader reader = getIdCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            asiakasid = reader.GetInt32(0);
                            mokkimokkiid = reader.GetInt32(1);
                        }
                        else
                        {
                            // Ei löydy yhtäläisyyksiä
                            return;
                        }
                    }
                }
                string VarauksentiedotInsertQuery = "INSERT INTO varaus(varaus_id, asiakas_id, mokki_mokki_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm)" +
                "VALUES (@varausid, @asiakasid, @mokkimokkiid, @varattupvm, @vahvistuspvm, @varattualkupvm, @varattuloppupvm)";

                using (MySqlCommand command = new MySqlCommand(VarauksentiedotInsertQuery, myconnection))
                {
                    //command.Parameters.AddWithValue("@varausid", varausid);
                    command.Parameters.AddWithValue("@asiakasid", asiakasid);
                    command.Parameters.AddWithValue("@mokkimokkiid", mokkimokkiid);
                    command.Parameters.AddWithValue("@varattupvm", DateTime.Now);
                    command.Parameters.AddWithValue("@vahvistuspvm", DateTime.Now);
                    command.Parameters.AddWithValue("@varattualkupvm", varattualkupvm);
                    command.Parameters.AddWithValue("@varattuloppupvm", varattuloppupvm);

                    command.ExecuteNonQuery();
                }
                myconnection.Close();

            }
            this.Close();
        
        }

        private void btnMokinVarausVahvista_Click(object sender, EventArgs e)
        {
            //Tarkastaa, tuleeko päällekkäisiä varauksia
            btnValmisVaraus.Enabled = true;
        }
    }
}
