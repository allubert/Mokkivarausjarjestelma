namespace Mokkivarausjarjestelma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            tbcAsiakasHallinta = new TabControl();
            tbpgAloitussivu = new TabPage();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblTittle = new Label();
            btnLasku = new Button();
            btnPalvelu = new Button();
            btnAsiakas = new Button();
            btnToiminta = new Button();
            btnMokkivaraus = new Button();
            tbpgAsiakashallinta = new TabPage();
            btnAsiakasPoista = new Button();
            btnAsiakasPaivita = new Button();
            btnAsiakasLisaa = new Button();
            btnAsiakasHae = new Button();
            tbAsiakasSukunimi = new TextBox();
            tbAsiakasLahiosoite = new TextBox();
            tbAsiakasEtunimi = new TextBox();
            tbAsiakasSahkoposti = new TextBox();
            tbAsiakasPuhelinnumero = new TextBox();
            tbasiakasPostinumero = new TextBox();
            tbAsiakasid = new TextBox();
            lblPuhelinnumero = new Label();
            lblSahkoposti = new Label();
            lblLahiosoite = new Label();
            lblSukunimi = new Label();
            lblEtunimi = new Label();
            lblPostinumero = new Label();
            lblAsiakas = new Label();
            dgvAsiakashallinta = new DataGridView();
            tbpgPalveluhallinta = new TabPage();
            rtbPalvelukuvaus = new RichTextBox();
            tbPalvelualv = new TextBox();
            tbPalveluhinta = new TextBox();
            tbPalvelutyyppi = new TextBox();
            tbPalvelunimi = new TextBox();
            tbPalveluID = new TextBox();
            btnPalveluLisaa = new Button();
            btnPalveluPaivita = new Button();
            btnPalveluPoista = new Button();
            btnPalveluHae = new Button();
            lblHinta = new Label();
            lblAlv = new Label();
            lblKuvaus = new Label();
            lblTyyppi = new Label();
            label2 = new Label();
            lblPalveluID = new Label();
            dgvPalvelut = new DataGridView();
            tbpgMokkivaraushallinta = new TabPage();
            btnLisaaMokinTiedot = new Button();
            btnMuokkaaValitunMokinTietoja = new Button();
            btnMokkiPoista = new Button();
            btnPaivitaMokkiLista = new Button();
            btnVaraaValittuMokki = new Button();
            btnMokkiHae = new Button();
            label5 = new Label();
            tbValittuMokkiHintaVrk = new TextBox();
            rtbValittuMokkiVarustelu = new RichTextBox();
            rtbValittuMokkiKuvaus = new RichTextBox();
            tbValittuMokkiHloMaara = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tbValittuMokkiNimi = new TextBox();
            tbValittuMokkiOsoite = new TextBox();
            tbValittuMokkiPostiNro = new TextBox();
            tbValittuMokkiAlueID = new TextBox();
            tbValittuMokkiMokkiID = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblMokkiID = new Label();
            dgMokkiLista = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            lblMokkiListaOhje = new Label();
            tbpgToimintaaluehallinta = new TabPage();
            btnToimintaRaportointi = new Button();
            pnlToiminta = new Panel();
            lblToimintaOtsikko = new Label();
            lblToimintaAlue = new Label();
            tbToimintaAlue = new TextBox();
            btnToimintaKohteet = new Button();
            dgvHallinta = new DataGridView();
            btnToimintaPoistaAlue = new Button();
            tbToimintaNimi = new TextBox();
            btnToimintaLisaaAlue = new Button();
            lblToimintaKuvaus = new Label();
            tbToimintaVarustelu = new TextBox();
            lblToimintaOsoite = new Label();
            lblToimintaMokinnimi = new Label();
            tbToimintaHenkilo = new TextBox();
            lblToimintaPostinro = new Label();
            tbToimintaPostinro = new TextBox();
            tbToimintaKuvaus = new TextBox();
            lblToimintaHenkilo = new Label();
            btnToimintaPoista = new Button();
            tbToimintaOsoite = new TextBox();
            lblToimintaVarustelu = new Label();
            btnToimintaLisaa = new Button();
            tbpgLaskujenhallinta = new TabPage();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            tbcAsiakasHallinta.SuspendLayout();
            tbpgAloitussivu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tbpgAsiakashallinta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsiakashallinta).BeginInit();
            tbpgPalveluhallinta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPalvelut).BeginInit();
            tbpgMokkivaraushallinta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMokkiLista).BeginInit();
            panel2.SuspendLayout();
            tbpgToimintaaluehallinta.SuspendLayout();
            pnlToiminta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHallinta).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1097, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // tbcAsiakasHallinta
            // 
            tbcAsiakasHallinta.Controls.Add(tbpgAloitussivu);
            tbcAsiakasHallinta.Controls.Add(tbpgAsiakashallinta);
            tbcAsiakasHallinta.Controls.Add(tbpgPalveluhallinta);
            tbcAsiakasHallinta.Controls.Add(tbpgMokkivaraushallinta);
            tbcAsiakasHallinta.Controls.Add(tbpgToimintaaluehallinta);
            tbcAsiakasHallinta.Controls.Add(tbpgLaskujenhallinta);
            tbcAsiakasHallinta.Location = new Point(0, 0);
            tbcAsiakasHallinta.Margin = new Padding(3, 4, 3, 4);
            tbcAsiakasHallinta.Name = "tbcAsiakasHallinta";
            tbcAsiakasHallinta.SelectedIndex = 0;
            tbcAsiakasHallinta.Size = new Size(1097, 1028);
            tbcAsiakasHallinta.TabIndex = 0;
            tbcAsiakasHallinta.Selected += tbcHallinta_Selected;
            tbcAsiakasHallinta.Click += tbcAsiakasHallinta_Click;
            // 
            // tbpgAloitussivu
            // 
            tbpgAloitussivu.Controls.Add(pictureBox1);
            tbpgAloitussivu.Controls.Add(panel1);
            tbpgAloitussivu.Location = new Point(4, 29);
            tbpgAloitussivu.Margin = new Padding(3, 4, 3, 4);
            tbpgAloitussivu.Name = "tbpgAloitussivu";
            tbpgAloitussivu.Padding = new Padding(2, 3, 2, 3);
            tbpgAloitussivu.Size = new Size(1089, 995);
            tbpgAloitussivu.TabIndex = 0;
            tbpgAloitussivu.Text = "Aloitussivu";
            tbpgAloitussivu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._6368_log_cabin_black_and_white_free_download;
            pictureBox1.Location = new Point(9, 7);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 349);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTittle);
            panel1.Controls.Add(btnLasku);
            panel1.Controls.Add(btnPalvelu);
            panel1.Controls.Add(btnAsiakas);
            panel1.Controls.Add(btnToiminta);
            panel1.Controls.Add(btnMokkivaraus);
            panel1.Location = new Point(593, 7);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 843);
            panel1.TabIndex = 11;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTittle.Location = new Point(7, 5);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(514, 108);
            lblTittle.TabIndex = 5;
            lblTittle.Text = "Mökkivarausjärjestelmä\r\n    Village Newbies Oy\r\n";
            // 
            // btnLasku
            // 
            btnLasku.Location = new Point(101, 636);
            btnLasku.Margin = new Padding(3, 4, 3, 4);
            btnLasku.Name = "btnLasku";
            btnLasku.Size = new Size(297, 100);
            btnLasku.TabIndex = 10;
            btnLasku.Text = "Laskujen hallinta";
            btnLasku.UseVisualStyleBackColor = true;
            btnLasku.Click += btnLasku_Click;
            // 
            // btnPalvelu
            // 
            btnPalvelu.Location = new Point(101, 264);
            btnPalvelu.Margin = new Padding(3, 4, 3, 4);
            btnPalvelu.Name = "btnPalvelu";
            btnPalvelu.Size = new Size(297, 100);
            btnPalvelu.TabIndex = 1;
            btnPalvelu.Text = "Palveluiden hallinta";
            btnPalvelu.UseVisualStyleBackColor = true;
            btnPalvelu.Click += btnPalvelu_Click;
            // 
            // btnAsiakas
            // 
            btnAsiakas.Location = new Point(101, 513);
            btnAsiakas.Margin = new Padding(3, 4, 3, 4);
            btnAsiakas.Name = "btnAsiakas";
            btnAsiakas.Size = new Size(297, 100);
            btnAsiakas.TabIndex = 9;
            btnAsiakas.Text = "Asiakashallinta";
            btnAsiakas.UseVisualStyleBackColor = true;
            btnAsiakas.Click += btnAsiakas_Click;
            // 
            // btnToiminta
            // 
            btnToiminta.Location = new Point(101, 141);
            btnToiminta.Margin = new Padding(3, 4, 3, 4);
            btnToiminta.Name = "btnToiminta";
            btnToiminta.Size = new Size(297, 100);
            btnToiminta.TabIndex = 0;
            btnToiminta.Text = "Toiminta-alueiden hallinta";
            btnToiminta.UseVisualStyleBackColor = true;
            btnToiminta.Click += btnToiminta_Click;
            // 
            // btnMokkivaraus
            // 
            btnMokkivaraus.Location = new Point(101, 387);
            btnMokkivaraus.Margin = new Padding(3, 4, 3, 4);
            btnMokkivaraus.Name = "btnMokkivaraus";
            btnMokkivaraus.Size = new Size(297, 100);
            btnMokkivaraus.TabIndex = 8;
            btnMokkivaraus.Text = "Mökkivarausten hallinta";
            btnMokkivaraus.UseVisualStyleBackColor = true;
            btnMokkivaraus.Click += btnMokkivaraus_Click;
            // 
            // tbpgAsiakashallinta
            // 
            tbpgAsiakashallinta.Controls.Add(btnAsiakasPoista);
            tbpgAsiakashallinta.Controls.Add(btnAsiakasPaivita);
            tbpgAsiakashallinta.Controls.Add(btnAsiakasLisaa);
            tbpgAsiakashallinta.Controls.Add(btnAsiakasHae);
            tbpgAsiakashallinta.Controls.Add(tbAsiakasSukunimi);
            tbpgAsiakashallinta.Controls.Add(tbAsiakasLahiosoite);
            tbpgAsiakashallinta.Controls.Add(tbAsiakasEtunimi);
            tbpgAsiakashallinta.Controls.Add(tbAsiakasSahkoposti);
            tbpgAsiakashallinta.Controls.Add(tbAsiakasPuhelinnumero);
            tbpgAsiakashallinta.Controls.Add(tbasiakasPostinumero);
            tbpgAsiakashallinta.Controls.Add(tbAsiakasid);
            tbpgAsiakashallinta.Controls.Add(lblPuhelinnumero);
            tbpgAsiakashallinta.Controls.Add(lblSahkoposti);
            tbpgAsiakashallinta.Controls.Add(lblLahiosoite);
            tbpgAsiakashallinta.Controls.Add(lblSukunimi);
            tbpgAsiakashallinta.Controls.Add(lblEtunimi);
            tbpgAsiakashallinta.Controls.Add(lblPostinumero);
            tbpgAsiakashallinta.Controls.Add(lblAsiakas);
            tbpgAsiakashallinta.Controls.Add(dgvAsiakashallinta);
            tbpgAsiakashallinta.Location = new Point(4, 29);
            tbpgAsiakashallinta.Margin = new Padding(3, 4, 3, 4);
            tbpgAsiakashallinta.Name = "tbpgAsiakashallinta";
            tbpgAsiakashallinta.Padding = new Padding(2, 3, 2, 3);
            tbpgAsiakashallinta.Size = new Size(1089, 995);
            tbpgAsiakashallinta.TabIndex = 1;
            tbpgAsiakashallinta.Text = "Asiakashallinta";
            tbpgAsiakashallinta.UseVisualStyleBackColor = true;
            // 
            // btnAsiakasPoista
            // 
            btnAsiakasPoista.Location = new Point(213, 520);
            btnAsiakasPoista.Margin = new Padding(3, 4, 3, 4);
            btnAsiakasPoista.Name = "btnAsiakasPoista";
            btnAsiakasPoista.Size = new Size(72, 31);
            btnAsiakasPoista.TabIndex = 18;
            btnAsiakasPoista.Text = "Poista";
            btnAsiakasPoista.UseVisualStyleBackColor = true;
            btnAsiakasPoista.Click += btnAsiakasPoista_Click;
            // 
            // btnAsiakasPaivita
            // 
            btnAsiakasPaivita.Location = new Point(127, 520);
            btnAsiakasPaivita.Margin = new Padding(3, 4, 3, 4);
            btnAsiakasPaivita.Name = "btnAsiakasPaivita";
            btnAsiakasPaivita.Size = new Size(72, 31);
            btnAsiakasPaivita.TabIndex = 17;
            btnAsiakasPaivita.Text = "Päivitä";
            btnAsiakasPaivita.UseVisualStyleBackColor = true;
            btnAsiakasPaivita.Click += btnAsiakasPaivita_Click;
            // 
            // btnAsiakasLisaa
            // 
            btnAsiakasLisaa.Location = new Point(37, 520);
            btnAsiakasLisaa.Margin = new Padding(3, 4, 3, 4);
            btnAsiakasLisaa.Name = "btnAsiakasLisaa";
            btnAsiakasLisaa.Size = new Size(72, 31);
            btnAsiakasLisaa.TabIndex = 16;
            btnAsiakasLisaa.Text = "Lisää";
            btnAsiakasLisaa.UseVisualStyleBackColor = true;
            btnAsiakasLisaa.Click += btnAsiakasLisaa_Click;
            // 
            // btnAsiakasHae
            // 
            btnAsiakasHae.Location = new Point(279, 59);
            btnAsiakasHae.Margin = new Padding(3, 4, 3, 4);
            btnAsiakasHae.Name = "btnAsiakasHae";
            btnAsiakasHae.Size = new Size(72, 31);
            btnAsiakasHae.TabIndex = 15;
            btnAsiakasHae.Text = "Hae";
            btnAsiakasHae.UseVisualStyleBackColor = true;
            btnAsiakasHae.Click += btnAsiakasHae_Click;
            // 
            // tbAsiakasSukunimi
            // 
            tbAsiakasSukunimi.Location = new Point(114, 244);
            tbAsiakasSukunimi.Name = "tbAsiakasSukunimi";
            tbAsiakasSukunimi.Size = new Size(157, 27);
            tbAsiakasSukunimi.TabIndex = 14;
            // 
            // tbAsiakasLahiosoite
            // 
            tbAsiakasLahiosoite.Location = new Point(114, 305);
            tbAsiakasLahiosoite.Name = "tbAsiakasLahiosoite";
            tbAsiakasLahiosoite.Size = new Size(157, 27);
            tbAsiakasLahiosoite.TabIndex = 13;
            // 
            // tbAsiakasEtunimi
            // 
            tbAsiakasEtunimi.Location = new Point(114, 175);
            tbAsiakasEtunimi.Name = "tbAsiakasEtunimi";
            tbAsiakasEtunimi.Size = new Size(157, 27);
            tbAsiakasEtunimi.TabIndex = 12;
            // 
            // tbAsiakasSahkoposti
            // 
            tbAsiakasSahkoposti.Location = new Point(114, 365);
            tbAsiakasSahkoposti.Name = "tbAsiakasSahkoposti";
            tbAsiakasSahkoposti.Size = new Size(157, 27);
            tbAsiakasSahkoposti.TabIndex = 11;
            // 
            // tbAsiakasPuhelinnumero
            // 
            tbAsiakasPuhelinnumero.Location = new Point(127, 437);
            tbAsiakasPuhelinnumero.Name = "tbAsiakasPuhelinnumero";
            tbAsiakasPuhelinnumero.Size = new Size(157, 27);
            tbAsiakasPuhelinnumero.TabIndex = 10;
            // 
            // tbasiakasPostinumero
            // 
            tbasiakasPostinumero.Location = new Point(114, 115);
            tbasiakasPostinumero.Name = "tbasiakasPostinumero";
            tbasiakasPostinumero.Size = new Size(157, 27);
            tbasiakasPostinumero.TabIndex = 9;
            // 
            // tbAsiakasid
            // 
            tbAsiakasid.Location = new Point(114, 59);
            tbAsiakasid.Name = "tbAsiakasid";
            tbAsiakasid.Size = new Size(157, 27);
            tbAsiakasid.TabIndex = 8;
            tbAsiakasid.Text = "0";
            // 
            // lblPuhelinnumero
            // 
            lblPuhelinnumero.Location = new Point(8, 437);
            lblPuhelinnumero.Name = "lblPuhelinnumero";
            lblPuhelinnumero.Size = new Size(113, 60);
            lblPuhelinnumero.TabIndex = 7;
            lblPuhelinnumero.Text = "Puhelinnumero";
            // 
            // lblSahkoposti
            // 
            lblSahkoposti.Location = new Point(8, 365);
            lblSahkoposti.Name = "lblSahkoposti";
            lblSahkoposti.Size = new Size(101, 60);
            lblSahkoposti.TabIndex = 6;
            lblSahkoposti.Text = "Sähköposti";
            // 
            // lblLahiosoite
            // 
            lblLahiosoite.Location = new Point(8, 305);
            lblLahiosoite.Name = "lblLahiosoite";
            lblLahiosoite.Size = new Size(101, 60);
            lblLahiosoite.TabIndex = 5;
            lblLahiosoite.Text = "Lähiosoite";
            // 
            // lblSukunimi
            // 
            lblSukunimi.Location = new Point(8, 247);
            lblSukunimi.Name = "lblSukunimi";
            lblSukunimi.Size = new Size(101, 60);
            lblSukunimi.TabIndex = 4;
            lblSukunimi.Text = "Sukunimi";
            // 
            // lblEtunimi
            // 
            lblEtunimi.Location = new Point(8, 179);
            lblEtunimi.Name = "lblEtunimi";
            lblEtunimi.Size = new Size(101, 60);
            lblEtunimi.TabIndex = 3;
            lblEtunimi.Text = "Etunimi";
            // 
            // lblPostinumero
            // 
            lblPostinumero.Location = new Point(8, 117);
            lblPostinumero.Name = "lblPostinumero";
            lblPostinumero.Size = new Size(101, 60);
            lblPostinumero.TabIndex = 2;
            lblPostinumero.Text = "Postinumero";
            // 
            // lblAsiakas
            // 
            lblAsiakas.Location = new Point(8, 59);
            lblAsiakas.Name = "lblAsiakas";
            lblAsiakas.Size = new Size(101, 60);
            lblAsiakas.TabIndex = 1;
            lblAsiakas.Text = "AsiakasID";
            // 
            // dgvAsiakashallinta
            // 
            dgvAsiakashallinta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsiakashallinta.Location = new Point(358, 0);
            dgvAsiakashallinta.Name = "dgvAsiakashallinta";
            dgvAsiakashallinta.RowHeadersWidth = 51;
            dgvAsiakashallinta.RowTemplate.Height = 29;
            dgvAsiakashallinta.Size = new Size(731, 516);
            dgvAsiakashallinta.TabIndex = 0;
            dgvAsiakashallinta.Click += dgvAsiakashallinta_Click;
            // 
            // tbpgPalveluhallinta
            // 
            tbpgPalveluhallinta.Controls.Add(rtbPalvelukuvaus);
            tbpgPalveluhallinta.Controls.Add(tbPalvelualv);
            tbpgPalveluhallinta.Controls.Add(tbPalveluhinta);
            tbpgPalveluhallinta.Controls.Add(tbPalvelutyyppi);
            tbpgPalveluhallinta.Controls.Add(tbPalvelunimi);
            tbpgPalveluhallinta.Controls.Add(tbPalveluID);
            tbpgPalveluhallinta.Controls.Add(btnPalveluLisaa);
            tbpgPalveluhallinta.Controls.Add(btnPalveluPaivita);
            tbpgPalveluhallinta.Controls.Add(btnPalveluPoista);
            tbpgPalveluhallinta.Controls.Add(btnPalveluHae);
            tbpgPalveluhallinta.Controls.Add(lblHinta);
            tbpgPalveluhallinta.Controls.Add(lblAlv);
            tbpgPalveluhallinta.Controls.Add(lblKuvaus);
            tbpgPalveluhallinta.Controls.Add(lblTyyppi);
            tbpgPalveluhallinta.Controls.Add(label2);
            tbpgPalveluhallinta.Controls.Add(lblPalveluID);
            tbpgPalveluhallinta.Controls.Add(dgvPalvelut);
            tbpgPalveluhallinta.Location = new Point(4, 29);
            tbpgPalveluhallinta.Margin = new Padding(3, 4, 3, 4);
            tbpgPalveluhallinta.Name = "tbpgPalveluhallinta";
            tbpgPalveluhallinta.Padding = new Padding(2, 3, 2, 3);
            tbpgPalveluhallinta.Size = new Size(1089, 995);
            tbpgPalveluhallinta.TabIndex = 2;
            tbpgPalveluhallinta.Text = "Palveluiden hallinta";
            tbpgPalveluhallinta.UseVisualStyleBackColor = true;
            tbpgPalveluhallinta.Click += tbpgPalveluhallinta_Click;
            // 
            // rtbPalvelukuvaus
            // 
            rtbPalvelukuvaus.Location = new Point(123, 236);
            rtbPalvelukuvaus.Margin = new Padding(3, 4, 3, 4);
            rtbPalvelukuvaus.Name = "rtbPalvelukuvaus";
            rtbPalvelukuvaus.Size = new Size(225, 85);
            rtbPalvelukuvaus.TabIndex = 16;
            rtbPalvelukuvaus.Text = "";
            // 
            // tbPalvelualv
            // 
            tbPalvelualv.Location = new Point(123, 389);
            tbPalvelualv.Margin = new Padding(3, 4, 3, 4);
            tbPalvelualv.Name = "tbPalvelualv";
            tbPalvelualv.Size = new Size(148, 27);
            tbPalvelualv.TabIndex = 15;
            // 
            // tbPalveluhinta
            // 
            tbPalveluhinta.Location = new Point(123, 331);
            tbPalveluhinta.Margin = new Padding(3, 4, 3, 4);
            tbPalveluhinta.Name = "tbPalveluhinta";
            tbPalveluhinta.Size = new Size(148, 27);
            tbPalveluhinta.TabIndex = 14;
            // 
            // tbPalvelutyyppi
            // 
            tbPalvelutyyppi.Location = new Point(123, 181);
            tbPalvelutyyppi.Margin = new Padding(3, 4, 3, 4);
            tbPalvelutyyppi.Name = "tbPalvelutyyppi";
            tbPalvelutyyppi.Size = new Size(148, 27);
            tbPalvelutyyppi.TabIndex = 13;
            // 
            // tbPalvelunimi
            // 
            tbPalvelunimi.Location = new Point(123, 127);
            tbPalvelunimi.Margin = new Padding(3, 4, 3, 4);
            tbPalvelunimi.Name = "tbPalvelunimi";
            tbPalvelunimi.Size = new Size(148, 27);
            tbPalvelunimi.TabIndex = 12;
            // 
            // tbPalveluID
            // 
            tbPalveluID.Location = new Point(123, 52);
            tbPalveluID.Margin = new Padding(3, 4, 3, 4);
            tbPalveluID.Name = "tbPalveluID";
            tbPalveluID.Size = new Size(148, 27);
            tbPalveluID.TabIndex = 11;
            // 
            // btnPalveluLisaa
            // 
            btnPalveluLisaa.Location = new Point(32, 480);
            btnPalveluLisaa.Margin = new Padding(3, 4, 3, 4);
            btnPalveluLisaa.Name = "btnPalveluLisaa";
            btnPalveluLisaa.Size = new Size(86, 31);
            btnPalveluLisaa.TabIndex = 10;
            btnPalveluLisaa.Text = "Syötä";
            btnPalveluLisaa.UseVisualStyleBackColor = true;
            btnPalveluLisaa.Click += btnPalveluLisaa_Click;
            // 
            // btnPalveluPaivita
            // 
            btnPalveluPaivita.Location = new Point(163, 480);
            btnPalveluPaivita.Margin = new Padding(3, 4, 3, 4);
            btnPalveluPaivita.Name = "btnPalveluPaivita";
            btnPalveluPaivita.Size = new Size(86, 31);
            btnPalveluPaivita.TabIndex = 9;
            btnPalveluPaivita.Text = "Päivitä";
            btnPalveluPaivita.UseVisualStyleBackColor = true;
            btnPalveluPaivita.Click += btnPalveluPaivita_Click;
            // 
            // btnPalveluPoista
            // 
            btnPalveluPoista.Location = new Point(290, 480);
            btnPalveluPoista.Margin = new Padding(3, 4, 3, 4);
            btnPalveluPoista.Name = "btnPalveluPoista";
            btnPalveluPoista.Size = new Size(86, 31);
            btnPalveluPoista.TabIndex = 8;
            btnPalveluPoista.Text = "Poista";
            btnPalveluPoista.UseVisualStyleBackColor = true;
            // 
            // btnPalveluHae
            // 
            btnPalveluHae.Location = new Point(323, 39);
            btnPalveluHae.Margin = new Padding(3, 4, 3, 4);
            btnPalveluHae.Name = "btnPalveluHae";
            btnPalveluHae.Size = new Size(53, 37);
            btnPalveluHae.TabIndex = 7;
            btnPalveluHae.Text = "Hae";
            btnPalveluHae.UseVisualStyleBackColor = true;
            // 
            // lblHinta
            // 
            lblHinta.AutoSize = true;
            lblHinta.Location = new Point(29, 335);
            lblHinta.Name = "lblHinta";
            lblHinta.Size = new Size(67, 20);
            lblHinta.TabIndex = 6;
            lblHinta.Text = "Hinta (€)";
            // 
            // lblAlv
            // 
            lblAlv.AutoSize = true;
            lblAlv.Location = new Point(32, 389);
            lblAlv.Name = "lblAlv";
            lblAlv.Size = new Size(30, 20);
            lblAlv.TabIndex = 5;
            lblAlv.Text = "Alv";
            // 
            // lblKuvaus
            // 
            lblKuvaus.AutoSize = true;
            lblKuvaus.Location = new Point(32, 236);
            lblKuvaus.Name = "lblKuvaus";
            lblKuvaus.Size = new Size(55, 20);
            lblKuvaus.TabIndex = 4;
            lblKuvaus.Text = "Kuvaus";
            // 
            // lblTyyppi
            // 
            lblTyyppi.AutoSize = true;
            lblTyyppi.Location = new Point(32, 181);
            lblTyyppi.Name = "lblTyyppi";
            lblTyyppi.Size = new Size(52, 20);
            lblTyyppi.TabIndex = 3;
            lblTyyppi.Text = "Tyyppi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 131);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Nimi";
            // 
            // lblPalveluID
            // 
            lblPalveluID.AutoSize = true;
            lblPalveluID.Location = new Point(32, 56);
            lblPalveluID.Name = "lblPalveluID";
            lblPalveluID.Size = new Size(70, 20);
            lblPalveluID.TabIndex = 1;
            lblPalveluID.Text = "PalveluID";
            // 
            // dgvPalvelut
            // 
            dgvPalvelut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPalvelut.Location = new Point(408, 7);
            dgvPalvelut.Margin = new Padding(3, 4, 3, 4);
            dgvPalvelut.Name = "dgvPalvelut";
            dgvPalvelut.RowHeadersWidth = 51;
            dgvPalvelut.RowTemplate.Height = 25;
            dgvPalvelut.Size = new Size(671, 515);
            dgvPalvelut.TabIndex = 0;
            dgvPalvelut.MouseClick += dgvPalvelut_MouseClick;
            // 
            // tbpgMokkivaraushallinta
            // 
            tbpgMokkivaraushallinta.Controls.Add(btnLisaaMokinTiedot);
            tbpgMokkivaraushallinta.Controls.Add(btnMuokkaaValitunMokinTietoja);
            tbpgMokkivaraushallinta.Controls.Add(btnMokkiPoista);
            tbpgMokkivaraushallinta.Controls.Add(btnPaivitaMokkiLista);
            tbpgMokkivaraushallinta.Controls.Add(btnVaraaValittuMokki);
            tbpgMokkivaraushallinta.Controls.Add(btnMokkiHae);
            tbpgMokkivaraushallinta.Controls.Add(label5);
            tbpgMokkivaraushallinta.Controls.Add(tbValittuMokkiHintaVrk);
            tbpgMokkivaraushallinta.Controls.Add(rtbValittuMokkiVarustelu);
            tbpgMokkivaraushallinta.Controls.Add(rtbValittuMokkiKuvaus);
            tbpgMokkivaraushallinta.Controls.Add(tbValittuMokkiHloMaara);
            tbpgMokkivaraushallinta.Controls.Add(label11);
            tbpgMokkivaraushallinta.Controls.Add(label12);
            tbpgMokkivaraushallinta.Controls.Add(label13);
            tbpgMokkivaraushallinta.Controls.Add(tbValittuMokkiNimi);
            tbpgMokkivaraushallinta.Controls.Add(tbValittuMokkiOsoite);
            tbpgMokkivaraushallinta.Controls.Add(tbValittuMokkiPostiNro);
            tbpgMokkivaraushallinta.Controls.Add(tbValittuMokkiAlueID);
            tbpgMokkivaraushallinta.Controls.Add(tbValittuMokkiMokkiID);
            tbpgMokkivaraushallinta.Controls.Add(label6);
            tbpgMokkivaraushallinta.Controls.Add(label7);
            tbpgMokkivaraushallinta.Controls.Add(label8);
            tbpgMokkivaraushallinta.Controls.Add(label9);
            tbpgMokkivaraushallinta.Controls.Add(label10);
            tbpgMokkivaraushallinta.Controls.Add(lblMokkiID);
            tbpgMokkivaraushallinta.Controls.Add(dgMokkiLista);
            tbpgMokkivaraushallinta.Controls.Add(panel2);
            tbpgMokkivaraushallinta.Location = new Point(4, 29);
            tbpgMokkivaraushallinta.Margin = new Padding(3, 4, 3, 4);
            tbpgMokkivaraushallinta.Name = "tbpgMokkivaraushallinta";
            tbpgMokkivaraushallinta.Padding = new Padding(2, 3, 2, 3);
            tbpgMokkivaraushallinta.Size = new Size(1089, 995);
            tbpgMokkivaraushallinta.TabIndex = 3;
            tbpgMokkivaraushallinta.Text = "Mökkivarausten hallinta";
            tbpgMokkivaraushallinta.UseVisualStyleBackColor = true;
            // 
            // btnLisaaMokinTiedot
            // 
            btnLisaaMokinTiedot.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLisaaMokinTiedot.Location = new Point(13, 581);
            btnLisaaMokinTiedot.Margin = new Padding(3, 4, 3, 4);
            btnLisaaMokinTiedot.Name = "btnLisaaMokinTiedot";
            btnLisaaMokinTiedot.Size = new Size(160, 40);
            btnLisaaMokinTiedot.TabIndex = 9;
            btnLisaaMokinTiedot.Text = "Lisää mökin tiedot";
            btnLisaaMokinTiedot.UseVisualStyleBackColor = true;
            btnLisaaMokinTiedot.Click += btnLisaaMokinTiedot_Click;
            // 
            // btnMuokkaaValitunMokinTietoja
            // 
            btnMuokkaaValitunMokinTietoja.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMuokkaaValitunMokinTietoja.Location = new Point(185, 581);
            btnMuokkaaValitunMokinTietoja.Margin = new Padding(3, 4, 3, 4);
            btnMuokkaaValitunMokinTietoja.Name = "btnMuokkaaValitunMokinTietoja";
            btnMuokkaaValitunMokinTietoja.Size = new Size(86, 40);
            btnMuokkaaValitunMokinTietoja.TabIndex = 14;
            btnMuokkaaValitunMokinTietoja.Text = "Muokkaa";
            btnMuokkaaValitunMokinTietoja.UseVisualStyleBackColor = true;
            // 
            // btnMokkiPoista
            // 
            btnMokkiPoista.Location = new Point(930, 607);
            btnMokkiPoista.Margin = new Padding(3, 4, 3, 4);
            btnMokkiPoista.Name = "btnMokkiPoista";
            btnMokkiPoista.Size = new Size(158, 31);
            btnMokkiPoista.TabIndex = 13;
            btnMokkiPoista.Text = "Poista mökki listalta";
            btnMokkiPoista.UseVisualStyleBackColor = true;
            // 
            // btnPaivitaMokkiLista
            // 
            btnPaivitaMokkiLista.Location = new Point(450, 607);
            btnPaivitaMokkiLista.Margin = new Padding(3, 4, 3, 4);
            btnPaivitaMokkiLista.Name = "btnPaivitaMokkiLista";
            btnPaivitaMokkiLista.Size = new Size(109, 31);
            btnPaivitaMokkiLista.TabIndex = 12;
            btnPaivitaMokkiLista.Text = "Päivitä Lista";
            btnPaivitaMokkiLista.UseVisualStyleBackColor = true;
            // 
            // btnVaraaValittuMokki
            // 
            btnVaraaValittuMokki.Location = new Point(185, 8);
            btnVaraaValittuMokki.Margin = new Padding(3, 4, 3, 4);
            btnVaraaValittuMokki.Name = "btnVaraaValittuMokki";
            btnVaraaValittuMokki.Size = new Size(86, 31);
            btnVaraaValittuMokki.TabIndex = 10;
            btnVaraaValittuMokki.Text = "Uusi Varaus";
            btnVaraaValittuMokki.UseVisualStyleBackColor = true;
            btnVaraaValittuMokki.Click += btnUusiVaraus_Click;
            // 
            // btnMokkiHae
            // 
            btnMokkiHae.Location = new Point(281, 607);
            btnMokkiHae.Margin = new Padding(3, 4, 3, 4);
            btnMokkiHae.Name = "btnMokkiHae";
            btnMokkiHae.Size = new Size(162, 31);
            btnMokkiHae.TabIndex = 11;
            btnMokkiHae.Text = "Tuo tiedot tekstikenttiin";
            btnMokkiHae.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 19);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 15;
            // 
            // tbValittuMokkiHintaVrk
            // 
            tbValittuMokkiHintaVrk.Location = new Point(102, 207);
            tbValittuMokkiHintaVrk.Name = "tbValittuMokkiHintaVrk";
            tbValittuMokkiHintaVrk.Size = new Size(169, 27);
            tbValittuMokkiHintaVrk.TabIndex = 5;
            // 
            // rtbValittuMokkiVarustelu
            // 
            rtbValittuMokkiVarustelu.Location = new Point(102, 416);
            rtbValittuMokkiVarustelu.Margin = new Padding(3, 4, 3, 4);
            rtbValittuMokkiVarustelu.Name = "rtbValittuMokkiVarustelu";
            rtbValittuMokkiVarustelu.Size = new Size(169, 156);
            rtbValittuMokkiVarustelu.TabIndex = 8;
            rtbValittuMokkiVarustelu.Text = "";
            // 
            // rtbValittuMokkiKuvaus
            // 
            rtbValittuMokkiKuvaus.Location = new Point(102, 236);
            rtbValittuMokkiKuvaus.Margin = new Padding(3, 4, 3, 4);
            rtbValittuMokkiKuvaus.Name = "rtbValittuMokkiKuvaus";
            rtbValittuMokkiKuvaus.Size = new Size(169, 148);
            rtbValittuMokkiKuvaus.TabIndex = 6;
            rtbValittuMokkiKuvaus.Text = "";
            // 
            // tbValittuMokkiHloMaara
            // 
            tbValittuMokkiHloMaara.Location = new Point(102, 385);
            tbValittuMokkiHloMaara.Name = "tbValittuMokkiHloMaara";
            tbValittuMokkiHloMaara.Size = new Size(169, 27);
            tbValittuMokkiHloMaara.TabIndex = 7;
            // 
            // label11
            // 
            label11.Location = new Point(6, 389);
            label11.Name = "label11";
            label11.Size = new Size(101, 27);
            label11.TabIndex = 32;
            label11.Text = "Henkilömäärä";
            // 
            // label12
            // 
            label12.Location = new Point(6, 236);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(101, 27);
            label12.TabIndex = 26;
            label12.Text = "Kuvaus";
            // 
            // label13
            // 
            label13.Location = new Point(6, 207);
            label13.Name = "label13";
            label13.Size = new Size(101, 33);
            label13.TabIndex = 21;
            label13.Text = "Hinta (/vrk)";
            // 
            // tbValittuMokkiNimi
            // 
            tbValittuMokkiNimi.Location = new Point(102, 145);
            tbValittuMokkiNimi.Name = "tbValittuMokkiNimi";
            tbValittuMokkiNimi.Size = new Size(169, 27);
            tbValittuMokkiNimi.TabIndex = 3;
            // 
            // tbValittuMokkiOsoite
            // 
            tbValittuMokkiOsoite.Location = new Point(102, 176);
            tbValittuMokkiOsoite.Name = "tbValittuMokkiOsoite";
            tbValittuMokkiOsoite.Size = new Size(169, 27);
            tbValittuMokkiOsoite.TabIndex = 4;
            // 
            // tbValittuMokkiPostiNro
            // 
            tbValittuMokkiPostiNro.Location = new Point(102, 115);
            tbValittuMokkiPostiNro.Name = "tbValittuMokkiPostiNro";
            tbValittuMokkiPostiNro.Size = new Size(169, 27);
            tbValittuMokkiPostiNro.TabIndex = 2;
            // 
            // tbValittuMokkiAlueID
            // 
            tbValittuMokkiAlueID.Location = new Point(102, 84);
            tbValittuMokkiAlueID.Name = "tbValittuMokkiAlueID";
            tbValittuMokkiAlueID.Size = new Size(169, 27);
            tbValittuMokkiAlueID.TabIndex = 1;
            // 
            // tbValittuMokkiMokkiID
            // 
            tbValittuMokkiMokkiID.Location = new Point(102, 51);
            tbValittuMokkiMokkiID.Name = "tbValittuMokkiMokkiID";
            tbValittuMokkiMokkiID.Size = new Size(169, 27);
            tbValittuMokkiMokkiID.TabIndex = 0;
            // 
            // label6
            // 
            label6.Location = new Point(6, 416);
            label6.Name = "label6";
            label6.Size = new Size(101, 60);
            label6.TabIndex = 21;
            label6.Text = "Varustelu";
            // 
            // label7
            // 
            label7.Location = new Point(6, 176);
            label7.Name = "label7";
            label7.Size = new Size(101, 31);
            label7.TabIndex = 20;
            label7.Text = "Lähiosoite";
            // 
            // label8
            // 
            label8.Location = new Point(6, 145);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(101, 28);
            label8.TabIndex = 19;
            label8.Text = "Mökin nimi";
            // 
            // label9
            // 
            label9.Location = new Point(6, 115);
            label9.Name = "label9";
            label9.Size = new Size(101, 31);
            label9.TabIndex = 18;
            label9.Text = "Postinro";
            // 
            // label10
            // 
            label10.Location = new Point(6, 87);
            label10.Name = "label10";
            label10.Size = new Size(101, 28);
            label10.TabIndex = 17;
            label10.Text = "Alue_ID";
            // 
            // lblMokkiID
            // 
            lblMokkiID.Location = new Point(6, 59);
            lblMokkiID.Name = "lblMokkiID";
            lblMokkiID.Size = new Size(101, 32);
            lblMokkiID.TabIndex = 16;
            lblMokkiID.Text = "Mokki_ID";
            // 
            // dgMokkiLista
            // 
            dgMokkiLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMokkiLista.Location = new Point(281, 0);
            dgMokkiLista.Name = "dgMokkiLista";
            dgMokkiLista.RowHeadersWidth = 51;
            dgMokkiLista.RowTemplate.Height = 29;
            dgMokkiLista.Size = new Size(807, 600);
            dgMokkiLista.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblMokkiListaOhje);
            panel2.Location = new Point(0, 645);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1088, 156);
            panel2.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 45;
            label1.Text = "HUOMIO!";
            // 
            // lblMokkiListaOhje
            // 
            lblMokkiListaOhje.AutoSize = true;
            lblMokkiListaOhje.Location = new Point(3, 33);
            lblMokkiListaOhje.Name = "lblMokkiListaOhje";
            lblMokkiListaOhje.Size = new Size(794, 40);
            lblMokkiListaOhje.TabIndex = 43;
            lblMokkiListaOhje.Text = resources.GetString("lblMokkiListaOhje.Text");
            // 
            // tbpgToimintaaluehallinta
            // 
            tbpgToimintaaluehallinta.Controls.Add(btnToimintaRaportointi);
            tbpgToimintaaluehallinta.Controls.Add(pnlToiminta);
            tbpgToimintaaluehallinta.Controls.Add(btnToimintaKohteet);
            tbpgToimintaaluehallinta.Controls.Add(dgvHallinta);
            tbpgToimintaaluehallinta.Controls.Add(btnToimintaPoistaAlue);
            tbpgToimintaaluehallinta.Controls.Add(tbToimintaNimi);
            tbpgToimintaaluehallinta.Controls.Add(btnToimintaLisaaAlue);
            tbpgToimintaaluehallinta.Controls.Add(lblToimintaKuvaus);
            tbpgToimintaaluehallinta.Controls.Add(tbToimintaVarustelu);
            tbpgToimintaaluehallinta.Controls.Add(lblToimintaOsoite);
            tbpgToimintaaluehallinta.Controls.Add(lblToimintaMokinnimi);
            tbpgToimintaaluehallinta.Controls.Add(tbToimintaHenkilo);
            tbpgToimintaaluehallinta.Controls.Add(lblToimintaPostinro);
            tbpgToimintaaluehallinta.Controls.Add(tbToimintaPostinro);
            tbpgToimintaaluehallinta.Controls.Add(tbToimintaKuvaus);
            tbpgToimintaaluehallinta.Controls.Add(lblToimintaHenkilo);
            tbpgToimintaaluehallinta.Controls.Add(btnToimintaPoista);
            tbpgToimintaaluehallinta.Controls.Add(tbToimintaOsoite);
            tbpgToimintaaluehallinta.Controls.Add(lblToimintaVarustelu);
            tbpgToimintaaluehallinta.Controls.Add(btnToimintaLisaa);
            tbpgToimintaaluehallinta.Location = new Point(4, 29);
            tbpgToimintaaluehallinta.Margin = new Padding(3, 4, 3, 4);
            tbpgToimintaaluehallinta.Name = "tbpgToimintaaluehallinta";
            tbpgToimintaaluehallinta.Padding = new Padding(2, 3, 2, 3);
            tbpgToimintaaluehallinta.Size = new Size(1089, 995);
            tbpgToimintaaluehallinta.TabIndex = 4;
            tbpgToimintaaluehallinta.Text = "Toiminta-alueiden hallinta";
            tbpgToimintaaluehallinta.UseVisualStyleBackColor = true;
            // 
            // btnToimintaRaportointi
            // 
            btnToimintaRaportointi.Location = new Point(127, 676);
            btnToimintaRaportointi.Margin = new Padding(3, 4, 3, 4);
            btnToimintaRaportointi.Name = "btnToimintaRaportointi";
            btnToimintaRaportointi.Size = new Size(113, 56);
            btnToimintaRaportointi.TabIndex = 21;
            btnToimintaRaportointi.Text = "Näytä raportointi";
            btnToimintaRaportointi.UseVisualStyleBackColor = true;
            // 
            // pnlToiminta
            // 
            pnlToiminta.Controls.Add(lblToimintaOtsikko);
            pnlToiminta.Controls.Add(lblToimintaAlue);
            pnlToiminta.Controls.Add(tbToimintaAlue);
            pnlToiminta.Location = new Point(6, 60);
            pnlToiminta.Margin = new Padding(3, 4, 3, 4);
            pnlToiminta.Name = "pnlToiminta";
            pnlToiminta.Size = new Size(239, 133);
            pnlToiminta.TabIndex = 15;
            // 
            // lblToimintaOtsikko
            // 
            lblToimintaOtsikko.AutoSize = true;
            lblToimintaOtsikko.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblToimintaOtsikko.Location = new Point(3, 0);
            lblToimintaOtsikko.Name = "lblToimintaOtsikko";
            lblToimintaOtsikko.Size = new Size(254, 46);
            lblToimintaOtsikko.TabIndex = 18;
            lblToimintaOtsikko.Text = "Toiminta-alueet";
            // 
            // lblToimintaAlue
            // 
            lblToimintaAlue.AutoSize = true;
            lblToimintaAlue.Location = new Point(3, 59);
            lblToimintaAlue.Name = "lblToimintaAlue";
            lblToimintaAlue.Size = new Size(150, 20);
            lblToimintaAlue.TabIndex = 17;
            lblToimintaAlue.Text = "Toiminta-alueen nimi";
            // 
            // tbToimintaAlue
            // 
            tbToimintaAlue.Location = new Point(7, 83);
            tbToimintaAlue.Margin = new Padding(3, 4, 3, 4);
            tbToimintaAlue.Name = "tbToimintaAlue";
            tbToimintaAlue.Size = new Size(230, 27);
            tbToimintaAlue.TabIndex = 16;
            // 
            // btnToimintaKohteet
            // 
            btnToimintaKohteet.Location = new Point(13, 676);
            btnToimintaKohteet.Margin = new Padding(3, 4, 3, 4);
            btnToimintaKohteet.Name = "btnToimintaKohteet";
            btnToimintaKohteet.Size = new Size(107, 56);
            btnToimintaKohteet.TabIndex = 20;
            btnToimintaKohteet.Text = "Näytä kohteet";
            btnToimintaKohteet.UseVisualStyleBackColor = true;
            // 
            // dgvHallinta
            // 
            dgvHallinta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHallinta.Location = new Point(283, 7);
            dgvHallinta.Margin = new Padding(3, 4, 3, 4);
            dgvHallinta.Name = "dgvHallinta";
            dgvHallinta.RowHeadersWidth = 51;
            dgvHallinta.RowTemplate.Height = 25;
            dgvHallinta.Size = new Size(795, 600);
            dgvHallinta.TabIndex = 0;
            // 
            // btnToimintaPoistaAlue
            // 
            btnToimintaPoistaAlue.Location = new Point(127, 612);
            btnToimintaPoistaAlue.Margin = new Padding(3, 4, 3, 4);
            btnToimintaPoistaAlue.Name = "btnToimintaPoistaAlue";
            btnToimintaPoistaAlue.Size = new Size(113, 56);
            btnToimintaPoistaAlue.TabIndex = 19;
            btnToimintaPoistaAlue.Text = "Poista toiminta-alue";
            btnToimintaPoistaAlue.UseVisualStyleBackColor = true;
            // 
            // tbToimintaNimi
            // 
            tbToimintaNimi.Location = new Point(13, 223);
            tbToimintaNimi.Margin = new Padding(3, 4, 3, 4);
            tbToimintaNimi.Name = "tbToimintaNimi";
            tbToimintaNimi.Size = new Size(227, 27);
            tbToimintaNimi.TabIndex = 1;
            // 
            // btnToimintaLisaaAlue
            // 
            btnToimintaLisaaAlue.Location = new Point(13, 612);
            btnToimintaLisaaAlue.Margin = new Padding(3, 4, 3, 4);
            btnToimintaLisaaAlue.Name = "btnToimintaLisaaAlue";
            btnToimintaLisaaAlue.Size = new Size(107, 56);
            btnToimintaLisaaAlue.TabIndex = 17;
            btnToimintaLisaaAlue.Text = "Lisää toiminta-alue";
            btnToimintaLisaaAlue.UseVisualStyleBackColor = true;
            btnToimintaLisaaAlue.Click += btnToimintaLisaaAlue_Click;
            // 
            // lblToimintaKuvaus
            // 
            lblToimintaKuvaus.AutoSize = true;
            lblToimintaKuvaus.Location = new Point(13, 257);
            lblToimintaKuvaus.Name = "lblToimintaKuvaus";
            lblToimintaKuvaus.Size = new Size(55, 20);
            lblToimintaKuvaus.TabIndex = 8;
            lblToimintaKuvaus.Text = "Kuvaus";
            // 
            // tbToimintaVarustelu
            // 
            tbToimintaVarustelu.Location = new Point(13, 509);
            tbToimintaVarustelu.Margin = new Padding(3, 4, 3, 4);
            tbToimintaVarustelu.Name = "tbToimintaVarustelu";
            tbToimintaVarustelu.Size = new Size(227, 27);
            tbToimintaVarustelu.TabIndex = 6;
            // 
            // lblToimintaOsoite
            // 
            lblToimintaOsoite.AutoSize = true;
            lblToimintaOsoite.Location = new Point(9, 309);
            lblToimintaOsoite.Name = "lblToimintaOsoite";
            lblToimintaOsoite.Size = new Size(80, 20);
            lblToimintaOsoite.TabIndex = 9;
            lblToimintaOsoite.Text = "Katuosoite";
            // 
            // lblToimintaMokinnimi
            // 
            lblToimintaMokinnimi.AutoSize = true;
            lblToimintaMokinnimi.Location = new Point(13, 199);
            lblToimintaMokinnimi.Name = "lblToimintaMokinnimi";
            lblToimintaMokinnimi.Size = new Size(83, 20);
            lblToimintaMokinnimi.TabIndex = 7;
            lblToimintaMokinnimi.Text = "Mökin nimi";
            // 
            // tbToimintaHenkilo
            // 
            tbToimintaHenkilo.Location = new Point(13, 455);
            tbToimintaHenkilo.Margin = new Padding(3, 4, 3, 4);
            tbToimintaHenkilo.Name = "tbToimintaHenkilo";
            tbToimintaHenkilo.Size = new Size(227, 27);
            tbToimintaHenkilo.TabIndex = 5;
            // 
            // lblToimintaPostinro
            // 
            lblToimintaPostinro.AutoSize = true;
            lblToimintaPostinro.Location = new Point(9, 368);
            lblToimintaPostinro.Name = "lblToimintaPostinro";
            lblToimintaPostinro.Size = new Size(91, 20);
            lblToimintaPostinro.TabIndex = 10;
            lblToimintaPostinro.Text = "Postinumero";
            // 
            // tbToimintaPostinro
            // 
            tbToimintaPostinro.Location = new Point(13, 396);
            tbToimintaPostinro.Margin = new Padding(3, 4, 3, 4);
            tbToimintaPostinro.Name = "tbToimintaPostinro";
            tbToimintaPostinro.Size = new Size(227, 27);
            tbToimintaPostinro.TabIndex = 4;
            // 
            // tbToimintaKuvaus
            // 
            tbToimintaKuvaus.Location = new Point(13, 277);
            tbToimintaKuvaus.Margin = new Padding(3, 4, 3, 4);
            tbToimintaKuvaus.Name = "tbToimintaKuvaus";
            tbToimintaKuvaus.Size = new Size(227, 27);
            tbToimintaKuvaus.TabIndex = 2;
            // 
            // lblToimintaHenkilo
            // 
            lblToimintaHenkilo.AutoSize = true;
            lblToimintaHenkilo.Location = new Point(9, 431);
            lblToimintaHenkilo.Name = "lblToimintaHenkilo";
            lblToimintaHenkilo.Size = new Size(102, 20);
            lblToimintaHenkilo.TabIndex = 11;
            lblToimintaHenkilo.Text = "Henkilömäärä";
            // 
            // btnToimintaPoista
            // 
            btnToimintaPoista.Location = new Point(127, 548);
            btnToimintaPoista.Margin = new Padding(3, 4, 3, 4);
            btnToimintaPoista.Name = "btnToimintaPoista";
            btnToimintaPoista.Size = new Size(113, 56);
            btnToimintaPoista.TabIndex = 14;
            btnToimintaPoista.Text = "Poista mökki";
            btnToimintaPoista.UseVisualStyleBackColor = true;
            // 
            // tbToimintaOsoite
            // 
            tbToimintaOsoite.Location = new Point(13, 333);
            tbToimintaOsoite.Margin = new Padding(3, 4, 3, 4);
            tbToimintaOsoite.Name = "tbToimintaOsoite";
            tbToimintaOsoite.Size = new Size(227, 27);
            tbToimintaOsoite.TabIndex = 3;
            // 
            // lblToimintaVarustelu
            // 
            lblToimintaVarustelu.AutoSize = true;
            lblToimintaVarustelu.Location = new Point(9, 485);
            lblToimintaVarustelu.Name = "lblToimintaVarustelu";
            lblToimintaVarustelu.Size = new Size(69, 20);
            lblToimintaVarustelu.TabIndex = 12;
            lblToimintaVarustelu.Text = "Varustelu";
            // 
            // btnToimintaLisaa
            // 
            btnToimintaLisaa.Location = new Point(13, 548);
            btnToimintaLisaa.Margin = new Padding(3, 4, 3, 4);
            btnToimintaLisaa.Name = "btnToimintaLisaa";
            btnToimintaLisaa.Size = new Size(107, 56);
            btnToimintaLisaa.TabIndex = 13;
            btnToimintaLisaa.Text = "Lisää mökki";
            btnToimintaLisaa.UseVisualStyleBackColor = true;
            // 
            // tbpgLaskujenhallinta
            // 
            tbpgLaskujenhallinta.Location = new Point(4, 29);
            tbpgLaskujenhallinta.Margin = new Padding(3, 4, 3, 4);
            tbpgLaskujenhallinta.Name = "tbpgLaskujenhallinta";
            tbpgLaskujenhallinta.Padding = new Padding(2, 3, 2, 3);
            tbpgLaskujenhallinta.Size = new Size(1089, 995);
            tbpgLaskujenhallinta.TabIndex = 5;
            tbpgLaskujenhallinta.Text = "Laskujen hallinta";
            tbpgLaskujenhallinta.UseVisualStyleBackColor = true;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 835);
            Controls.Add(tbcAsiakasHallinta);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  ";
            tbcAsiakasHallinta.ResumeLayout(false);
            tbpgAloitussivu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tbpgAsiakashallinta.ResumeLayout(false);
            tbpgAsiakashallinta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsiakashallinta).EndInit();
            tbpgPalveluhallinta.ResumeLayout(false);
            tbpgPalveluhallinta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPalvelut).EndInit();
            tbpgMokkivaraushallinta.ResumeLayout(false);
            tbpgMokkivaraushallinta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgMokkiLista).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tbpgToimintaaluehallinta.ResumeLayout(false);
            tbpgToimintaaluehallinta.PerformLayout();
            pnlToiminta.ResumeLayout(false);
            pnlToiminta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHallinta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private TabControl tbcAsiakasHallinta;
        private TabPage tbpgAloitussivu;
        private Button btnLasku;
        private Button btnAsiakas;
        private Button btnMokkivaraus;
        private Panel panel1;
        private Label lblTittle;
        private Button btnPalvelu;
        private Button btnToiminta;
        private TabPage tbpgAsiakashallinta;
        private TabPage tbpgPalveluhallinta;
        private TabPage tbpgMokkivaraushallinta;
        private TabPage tbpgToimintaaluehallinta;
        private TabPage tbpgLaskujenhallinta;
        private PictureBox pictureBox1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dgvPalvelut;
        private Label lblPalveluID;
        private Label lblKuvaus;
        private Label lblTyyppi;
        private Label label2;
        private Label lblAsiakas;
        private DataGridView dgvAsiakashallinta;
        private Label lblPuhelinnumero;
        private Label lblSahkoposti;
        private Label lblLahiosoite;
        private Label lblSukunimi;
        private Label lblEtunimi;
        private Label lblPostinumero;
        private TextBox tbAsiakasSukunimi;
        private TextBox tbAsiakasLahiosoite;
        private TextBox tbAsiakasEtunimi;
        private TextBox tbAsiakasSahkoposti;
        private TextBox tbAsiakasPuhelinnumero;
        private TextBox tbasiakasPostinumero;
        private TextBox tbAsiakasid;
        private TextBox tbValittuMokkiNimi;
        private TextBox tbValittuMokkiOsoite;
        private TextBox tbValittuMokkiPostiNro;
        private TextBox tbValittuMokkiAlueID;
        private TextBox tbValittuMokkiMokkiID;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblMokkiID;
        private DataGridView dgMokkiLista;
        private Label label5;
        private TextBox tbValittuMokkiHintaVrk;
        private RichTextBox rtbValittuMokkiVarustelu;
        private RichTextBox rtbValittuMokkiKuvaus;
        private TextBox tbValittuMokkiHloMaara;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label lblHinta;
        private Label lblAlv;
        private Button btnAsiakasPoista;
        private Button btnAsiakasPaivita;
        private Button btnAsiakasLisaa;
        private Button btnAsiakasHae;
        private RichTextBox rtbPalvelukuvaus;
        private TextBox tbPalvelualv;
        private TextBox tbPalveluhinta;
        private TextBox tbPalvelutyyppi;
        private TextBox tbPalvelunimi;
        private TextBox tbPalveluID;
        private Button btnPalveluLisaa;
        private Button btnPalveluPaivita;
        private Button btnPalveluPoista;
        private Button btnPalveluHae;
        private Button btnMokkiPoista;
        private Button btnPaivitaMokkiLista;
        private Button btnVaraaValittuMokki;
        private Button btnMokkiHae;
        private DataGridView dgvHallinta;
        private Label lblToimintaAlue;
        private TextBox tbToimintaAlue;
        private Panel pnlToiminta;
        private Label lblToimintaMokinnimi;
        private TextBox tbToimintaNimi;
        private TextBox tbToimintaKuvaus;
        private Label lblToimintaVarustelu;
        private TextBox tbToimintaOsoite;
        private Label lblToimintaHenkilo;
        private TextBox tbToimintaPostinro;
        private Label lblToimintaPostinro;
        private TextBox tbToimintaHenkilo;
        private Label lblToimintaOsoite;
        private TextBox tbToimintaVarustelu;
        private Label lblToimintaKuvaus;
        private Button btnToimintaPoista;
        private Button btnToimintaLisaa;
        private Label lblToimintaOtsikko;
        private Button btnToimintaRaportointi;
        private Button btnToimintaKohteet;
        private Button btnToimintaPoistaAlue;
        private Button btnToimintaLisaaAlue;
        private Button btnMuokkaaValitunMokinTietoja;
        private Label lblMokkiListaOhje;
        private Button btnLisaaMokinTiedot;
        private Panel panel2;
        private Label label1;
    }
}