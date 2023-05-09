
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Diagnostics;
using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Annot;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System.Net.Mail;


namespace Mokkivarausjarjestelma
{
    public partial class FormLaskutus : Form
    {
        public FormLaskutus()
        {
            InitializeComponent();
            paivitalaskudgv();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog='vn';username=root;password=Ruutti");
        MySqlCommand command;

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
            Form formaloitus = new Form1();
            this.Hide();

            formaloitus.ShowDialog();
            this.Close();
        }

        private void btnLahetalasku_Click(object sender, EventArgs e)
        {
            string kohde = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/lasku.pdf";
            PdfWriter writer = new PdfWriter(kohde);
            PdfDocument pdf = new PdfDocument(writer);
            Document lasku = new Document(pdf);
            PageSize ps = PageSize.A4;


            Paragraph header = new Paragraph("Village Newbies laskusi").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20);
            lasku.Add(header);
            lasku.Add(new Paragraph("Asiakkaan tiedot").SetFontSize(20));
            connection.Open();

            string varausID = "SELECT etunimi, sukunimi, email, puhelinnro, lahiosoite, postinro FROM lasku " +
                       "INNER JOIN varaus on varaus.varaus_id = lasku.varaus_id " +
                       "INNER JOIN asiakas on asiakas.asiakas_id = varaus.asiakas_id " +
                       "WHERE lasku.lasku_id=" + dgvLaskutus.CurrentRow.Cells[0].Value.ToString(); ;

            string kylysummasta = "SELECT summa FROM lasku WHERE lasku_id=" + dgvLaskutus.CurrentRow.Cells[0].Value.ToString();

            MySqlCommand komento1 = new MySqlCommand(kylysummasta, connection);
            MySqlCommand komento2 = new MySqlCommand(varausID, connection);
            MySqlDataReader reader = komento2.ExecuteReader();
            reader.Read();
            // Laskutettavan tiedot tietokannasta 
            lasku.Add(new Paragraph("Nimi: " + reader.GetString(0) + " " + reader.GetString(1)).SetFontSize(10));
            lasku.Add(new Paragraph("Sähköposti: " + reader.GetString(2)).SetFontSize(10));
            lasku.Add(new Paragraph("Puhelinnumero: " + reader.GetString(3)).SetFontSize(10));
            lasku.Add(new Paragraph("Lähiosoite ja postinumero: " + reader.GetString(4) + ", " + reader.GetString(5)).SetFontSize(10));
            lasku.Add(new Paragraph("").SetFontSize(10));
            reader.Close();
            MySqlDataReader lukija = komento1.ExecuteReader();
            lukija.Read();
            //Laskuttajan tiedot
            lasku.Add(new Paragraph("Laskuttajan tiedot").SetFontSize(30));
            lasku.Add(new Paragraph("Nimi: Village Newbies").SetFontSize(10));
            lasku.Add(new Paragraph("Osoite: Microkatu 1, 70210, Kuopio").SetFontSize(10));
            lasku.Add(new Paragraph("Tilinumero: FI467XXXXXXXXXXX").SetFontSize(10));
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

        private void btnPoistaLasku_Click(object sender, EventArgs e)
        {
            connection.Open();
            string poista = "DELETE FROM lasku WHERE lasku_id=" + dgvLaskutus.CurrentRow.Cells[0].Value.ToString();
            MySqlCommand komento = new MySqlCommand(poista, connection);
            komento.ExecuteNonQuery();
            paivitalaskudgv();
            connection.Close(); 
        }
    }
}
