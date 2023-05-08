
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
                       "WHERE lasku.lasku_id=" + dgvLaskutus.SelectedRows[0].Cells[0].Value;

            string kylysummasta = "SELECT summa FROM lasku WHERE lasku_id=" + dgvLaskutus.SelectedRows[0].Cells[0].Value;

            MySqlCommand komento1 = new MySqlCommand(varausID, connection);
            MySqlCommand komento2 = new MySqlCommand(kylysummasta, connection);
            MySqlDataReader reader = komento1.ExecuteReader();
            MySqlDataReader lukija = komento2.ExecuteReader();
            reader.Read();

            lasku.Add(new Paragraph("Nimi: " + reader.GetString(0) + " " + reader.GetString(1)).SetFontSize(10));
            lasku.Add(new Paragraph("Sähköposti: " + reader.GetString(2)).SetFontSize(10));
            lasku.Add(new Paragraph("Puhelinnumero: " + reader.GetString(3)).SetFontSize(10));
            lasku.Add(new Paragraph("Lähiosoite ja postinumero: " + reader.GetString(4) + ", " + reader.GetString(5)).SetFontSize(10));
            lasku.Add(new Paragraph("").SetFontSize(10));
            //Laskuttajan tiedot
            lasku.Add(new Paragraph("Laskuttajan tiedot").SetFontSize(30));
            lasku.Add(new Paragraph("Nimi: Village Newbies").SetFontSize(10));
            lasku.Add(new Paragraph("Osoite: Microkatu 1, 70210, Kuopio").SetFontSize(10));
            lasku.Add(new Paragraph("Tilinumero: FI467XXXXXXXXXXX").SetFontSize(10));
            lasku.Add(new Paragraph("Hinta: " + lukija.GetDouble(0) + "€").SetFontSize(10));
            lasku.Add(new Paragraph("Maksuehto: 14pv").SetFontSize(10));
            lasku.Add(new Paragraph("Viivästyskorko: 10%").SetFontSize(10));

            lasku.Close();  

            MailMessage sahkoposti = new MailMessage(); 
            SmtpClient servu = new SmtpClient("smtp.gmail.com");

            sahkoposti.From = new MailAddress("villagenewbies@gmail.com");
            sahkoposti.To.Add(reader.GetString(2));
            connection.Close();
            sahkoposti.Subject = "Village Newbies laskusi";
            sahkoposti.Body = "Tämän viestin liitteenä on laskusi mökkivarauksesta Village Newbies:n kautta";
            Attachment laskupdf = new Attachment(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/lasku.pdf");
            laskupdf.Name = "lasku.pdf";
            sahkoposti.Attachments.Add(laskupdf);

            string käyttäjä = "villagenewbies@gmail.com";
            string salis = "noobs123";

            servu.Port = 587;
            servu.UseDefaultCredentials = false;
            servu.Credentials = new System.Net.NetworkCredential(käyttäjä, salis);
            servu.EnableSsl = true;

            servu.Send(sahkoposti);
            MessageBox.Show("Laskun lähettäminen onnistui", "Ilmoitus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reader.Close();

            paivitalaskudgv(); 
        }
    }
}
