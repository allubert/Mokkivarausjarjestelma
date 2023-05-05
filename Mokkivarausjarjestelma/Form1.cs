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
        /*
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;Initial Catalog='vn';username=root;password=Ruutti");

        MySqlCommand command;

        private void btnPalvelu_Click(object sender, EventArgs e)
        {
            tbcAsiakasHallinta.SelectedTab = tbpgPalveluhallinta;
        }

        private void btnToiminta_Click(object sender, EventArgs e)
        {
            tbcAsiakasHallinta.SelectedTab = tbpgToimintaaluehallinta;
        }

        private void btnLasku_Click(object sender, EventArgs e)
        {
            tbcAsiakasHallinta.SelectedTab = tbpgLaskujenhallinta;
        }

        private void btnMokkivaraus_Click(object sender, EventArgs e)
        {
            tbcAsiakasHallinta.SelectedTab = tbpgMokkivaraushallinta;
        }

        private void btnAsiakas_Click(object sender, EventArgs e)
        {
            tbcAsiakasHallinta.SelectedTab = tbpgAsiakashallinta;
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

            string insertQuery = "INSERT INTO palvelu(palvelu_id, nimi, tyyppi, kuvaus, hinta, alv) VALUES(" + palveluid + ",'" + tbPalvelunimi.Text + "','"
                + tyyppi + ",'" + rtbPalvelukuvaus + "','" + hinta + ",'" + alv + ")";

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

            string insertQuery = "insert into toimintaalue(nimi) values (" + "'" + tbToimintaAlue.Text + "')";
        }

        private void btnUusiVaraus_Click(object sender, EventArgs e)
        {
            string VarausMokinNimi = tbValittuMokkiNimi.Text.ToString();
            var VarausForm = new FormVaraus();
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
            string MokintiedotInsertQuery = "INSERT INTO mokki(mokki_id, alue_id, postinro, mokkinimi, katuosoite, hinta, kuvaus, henkilomaara, varustelu) VALUES (@mokkiid, @alueid, @postinro, @mokkinimi, @katuosoite, @hinta, @mokinkuvaus, @hlomaara, @mokinvarustelu)";
            using (MySqlConnection myconnection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti"))
            {
                using (MySqlCommand command = new MySqlCommand(MokintiedotInsertQuery, myconnection))
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

                    myconnection.Open();
                    command.ExecuteNonQuery();
                    myconnection.Close();
                }
            }
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
            foreach (TextBox tb in tbcAsiakasHallinta.Controls.OfType<TextBox>())
            {
                if (tb.Text == "")
                {
                    tb.Focus();
                    MessageBox.Show("Kaikkia kenttiä ei ole täytetty");
                    return;
                }
            }
            int asiakasid = int.Parse(tbAsiakasid.Text);
            string insertQuery = "INSERT INTO asiakas(asiakas_id, postinro, etunimi, sukunimi, lahiosoite, email, puhelinnro) VALUES (@asiakasid, @postinro, @etunimi, @sukunimi, @lahiosoite, @email, @puhelinnro)";
            string insertPostiQuery = "INSERT INTO posti(postinro, toimipaikka) VALUES (@postinro, @toimipaikka)";
            try
            {
                using (MySqlConnection myconnection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti"))
                {
                    using (MySqlCommand command = new MySqlCommand(insertQuery, myconnection))
                    {
                        myconnection.Open();
                        command.Parameters.AddWithValue("@asiakasid", asiakasid);
                        command.Parameters.AddWithValue("@postinro", tbasiakasPostinumero.Text);
                        command.Parameters.AddWithValue("@etunimi", tbAsiakasEtunimi.Text);
                        command.Parameters.AddWithValue("@sukunimi", tbAsiakasSukunimi.Text);
                        command.Parameters.AddWithValue("@lahiosoite", tbAsiakasLahiosoite.Text);
                        command.Parameters.AddWithValue("@email", tbAsiakasSahkoposti.Text);
                        command.Parameters.AddWithValue("@puhelinnro", tbAsiakasPuhelinnumero.Text);

                        // tarkistaa onko postinro jo olemassa  posti taulussa 
                        string checkPostiQuery = "SELECT COUNT(*) FROM posti WHERE postinro = @postinro";
                        using (MySqlCommand komento = new MySqlCommand(checkPostiQuery, myconnection))
                        {
                            komento.Parameters.AddWithValue("@postinro", tbasiakasPostinumero.Text);
                            int postiCount = Convert.ToInt32(komento.ExecuteScalar());
                            if (postiCount == 0)
                            {
                                // lisää postitauluun
                                using (MySqlCommand posti = new MySqlCommand(insertPostiQuery, myconnection))
                                {
                                    posti.Parameters.AddWithValue("@postinro", tbasiakasPostinumero.Text);
                                    posti.ExecuteNonQuery();
                                }
                            }
                        }
                        command.ExecuteNonQuery();
                        populatedgvAsiakkaat();
                    }
                }
                MessageBox.Show("Mahtavaa");
                btnAsiakasPaivita.Visible = true;
                btnAsiakasPoista.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ei voi lisätä päällekkäin. Tsekkaa postinumero ja id.");
            }
        }
        private void dgvAsiakashallinta_Click(object sender, EventArgs e)
        {
            tbAsiakasid.Text = dgvAsiakashallinta.CurrentRow.Cells[0].Value.ToString();
            tbasiakasPostinumero.Text = dgvAsiakashallinta.CurrentRow.Cells[1].Value.ToString();
            tbAsiakasEtunimi.Text = dgvAsiakashallinta.CurrentRow.Cells[2].Value.ToString();
            tbAsiakasSukunimi.Text = dgvAsiakashallinta.CurrentRow.Cells[3].Value.ToString();
            tbAsiakasLahiosoite.Text = dgvAsiakashallinta.CurrentRow.Cells[4].Value.ToString();
            tbAsiakasSahkoposti.Text = dgvAsiakashallinta.CurrentRow.Cells[5].Value.ToString();
            tbAsiakasPuhelinnumero.Text = dgvAsiakashallinta.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnAsiakasPoista_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(tbasiakasPostinumero.Text);
            string deletequery = "DELETE FROM asiakas WHERE asiakas_id = " + tbAsiakasid.Text;
            ExecuteMyQuery(deletequery);
            populatedgvAsiakkaat();

        }

        private void btnAsiakasHae_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti");

            string query = "SELECT * FROM asiakas WHERE asiakas_id = @asiakasid";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@asiakasid", tbAsiakasid.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                tbasiakasPostinumero.Text = row["postinro"].ToString();
                tbAsiakasEtunimi.Text = row["etunimi"].ToString();
                tbAsiakasSukunimi.Text = row["sukunimi"].ToString();
                tbAsiakasLahiosoite.Text = row["lahiosoite"].ToString();
                tbAsiakasSahkoposti.Text = row["email"].ToString();
                tbAsiakasPuhelinnumero.Text = row["puhelinnro"].ToString();
            }
            btnAsiakasPaivita.Visible = true;
            btnAsiakasPoista.Visible = true;
        }

        private void tbcAsiakasHallinta_Click(object sender, EventArgs e)
        {
            populatedgvAsiakkaat();
        }

        private void btnAsiakasPaivita_Click(object sender, EventArgs e)
        {
            string kysely = "UPDATE asiakas SET postinro='" + tbasiakasPostinumero.Text + "', etunimi='" + tbAsiakasEtunimi.Text +
                "', sukunimi='" + tbAsiakasSukunimi.Text + "', lahiosoite='" + tbAsiakasLahiosoite.Text + "', email='" + tbAsiakasSahkoposti.Text +
                "', puhelinnro=" + tbAsiakasPuhelinnumero.Text + " WHERE asiakas_id = " + tbAsiakasid.Text;
            ExecuteMyQuery(kysely);
            populatedgvAsiakkaat();
        }

        private void btnToimintaLisaaAlue_Click_1(object sender, EventArgs e)
        {
            foreach (TextBox tb in pnlToiminta.Controls.OfType<TextBox>())
            {
                if (tb.Text == "")
                {
                    tb.Focus();
                    MessageBox.Show("Kaikkia kenttiä ei ole täytetty oikein.");
                    return;
                }
            }

            int alueid = int.Parse(tbToimintaAlue.Text);
            string postinro = tbToimintaPostinro.Text.ToString();
            string toimipaikka = tbToimintaToimip.Text.ToString();
            string MokintiedotInsertQuery = "INSERT INTO mokki(alue_id, postinro, toimipaikka) VALUES (@alueid, @postinro, @toimipaikka)";
            using (MySqlConnection myconnection = new MySqlConnection("datasource=localhost;port=3307;database=vn;username=root;password=Ruutti"))
            {
                using (MySqlCommand command = new MySqlCommand(MokintiedotInsertQuery, myconnection))
                {

                    command.Parameters.AddWithValue("@alueid", alueid);
                    command.Parameters.AddWithValue("@postinro", postinro);
                    command.Parameters.AddWithValue("@toimipaikka", toimipaikka);

                    myconnection.Open();
                    command.ExecuteNonQuery();
                    myconnection.Close();
                }
            }
            UpdatedgMokkiLista();
        }

        private void tbpgAsiakashallinta_Click(object sender, EventArgs e)
        {
            populatedgvAsiakkaat();
        }
        */
        private void btnToiminta_Click_1(object sender, EventArgs e)
        {

            FormToiminta formtoiminta = new FormToiminta();
            this.Hide();

            formtoiminta.ShowDialog();
            this.Close();

        }
        private void btnAsiakas_Click_1(object sender, EventArgs e)
        {
            FormAsikashallinta formasiakashallinta = new FormAsikashallinta();
            this.Hide();

            formasiakashallinta.ShowDialog();
            this.Close();
        }

        private void btnLasku_Click_1(object sender, EventArgs e)
        {
            FormLaskutus formlaskutus = new FormLaskutus();
            this.Hide();

            formlaskutus.ShowDialog();
            this.Close();
        }

        private void btnMokkivaraus_Click(object sender, EventArgs e)
        {
            Form formmokit = new FormMokitJaMokkivaraukset();
            this.Hide();

            formmokit.ShowDialog();
            this.Close();
        }

        private void btnPalvelu_Click(object sender, EventArgs e)
        {
            FormPalveluhallinta formpalvelu = new FormPalveluhallinta();
            this.Hide();

            formpalvelu.ShowDialog();
            this.Close();
        }
    }
}