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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMokkiID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbpgToimintaaluehallinta = new System.Windows.Forms.TabPage();
            this.tbpgLaskujenhallinta = new System.Windows.Forms.TabPage();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbcHallinta.SuspendLayout();
            this.tbpgAloitussivu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tbpgAsiakashallinta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakashallinta)).BeginInit();
            this.tbpgPalveluhallinta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).BeginInit();
            this.tbpgMokkivaraushallinta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
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
            this.tbcHallinta.Name = "tbcHallinta";
            this.tbcHallinta.SelectedIndex = 0;
            this.tbcHallinta.Size = new System.Drawing.Size(960, 771);
            this.tbcHallinta.TabIndex = 7;
            // 
            // tbpgAloitussivu
            // 
            this.tbpgAloitussivu.Controls.Add(this.button1);
            this.tbpgAloitussivu.Controls.Add(this.pictureBox1);
            this.tbpgAloitussivu.Controls.Add(this.panel1);
            this.tbpgAloitussivu.Location = new System.Drawing.Point(4, 24);
            this.tbpgAloitussivu.Name = "tbpgAloitussivu";
            this.tbpgAloitussivu.Padding = new System.Windows.Forms.Padding(2);
            this.tbpgAloitussivu.Size = new System.Drawing.Size(952, 743);
            this.tbpgAloitussivu.TabIndex = 0;
            this.tbpgAloitussivu.Text = "Aloitussivu";
            this.tbpgAloitussivu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Yllatus nappi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mokkivarausjarjestelma.Properties.Resources._6368_log_cabin_black_and_white_free_download;
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 262);
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
            this.panel1.Location = new System.Drawing.Point(519, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 632);
            this.panel1.TabIndex = 11;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTittle.Location = new System.Drawing.Point(6, 4);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(408, 84);
            this.lblTittle.TabIndex = 5;
            this.lblTittle.Text = "Mökkivarausjärjestelmä\r\n    Village Newbies Oy\r\n";
            // 
            // btnLasku
            // 
            this.btnLasku.Location = new System.Drawing.Point(88, 477);
            this.btnLasku.Name = "btnLasku";
            this.btnLasku.Size = new System.Drawing.Size(260, 75);
            this.btnLasku.TabIndex = 10;
            this.btnLasku.Text = "Laskujen hallinta";
            this.btnLasku.UseVisualStyleBackColor = true;
            this.btnLasku.Click += new System.EventHandler(this.btnLasku_Click);
            // 
            // btnPalvelu
            // 
            this.btnPalvelu.Location = new System.Drawing.Point(88, 198);
            this.btnPalvelu.Name = "btnPalvelu";
            this.btnPalvelu.Size = new System.Drawing.Size(260, 75);
            this.btnPalvelu.TabIndex = 1;
            this.btnPalvelu.Text = "Palveluiden hallinta";
            this.btnPalvelu.UseVisualStyleBackColor = true;
            this.btnPalvelu.Click += new System.EventHandler(this.btnPalvelu_Click);
            // 
            // btnAsiakas
            // 
            this.btnAsiakas.Location = new System.Drawing.Point(88, 385);
            this.btnAsiakas.Name = "btnAsiakas";
            this.btnAsiakas.Size = new System.Drawing.Size(260, 75);
            this.btnAsiakas.TabIndex = 9;
            this.btnAsiakas.Text = "Asiakashallinta";
            this.btnAsiakas.UseVisualStyleBackColor = true;
            this.btnAsiakas.Click += new System.EventHandler(this.btnAsiakas_Click);
            // 
            // btnToiminta
            // 
            this.btnToiminta.Location = new System.Drawing.Point(88, 106);
            this.btnToiminta.Name = "btnToiminta";
            this.btnToiminta.Size = new System.Drawing.Size(260, 75);
            this.btnToiminta.TabIndex = 0;
            this.btnToiminta.Text = "Toiminta-alueiden hallinta";
            this.btnToiminta.UseVisualStyleBackColor = true;
            this.btnToiminta.Click += new System.EventHandler(this.btnToiminta_Click);
            // 
            // btnMokkivaraus
            // 
            this.btnMokkivaraus.Location = new System.Drawing.Point(88, 290);
            this.btnMokkivaraus.Name = "btnMokkivaraus";
            this.btnMokkivaraus.Size = new System.Drawing.Size(260, 75);
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
            this.tbpgAsiakashallinta.Location = new System.Drawing.Point(4, 24);
            this.tbpgAsiakashallinta.Name = "tbpgAsiakashallinta";
            this.tbpgAsiakashallinta.Padding = new System.Windows.Forms.Padding(2);
            this.tbpgAsiakashallinta.Size = new System.Drawing.Size(952, 743);
            this.tbpgAsiakashallinta.TabIndex = 1;
            this.tbpgAsiakashallinta.Text = "Asiakashallinta";
            this.tbpgAsiakashallinta.UseVisualStyleBackColor = true;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(100, 183);
            this.tbSukunimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(138, 23);
            this.tbSukunimi.TabIndex = 14;
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(100, 229);
            this.tbLahiosoite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(138, 23);
            this.tbLahiosoite.TabIndex = 13;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(100, 131);
            this.tbEtunimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(138, 23);
            this.tbEtunimi.TabIndex = 12;
            // 
            // tbSahkoposti
            // 
            this.tbSahkoposti.Location = new System.Drawing.Point(100, 274);
            this.tbSahkoposti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSahkoposti.Name = "tbSahkoposti";
            this.tbSahkoposti.Size = new System.Drawing.Size(138, 23);
            this.tbSahkoposti.TabIndex = 11;
            // 
            // tbPuhelinnumero
            // 
            this.tbPuhelinnumero.Location = new System.Drawing.Point(111, 328);
            this.tbPuhelinnumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPuhelinnumero.Name = "tbPuhelinnumero";
            this.tbPuhelinnumero.Size = new System.Drawing.Size(138, 23);
            this.tbPuhelinnumero.TabIndex = 10;
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.Location = new System.Drawing.Point(100, 86);
            this.tbPostinumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(138, 23);
            this.tbPostinumero.TabIndex = 9;
            // 
            // tbAsiakas
            // 
            this.tbAsiakas.Location = new System.Drawing.Point(100, 44);
            this.tbAsiakas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAsiakas.Name = "tbAsiakas";
            this.tbAsiakas.Size = new System.Drawing.Size(138, 23);
            this.tbAsiakas.TabIndex = 8;
            // 
            // lblPuhelinnumero
            // 
            this.lblPuhelinnumero.Location = new System.Drawing.Point(7, 328);
            this.lblPuhelinnumero.Name = "lblPuhelinnumero";
            this.lblPuhelinnumero.Size = new System.Drawing.Size(99, 45);
            this.lblPuhelinnumero.TabIndex = 7;
            this.lblPuhelinnumero.Text = "Puhelinnumero";
            // 
            // lblSahkoposti
            // 
            this.lblSahkoposti.Location = new System.Drawing.Point(7, 274);
            this.lblSahkoposti.Name = "lblSahkoposti";
            this.lblSahkoposti.Size = new System.Drawing.Size(88, 45);
            this.lblSahkoposti.TabIndex = 6;
            this.lblSahkoposti.Text = "Sähköposti";
            // 
            // lblLahiosoite
            // 
            this.lblLahiosoite.Location = new System.Drawing.Point(7, 229);
            this.lblLahiosoite.Name = "lblLahiosoite";
            this.lblLahiosoite.Size = new System.Drawing.Size(88, 45);
            this.lblLahiosoite.TabIndex = 5;
            this.lblLahiosoite.Text = "Lähiosoite";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.Location = new System.Drawing.Point(7, 185);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(88, 45);
            this.lblSukunimi.TabIndex = 4;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.Location = new System.Drawing.Point(7, 134);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(88, 45);
            this.lblEtunimi.TabIndex = 3;
            this.lblEtunimi.Text = "Etunimi";
            // 
            // lblPostinumero
            // 
            this.lblPostinumero.Location = new System.Drawing.Point(7, 88);
            this.lblPostinumero.Name = "lblPostinumero";
            this.lblPostinumero.Size = new System.Drawing.Size(88, 45);
            this.lblPostinumero.TabIndex = 2;
            this.lblPostinumero.Text = "Postinumero";
            // 
            // lblAsiakas
            // 
            this.lblAsiakas.Location = new System.Drawing.Point(7, 44);
            this.lblAsiakas.Name = "lblAsiakas";
            this.lblAsiakas.Size = new System.Drawing.Size(88, 45);
            this.lblAsiakas.TabIndex = 1;
            this.lblAsiakas.Text = "AsiakasID";
            // 
            // dgvAsiakashallinta
            // 
            this.dgvAsiakashallinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakashallinta.Location = new System.Drawing.Point(313, 0);
            this.dgvAsiakashallinta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAsiakashallinta.Name = "dgvAsiakashallinta";
            this.dgvAsiakashallinta.RowHeadersWidth = 51;
            this.dgvAsiakashallinta.RowTemplate.Height = 29;
            this.dgvAsiakashallinta.Size = new System.Drawing.Size(640, 387);
            this.dgvAsiakashallinta.TabIndex = 0;
            // 
            // tbpgPalveluhallinta
            // 
            this.tbpgPalveluhallinta.Controls.Add(this.label4);
            this.tbpgPalveluhallinta.Controls.Add(this.label3);
            this.tbpgPalveluhallinta.Controls.Add(this.label2);
            this.tbpgPalveluhallinta.Controls.Add(this.label1);
            this.tbpgPalveluhallinta.Controls.Add(this.dgvPalvelut);
            this.tbpgPalveluhallinta.Location = new System.Drawing.Point(4, 24);
            this.tbpgPalveluhallinta.Name = "tbpgPalveluhallinta";
            this.tbpgPalveluhallinta.Padding = new System.Windows.Forms.Padding(2);
            this.tbpgPalveluhallinta.Size = new System.Drawing.Size(952, 743);
            this.tbpgPalveluhallinta.TabIndex = 2;
            this.tbpgPalveluhallinta.Text = "Palveluiden hallinta";
            this.tbpgPalveluhallinta.UseVisualStyleBackColor = true;
            this.tbpgPalveluhallinta.Click += new System.EventHandler(this.tbpgPalveluhallinta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // dgvPalvelut
            // 
            this.dgvPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelut.Location = new System.Drawing.Point(357, 5);
            this.dgvPalvelut.Name = "dgvPalvelut";
            this.dgvPalvelut.RowHeadersWidth = 51;
            this.dgvPalvelut.RowTemplate.Height = 25;
            this.dgvPalvelut.Size = new System.Drawing.Size(587, 386);
            this.dgvPalvelut.TabIndex = 0;
            // 
            // tbpgMokkivaraushallinta
            // 
            this.tbpgMokkivaraushallinta.Controls.Add(this.label5);
            this.tbpgMokkivaraushallinta.Controls.Add(this.textBox4);
            this.tbpgMokkivaraushallinta.Controls.Add(this.richTextBox2);
            this.tbpgMokkivaraushallinta.Controls.Add(this.richTextBox1);
            this.tbpgMokkivaraushallinta.Controls.Add(this.textBox9);
            this.tbpgMokkivaraushallinta.Controls.Add(this.label11);
            this.tbpgMokkivaraushallinta.Controls.Add(this.label12);
            this.tbpgMokkivaraushallinta.Controls.Add(this.label13);
            this.tbpgMokkivaraushallinta.Controls.Add(this.textBox1);
            this.tbpgMokkivaraushallinta.Controls.Add(this.textBox2);
            this.tbpgMokkivaraushallinta.Controls.Add(this.textBox3);
            this.tbpgMokkivaraushallinta.Controls.Add(this.textBox6);
            this.tbpgMokkivaraushallinta.Controls.Add(this.textBox7);
            this.tbpgMokkivaraushallinta.Controls.Add(this.label6);
            this.tbpgMokkivaraushallinta.Controls.Add(this.label7);
            this.tbpgMokkivaraushallinta.Controls.Add(this.label8);
            this.tbpgMokkivaraushallinta.Controls.Add(this.label9);
            this.tbpgMokkivaraushallinta.Controls.Add(this.label10);
            this.tbpgMokkivaraushallinta.Controls.Add(this.lblMokkiID);
            this.tbpgMokkivaraushallinta.Controls.Add(this.dataGridView1);
            this.tbpgMokkivaraushallinta.Location = new System.Drawing.Point(4, 24);
            this.tbpgMokkivaraushallinta.Name = "tbpgMokkivaraushallinta";
            this.tbpgMokkivaraushallinta.Padding = new System.Windows.Forms.Padding(2);
            this.tbpgMokkivaraushallinta.Size = new System.Drawing.Size(952, 743);
            this.tbpgMokkivaraushallinta.TabIndex = 3;
            this.tbpgMokkivaraushallinta.Text = "Mökkivarausten hallinta";
            this.tbpgMokkivaraushallinta.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 129);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 23);
            this.textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 152);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 23);
            this.textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 106);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 23);
            this.textBox3.TabIndex = 27;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(92, 83);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(148, 23);
            this.textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(92, 58);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(148, 23);
            this.textBox7.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 45);
            this.label6.TabIndex = 21;
            this.label6.Text = "Varustelu";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Lähiosoite";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 129);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mökin nimi";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Postinro";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Alue_ID";
            // 
            // lblMokkiID
            // 
            this.lblMokkiID.Location = new System.Drawing.Point(8, 64);
            this.lblMokkiID.Name = "lblMokkiID";
            this.lblMokkiID.Size = new System.Drawing.Size(88, 24);
            this.lblMokkiID.TabIndex = 16;
            this.lblMokkiID.Text = "Mokki_ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(246, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(706, 450);
            this.dataGridView1.TabIndex = 15;
            // 
            // tbpgToimintaaluehallinta
            // 
            this.tbpgToimintaaluehallinta.Location = new System.Drawing.Point(4, 24);
            this.tbpgToimintaaluehallinta.Name = "tbpgToimintaaluehallinta";
            this.tbpgToimintaaluehallinta.Padding = new System.Windows.Forms.Padding(2);
            this.tbpgToimintaaluehallinta.Size = new System.Drawing.Size(952, 743);
            this.tbpgToimintaaluehallinta.TabIndex = 4;
            this.tbpgToimintaaluehallinta.Text = "Toiminta-alueiden hallinta";
            this.tbpgToimintaaluehallinta.UseVisualStyleBackColor = true;
            // 
            // tbpgLaskujenhallinta
            // 
            this.tbpgLaskujenhallinta.Location = new System.Drawing.Point(4, 24);
            this.tbpgLaskujenhallinta.Name = "tbpgLaskujenhallinta";
            this.tbpgLaskujenhallinta.Padding = new System.Windows.Forms.Padding(2);
            this.tbpgLaskujenhallinta.Size = new System.Drawing.Size(952, 743);
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
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(92, 309);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(148, 23);
            this.textBox9.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(8, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Henkilömäärä";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(8, 197);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Kuvaus";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(8, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "Hinta (/vrk)";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(92, 197);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(148, 112);
            this.richTextBox1.TabIndex = 35;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(92, 332);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(148, 118);
            this.richTextBox2.TabIndex = 36;
            this.richTextBox2.Text = "";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 175);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 23);
            this.textBox4.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 626);
            this.Controls.Add(this.tbcHallinta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            this.tbpgMokkivaraushallinta.ResumeLayout(false);
            this.tbpgMokkivaraushallinta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblMokkiID;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox4;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private TextBox textBox9;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}