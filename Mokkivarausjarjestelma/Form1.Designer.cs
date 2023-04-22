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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tbcHallinta = new System.Windows.Forms.TabControl();
            this.tbpgAloitussivu = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnLasku = new System.Windows.Forms.Button();
            this.btnPalvelu = new System.Windows.Forms.Button();
            this.btnAsiakas = new System.Windows.Forms.Button();
            this.btnToiminta = new System.Windows.Forms.Button();
            this.btnMokkivaraus = new System.Windows.Forms.Button();
            this.tbpgAsiakashallinta = new System.Windows.Forms.TabPage();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.tbSahkoposti = new System.Windows.Forms.TextBox();
            this.tbPuhelinnumero = new System.Windows.Forms.TextBox();
            this.tbPostinumero = new System.Windows.Forms.TextBox();
            this.tbAsiakas = new System.Windows.Forms.TextBox();
            this.lblPuhelinnumero = new System.Windows.Forms.Label();
            this.lblSahkoposti = new System.Windows.Forms.Label();
            this.lblLahiosoite = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.lblPostinumero = new System.Windows.Forms.Label();
            this.lblAsiakas = new System.Windows.Forms.Label();
            this.dgvAsiakashallinta = new System.Windows.Forms.DataGridView();
            this.tbpgPalveluhallinta = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPalvelut = new System.Windows.Forms.DataGridView();
            this.tbpgMokkivaraushallinta = new System.Windows.Forms.TabPage();
            this.tbpgToimintaaluehallinta = new System.Windows.Forms.TabPage();
            this.tbpgLaskujenhallinta = new System.Windows.Forms.TabPage();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tbcHallinta.SuspendLayout();
            this.tbpgAloitussivu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tbpgAsiakashallinta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakashallinta)).BeginInit();
            this.tbpgPalveluhallinta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1097, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tbcHallinta
            // 
            this.tbcHallinta.Controls.Add(this.tbpgAloitussivu);
            this.tbcHallinta.Controls.Add(this.tbpgAsiakashallinta);
            this.tbcHallinta.Controls.Add(this.tbpgPalveluhallinta);
            this.tbcHallinta.Controls.Add(this.tbpgMokkivaraushallinta);
            this.tbcHallinta.Controls.Add(this.tbpgToimintaaluehallinta);
            this.tbcHallinta.Controls.Add(this.tbpgLaskujenhallinta);
            this.tbcHallinta.Location = new System.Drawing.Point(0, 0);
            this.tbcHallinta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbcHallinta.Name = "tbcHallinta";
            this.tbcHallinta.SelectedIndex = 0;
            this.tbcHallinta.Size = new System.Drawing.Size(1097, 1028);
            this.tbcHallinta.TabIndex = 7;
            // 
            // tbpgAloitussivu
            // 
            this.tbpgAloitussivu.Controls.Add(this.button1);
            this.tbpgAloitussivu.Controls.Add(this.pictureBox1);
            this.tbpgAloitussivu.Controls.Add(this.panel1);
            this.tbpgAloitussivu.Location = new System.Drawing.Point(4, 29);
            this.tbpgAloitussivu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpgAloitussivu.Name = "tbpgAloitussivu";
            this.tbpgAloitussivu.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbpgAloitussivu.Size = new System.Drawing.Size(1089, 995);
            this.tbpgAloitussivu.TabIndex = 0;
            this.tbpgAloitussivu.Text = "Aloitussivu";
            this.tbpgAloitussivu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 61);
            this.button1.TabIndex = 13;
            this.button1.Text = "Yllatus nappi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mokkivarausjarjestelma.Properties.Resources._6368_log_cabin_black_and_white_free_download;
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTittle);
            this.panel1.Controls.Add(this.btnLasku);
            this.panel1.Controls.Add(this.btnPalvelu);
            this.panel1.Controls.Add(this.btnAsiakas);
            this.panel1.Controls.Add(this.btnToiminta);
            this.panel1.Controls.Add(this.btnMokkivaraus);
            this.panel1.Location = new System.Drawing.Point(593, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 843);
            this.panel1.TabIndex = 11;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTittle.Location = new System.Drawing.Point(7, 5);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(514, 108);
            this.lblTittle.TabIndex = 5;
            this.lblTittle.Text = "Mökkivarausjärjestelmä\r\n    Village Newbies Oy\r\n";
            // 
            // btnLasku
            // 
            this.btnLasku.Location = new System.Drawing.Point(101, 636);
            this.btnLasku.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLasku.Name = "btnLasku";
            this.btnLasku.Size = new System.Drawing.Size(297, 100);
            this.btnLasku.TabIndex = 10;
            this.btnLasku.Text = "Laskujen hallinta";
            this.btnLasku.UseVisualStyleBackColor = true;
            this.btnLasku.Click += new System.EventHandler(this.btnLasku_Click);
            // 
            // btnPalvelu
            // 
            this.btnPalvelu.Location = new System.Drawing.Point(101, 264);
            this.btnPalvelu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPalvelu.Name = "btnPalvelu";
            this.btnPalvelu.Size = new System.Drawing.Size(297, 100);
            this.btnPalvelu.TabIndex = 1;
            this.btnPalvelu.Text = "Palveluiden hallinta";
            this.btnPalvelu.UseVisualStyleBackColor = true;
            this.btnPalvelu.Click += new System.EventHandler(this.btnPalvelu_Click);
            // 
            // btnAsiakas
            // 
            this.btnAsiakas.Location = new System.Drawing.Point(101, 513);
            this.btnAsiakas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAsiakas.Name = "btnAsiakas";
            this.btnAsiakas.Size = new System.Drawing.Size(297, 100);
            this.btnAsiakas.TabIndex = 9;
            this.btnAsiakas.Text = "Asiakashallinta";
            this.btnAsiakas.UseVisualStyleBackColor = true;
            this.btnAsiakas.Click += new System.EventHandler(this.btnAsiakas_Click);
            // 
            // btnToiminta
            // 
            this.btnToiminta.Location = new System.Drawing.Point(101, 141);
            this.btnToiminta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnToiminta.Name = "btnToiminta";
            this.btnToiminta.Size = new System.Drawing.Size(297, 100);
            this.btnToiminta.TabIndex = 0;
            this.btnToiminta.Text = "Toiminta-alueiden hallinta";
            this.btnToiminta.UseVisualStyleBackColor = true;
            this.btnToiminta.Click += new System.EventHandler(this.btnToiminta_Click);
            // 
            // btnMokkivaraus
            // 
            this.btnMokkivaraus.Location = new System.Drawing.Point(101, 387);
            this.btnMokkivaraus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMokkivaraus.Name = "btnMokkivaraus";
            this.btnMokkivaraus.Size = new System.Drawing.Size(297, 100);
            this.btnMokkivaraus.TabIndex = 8;
            this.btnMokkivaraus.Text = "Mökkivarausten hallinta";
            this.btnMokkivaraus.UseVisualStyleBackColor = true;
            this.btnMokkivaraus.Click += new System.EventHandler(this.btnMokkivaraus_Click);
            // 
            // tbpgAsiakashallinta
            // 
            this.tbpgAsiakashallinta.Controls.Add(this.tbSukunimi);
            this.tbpgAsiakashallinta.Controls.Add(this.tbLahiosoite);
            this.tbpgAsiakashallinta.Controls.Add(this.tbEtunimi);
            this.tbpgAsiakashallinta.Controls.Add(this.tbSahkoposti);
            this.tbpgAsiakashallinta.Controls.Add(this.tbPuhelinnumero);
            this.tbpgAsiakashallinta.Controls.Add(this.tbPostinumero);
            this.tbpgAsiakashallinta.Controls.Add(this.tbAsiakas);
            this.tbpgAsiakashallinta.Controls.Add(this.lblPuhelinnumero);
            this.tbpgAsiakashallinta.Controls.Add(this.lblSahkoposti);
            this.tbpgAsiakashallinta.Controls.Add(this.lblLahiosoite);
            this.tbpgAsiakashallinta.Controls.Add(this.lblSukunimi);
            this.tbpgAsiakashallinta.Controls.Add(this.lblEtunimi);
            this.tbpgAsiakashallinta.Controls.Add(this.lblPostinumero);
            this.tbpgAsiakashallinta.Controls.Add(this.lblAsiakas);
            this.tbpgAsiakashallinta.Controls.Add(this.dgvAsiakashallinta);
            this.tbpgAsiakashallinta.Location = new System.Drawing.Point(4, 29);
            this.tbpgAsiakashallinta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpgAsiakashallinta.Name = "tbpgAsiakashallinta";
            this.tbpgAsiakashallinta.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbpgAsiakashallinta.Size = new System.Drawing.Size(1089, 995);
            this.tbpgAsiakashallinta.TabIndex = 1;
            this.tbpgAsiakashallinta.Text = "Asiakashallinta";
            this.tbpgAsiakashallinta.UseVisualStyleBackColor = true;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(114, 244);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(157, 27);
            this.tbSukunimi.TabIndex = 14;
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(114, 305);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(157, 27);
            this.tbLahiosoite.TabIndex = 13;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(114, 175);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(157, 27);
            this.tbEtunimi.TabIndex = 12;
            // 
            // tbSahkoposti
            // 
            this.tbSahkoposti.Location = new System.Drawing.Point(114, 365);
            this.tbSahkoposti.Name = "tbSahkoposti";
            this.tbSahkoposti.Size = new System.Drawing.Size(157, 27);
            this.tbSahkoposti.TabIndex = 11;
            // 
            // tbPuhelinnumero
            // 
            this.tbPuhelinnumero.Location = new System.Drawing.Point(127, 438);
            this.tbPuhelinnumero.Name = "tbPuhelinnumero";
            this.tbPuhelinnumero.Size = new System.Drawing.Size(157, 27);
            this.tbPuhelinnumero.TabIndex = 10;
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.Location = new System.Drawing.Point(114, 115);
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(157, 27);
            this.tbPostinumero.TabIndex = 9;
            // 
            // tbAsiakas
            // 
            this.tbAsiakas.Location = new System.Drawing.Point(114, 58);
            this.tbAsiakas.Name = "tbAsiakas";
            this.tbAsiakas.Size = new System.Drawing.Size(157, 27);
            this.tbAsiakas.TabIndex = 8;
            // 
            // lblPuhelinnumero
            // 
            this.lblPuhelinnumero.Location = new System.Drawing.Point(8, 438);
            this.lblPuhelinnumero.Name = "lblPuhelinnumero";
            this.lblPuhelinnumero.Size = new System.Drawing.Size(113, 60);
            this.lblPuhelinnumero.TabIndex = 7;
            this.lblPuhelinnumero.Text = "Puhelinnumero";
            // 
            // lblSahkoposti
            // 
            this.lblSahkoposti.Location = new System.Drawing.Point(8, 365);
            this.lblSahkoposti.Name = "lblSahkoposti";
            this.lblSahkoposti.Size = new System.Drawing.Size(100, 60);
            this.lblSahkoposti.TabIndex = 6;
            this.lblSahkoposti.Text = "Sähköposti";
            // 
            // lblLahiosoite
            // 
            this.lblLahiosoite.Location = new System.Drawing.Point(8, 305);
            this.lblLahiosoite.Name = "lblLahiosoite";
            this.lblLahiosoite.Size = new System.Drawing.Size(100, 60);
            this.lblLahiosoite.TabIndex = 5;
            this.lblLahiosoite.Text = "Lähiosoite";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.Location = new System.Drawing.Point(8, 247);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(100, 60);
            this.lblSukunimi.TabIndex = 4;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.Location = new System.Drawing.Point(8, 178);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(100, 60);
            this.lblEtunimi.TabIndex = 3;
            this.lblEtunimi.Text = "Etunimi";
            // 
            // lblPostinumero
            // 
            this.lblPostinumero.Location = new System.Drawing.Point(8, 118);
            this.lblPostinumero.Name = "lblPostinumero";
            this.lblPostinumero.Size = new System.Drawing.Size(100, 60);
            this.lblPostinumero.TabIndex = 2;
            this.lblPostinumero.Text = "Postinumero";
            // 
            // lblAsiakas
            // 
            this.lblAsiakas.Location = new System.Drawing.Point(8, 58);
            this.lblAsiakas.Name = "lblAsiakas";
            this.lblAsiakas.Size = new System.Drawing.Size(100, 60);
            this.lblAsiakas.TabIndex = 1;
            this.lblAsiakas.Text = "AsiakasID";
            // 
            // dgvAsiakashallinta
            // 
            this.dgvAsiakashallinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakashallinta.Location = new System.Drawing.Point(358, 0);
            this.dgvAsiakashallinta.Name = "dgvAsiakashallinta";
            this.dgvAsiakashallinta.RowHeadersWidth = 51;
            this.dgvAsiakashallinta.RowTemplate.Height = 29;
            this.dgvAsiakashallinta.Size = new System.Drawing.Size(731, 516);
            this.dgvAsiakashallinta.TabIndex = 0;
            // 
            // tbpgPalveluhallinta
            // 
            this.tbpgPalveluhallinta.Controls.Add(this.label4);
            this.tbpgPalveluhallinta.Controls.Add(this.label3);
            this.tbpgPalveluhallinta.Controls.Add(this.label2);
            this.tbpgPalveluhallinta.Controls.Add(this.label1);
            this.tbpgPalveluhallinta.Controls.Add(this.dgvPalvelut);
            this.tbpgPalveluhallinta.Location = new System.Drawing.Point(4, 29);
            this.tbpgPalveluhallinta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpgPalveluhallinta.Name = "tbpgPalveluhallinta";
            this.tbpgPalveluhallinta.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbpgPalveluhallinta.Size = new System.Drawing.Size(1089, 995);
            this.tbpgPalveluhallinta.TabIndex = 2;
            this.tbpgPalveluhallinta.Text = "Palveluiden hallinta";
            this.tbpgPalveluhallinta.UseVisualStyleBackColor = true;
            this.tbpgPalveluhallinta.Click += new System.EventHandler(this.tbpgPalveluhallinta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // dgvPalvelut
            // 
            this.dgvPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelut.Location = new System.Drawing.Point(408, 7);
            this.dgvPalvelut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPalvelut.Name = "dgvPalvelut";
            this.dgvPalvelut.RowHeadersWidth = 51;
            this.dgvPalvelut.RowTemplate.Height = 25;
            this.dgvPalvelut.Size = new System.Drawing.Size(671, 515);
            this.dgvPalvelut.TabIndex = 0;
            // 
            // tbpgMokkivaraushallinta
            // 
            this.tbpgMokkivaraushallinta.Location = new System.Drawing.Point(4, 29);
            this.tbpgMokkivaraushallinta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpgMokkivaraushallinta.Name = "tbpgMokkivaraushallinta";
            this.tbpgMokkivaraushallinta.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbpgMokkivaraushallinta.Size = new System.Drawing.Size(1089, 995);
            this.tbpgMokkivaraushallinta.TabIndex = 3;
            this.tbpgMokkivaraushallinta.Text = "Mökkivarausten hallinta";
            this.tbpgMokkivaraushallinta.UseVisualStyleBackColor = true;
            // 
            // tbpgToimintaaluehallinta
            // 
            this.tbpgToimintaaluehallinta.Location = new System.Drawing.Point(4, 29);
            this.tbpgToimintaaluehallinta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpgToimintaaluehallinta.Name = "tbpgToimintaaluehallinta";
            this.tbpgToimintaaluehallinta.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbpgToimintaaluehallinta.Size = new System.Drawing.Size(1089, 995);
            this.tbpgToimintaaluehallinta.TabIndex = 4;
            this.tbpgToimintaaluehallinta.Text = "Toiminta-alueiden hallinta";
            this.tbpgToimintaaluehallinta.UseVisualStyleBackColor = true;
            // 
            // tbpgLaskujenhallinta
            // 
            this.tbpgLaskujenhallinta.Location = new System.Drawing.Point(4, 29);
            this.tbpgLaskujenhallinta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpgLaskujenhallinta.Name = "tbpgLaskujenhallinta";
            this.tbpgLaskujenhallinta.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbpgLaskujenhallinta.Size = new System.Drawing.Size(1089, 995);
            this.tbpgLaskujenhallinta.TabIndex = 5;
            this.tbpgLaskujenhallinta.Text = "Laskujen hallinta";
            this.tbpgLaskujenhallinta.UseVisualStyleBackColor = true;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 835);
            this.Controls.Add(this.tbcHallinta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.tbcHallinta.ResumeLayout(false);
            this.tbpgAloitussivu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbpgAsiakashallinta.ResumeLayout(false);
            this.tbpgAsiakashallinta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakashallinta)).EndInit();
            this.tbpgPalveluhallinta.ResumeLayout(false);
            this.tbpgPalveluhallinta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private TabControl tbcHallinta;
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
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label lblAsiakas;
        private DataGridView dgvAsiakashallinta;
        private Label lblPuhelinnumero;
        private Label lblSahkoposti;
        private Label lblLahiosoite;
        private Label lblSukunimi;
        private Label lblEtunimi;
        private Label lblPostinumero;
        private TextBox tbSukunimi;
        private TextBox tbLahiosoite;
        private TextBox tbEtunimi;
        private TextBox tbSahkoposti;
        private TextBox tbPuhelinnumero;
        private TextBox tbPostinumero;
        private TextBox tbAsiakas;
    }
}