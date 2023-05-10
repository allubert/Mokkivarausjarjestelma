using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System.Data;


namespace Mokkivarausjarjestelma
{
    public partial class FormLaskutus : Form
    {
        public FormLaskutus()
        {
            InitializeComponent();
            paivitalaskudgv();
            paivitacomboboksi();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog='vn';username=root;password=Ruutti");
        MySqlCommand command;
        //päivittää datagridin tiedot sen perusteella, mitä käyttäjä syöttää

        public void paivitacomboboksi()
        {

            string kysely = "SELECT varaus_id FROM varaus";
            MySqlDataAdapter adapteri = new MySqlDataAdapter(kysely, connection);
            DataTable table = new DataTable();
            adapteri.Fill(table);
            cbVarausId.DataSource = table;
            cbVarausId.DisplayMember = "varaus_id";

        }
        public void paivitalaskudgv()
        {
            try
            {
                string kysely = "SELECT * from lasku";
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(kysely, connection);
                adapter.Fill(dt);
                dgvLaskutus.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tietojen hakeminen tietokannasta ei onnistunut");
            }

        }
        private void btnTakaisinAloitusFormiin_Click(object sender, EventArgs e)
        {
            //alkuvalikkoon kysely 
            DialogResult result = MessageBox.Show("Haluatko varmasti siirtyä alkuvalikkoon?", "Varoitus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form formaloitus = new Form1();
                this.Hide();
                formaloitus.ShowDialog();
                this.Close();
            }

        }

        private void btnLahetalasku_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                // kysely varauksesta ja perään alikyselyä tiedoista 
                string varausID = "SELECT etunimi, sukunimi, email, puhelinnro, lahiosoite, postinro FROM lasku " +
                           "INNER JOIN varaus on varaus.varaus_id = lasku.varaus_id " +
                           "INNER JOIN asiakas on asiakas.asiakas_id = varaus.asiakas_id " +
                           "WHERE lasku.lasku_id=" + dgvLaskutus.CurrentRow.Cells[0].Value.ToString(); ;
                // laskuid tässäkin sen perusteella, mitä käyttäjä on valinnut dokumentista 
                string kylysummasta = "SELECT summa FROM lasku WHERE lasku_id=" + dgvLaskutus.CurrentRow.Cells[0].Value.ToString();
                MySqlCommand komento1 = new MySqlCommand(kylysummasta, connection);
                MySqlCommand komento2 = new MySqlCommand(varausID, connection);
                MySqlDataReader reader = komento2.ExecuteReader();
                reader.Read();

                // tallentaa tiedon dokumentteihin, mikäli käyttäjällä on sellainen 
                string kohde = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Village Newbies lasku " + " " + reader.GetString(0) + " " + reader.GetString(1) + ".pdf";
                PdfWriter writer = new PdfWriter(kohde);
                PdfDocument pdf = new PdfDocument(writer);
                Document lasku = new Document(pdf);
                PageSize ps = PageSize.A4;

                //Laskun otsikko 
                Paragraph header = new Paragraph("Village Newbies laskusi").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20);
                lasku.Add(header);
                lasku.Add(new Paragraph("Asiakkaan tiedot").SetFontSize(20));
                // Laskutettavan tiedot tietokannasta 
                lasku.Add(new Paragraph("Nimi: " + reader.GetString(0) + " " + reader.GetString(1)).SetFontSize(10));
                lasku.Add(new Paragraph("Sähköposti: " + reader.GetString(2)).SetFontSize(10));
                lasku.Add(new Paragraph("Puhelinnumero: " + reader.GetString(3)).SetFontSize(10));
                lasku.Add(new Paragraph("Lähiosoite ja postinumero: " + reader.GetString(4) + ", " + reader.GetString(5)).SetFontSize(10));
                lasku.Add(new Paragraph("").SetFontSize(10));
                reader.Close();
                MySqlDataReader lukija = komento1.ExecuteReader();
                lukija.Read();
                //Laskuttajan tiedot itse keksittynä 
                lasku.Add(new Paragraph("Laskuttajan tiedot").SetFontSize(30));
                lasku.Add(new Paragraph("Nimi: Village Newbies").SetFontSize(10));
                lasku.Add(new Paragraph("Osoite: Microkatu 1, 70210, Kuopio").SetFontSize(10));
                lasku.Add(new Paragraph("Tilinumero: FI4672456623432312").SetFontSize(10));
                lasku.Add(new Paragraph("Hinta: " + lukija.GetDouble(0) + "€").SetFontSize(10));
                lasku.Add(new Paragraph("Maksuehto: 14pv").SetFontSize(10));
                lasku.Add(new Paragraph("Viivästyskorko: 10%").SetFontSize(10));
                lukija.Close();
                lasku.Close();
                connection.Close();

                MessageBox.Show("Laskun tallentaminen onnistui", "Ilmoitus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reader.Close();

                paivitalaskudgv();
            }
            //mikäli tulee poikkeus, niin ilmoittaa sen tässä 
            catch (Exception ex)
            {
                MessageBox.Show("Jokin meni pieleen");
            }
        }
        // laskun poistamiseen funktio, joka kyselyn perusteella poistaa laskun tietokannasta. Tämäkin tapahtuu lasku_id:n perusteella. 
        private void btnPoistaLasku_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string poista = "DELETE FROM lasku WHERE lasku_id=" + dgvLaskutus.CurrentRow.Cells[0].Value.ToString();
                MySqlCommand komento = new MySqlCommand(poista, connection);
                komento.ExecuteNonQuery();
                paivitalaskudgv();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Poistaminen epäonnistui. Tsekkaa varaus_ID");
            }
        }

        private void btnHae_Click(object sender, EventArgs e)
        {
            try
            {
                // kysely loppu ja alkupvm, jotta saadaan montako päivää varaaja oli siellä
                string kysely = ("SELECT mokki.mokki_id, CAST(DATEDIFF(varaus.varattu_loppupvm, varaus.varattu_alkupvm) AS INT) AS jotain FROM varaus JOIN mokki ON varaus.mokki_mokki_id = mokki.mokki_id WHERE varaus.varaus_id=") + cbVarausId.Text;
                int mokki_mokki_id;
                int jotain;
                double mokkihinta;
                int palvelulkm;
                double palveluhinta;
                int palveluid;
                double summa;
                connection.Open();
                //ensimmäinen kysely, jolla selvitetään mökki_id
                using (MySqlCommand command = new MySqlCommand(kysely, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        mokki_mokki_id = reader.GetInt32("mokki_id");
                        jotain = reader.GetInt32("jotain");
                        reader.Close();
                    }
                }
                connection.Close();
                string kysely1 = ("SELECT hinta FROM mokki WHERE mokki_id=" + mokki_mokki_id);
                connection.Open();

                // tässä selvitetään mökin hinta vrk
                using (MySqlCommand komento = new MySqlCommand(kysely1, connection))
                {
                    using (MySqlDataReader lukija = komento.ExecuteReader())
                    {
                        lukija.Read();
                        mokkihinta = lukija.GetDouble("hinta");
                        lukija.Close();
                    }
                }
                connection.Close();

                string kysely2 = "SELECT lkm, palvelu_id FROM varauksen_palvelut WHERE varaus_id=@varaus_id";
                connection.Open();
                // selvitetään palveluiden lukumäärä ja palveluid kyseiselle varaukselle 
                using (MySqlCommand komento2 = new MySqlCommand(kysely2, connection))
                {
                    komento2.Parameters.AddWithValue("@varaus_id", cbVarausId.Text);
                    using (MySqlDataReader lukija2 = komento2.ExecuteReader())
                    {
                        lukija2.Read();
                        palvelulkm = lukija2.GetInt32("lkm");
                        palveluid = lukija2.GetInt32("palvelu_id");
                        lukija2.Close();
                    }
                }
                connection.Close();
                // selvitetään palvelun hinta palveluid:n perusteella 
                string kysely3 = ("SELECT hinta FROM palvelu where palvelu_id=" + palveluid);
                connection.Open();
                using (MySqlCommand komento3 = new MySqlCommand(kysely3, connection))
                {
                    using (MySqlDataReader lukija3 = komento3.ExecuteReader())
                    {
                        lukija3.Read();
                        palveluhinta = lukija3.GetDouble("hinta");
                        lukija3.Close();
                    }
                }
                connection.Close();
                // lasketaan summa yhteen 
                summa = (jotain * mokkihinta + palvelulkm * palveluhinta);

                tbSumma.Text = summa.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarkista varausID uudelleen");
            }
        }

        private void btnLisää_Click(object sender, EventArgs e)
        {
            // mikäli jokin kenttä on tyhjä niin sovellus ilmoittaa
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (tb.Text == "")
                {
                    tb.Focus();
                    MessageBox.Show("Kaikkia kenttiä ei ole täytetty");
                    return;
                }
            }
            int laskuid = int.Parse(tbLaskuID.Text);
            int varausid = int.Parse(cbVarausId.Text);
            double summa = double.Parse(tbSumma.Text);
            double alv = double.Parse(tbAlv.Text);
            string kysely = ("INSERT INTO lasku(lasku_id, varaus_id, summa, alv) VALUES (@laskuid, @varausid, @summa, @alv)");

            try
            {
                using (MySqlCommand komento = new MySqlCommand(kysely, connection))
                {
                    connection.Open();
                    komento.Parameters.AddWithValue("@laskuid", laskuid);
                    komento.Parameters.AddWithValue("@varausid", varausid);
                    komento.Parameters.AddWithValue("@summa", summa);
                    komento.Parameters.AddWithValue("@alv", alv);
                    komento.ExecuteNonQuery();
                }
                connection.Close();
                paivitalaskudgv();
                MessageBox.Show("Tietojen lisääminen onnistui", "Ilmoitus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Jokin meni pieleen. Tarkista varaus_id");
            }

        }

        private void dgvLaskutus_Click(object sender, EventArgs e)
        {
            tbLaskuID.Text = dgvLaskutus.CurrentRow.Cells[0].Value.ToString();
            cbVarausId.Text = dgvLaskutus.CurrentRow.Cells[1].Value.ToString();
            tbSumma.Text = dgvLaskutus.CurrentRow.Cells[2].Value.ToString();
            tbAlv.Text = dgvLaskutus.CurrentRow.Cells[3].Value.ToString();
        }

        private void tbLaskuID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
