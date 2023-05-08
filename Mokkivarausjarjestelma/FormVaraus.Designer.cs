namespace Mokkivarausjarjestelma
{
    partial class FormVaraus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVaraus));
            this.dateTimeMokinVarausAlkuPvm = new System.Windows.Forms.DateTimePicker();
            this.dateTimeMokinVarausLoppuPvm = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValmisVaraus = new System.Windows.Forms.Button();
            this.btnMokinVarausVahvista = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVarausValittuMokkiNimi = new System.Windows.Forms.Label();
            this.dgMokkiVaraukset = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUusiVarausValitseAsiakas = new System.Windows.Forms.ComboBox();
            this.cmbUusiVarausValitseMokki = new System.Windows.Forms.ComboBox();
            this.tbUusiVarausVarausID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVarausValittuAsiakasNimi = new System.Windows.Forms.Label();
            this.lblPvmOhje = new System.Windows.Forms.Label();
            this.btnTakaisinAloitusFormiin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHaunRajaus = new System.Windows.Forms.Panel();
            this.lblCheckVaraajaNimi = new System.Windows.Forms.Label();
            this.lblCheckMokkiNimi = new System.Windows.Forms.Label();
            this.checkMokkiNimiRajaus = new System.Windows.Forms.CheckBox();
            this.checkVaraajaNimiRajaus = new System.Windows.Forms.CheckBox();
            this.panelHakuOhjeet = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMuokkaaMokkiVarausta = new System.Windows.Forms.Button();
            this.btnPoistaMokkiVaraus = new System.Windows.Forms.Button();
            this.btnRajaaVarausHakua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMokkiVaraukset)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelHaunRajaus.SuspendLayout();
            this.panelHakuOhjeet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeMokinVarausAlkuPvm
            // 
            this.dateTimeMokinVarausAlkuPvm.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimeMokinVarausAlkuPvm.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.dateTimeMokinVarausAlkuPvm.CalendarTitleBackColor = System.Drawing.Color.PaleGoldenrod;
            this.dateTimeMokinVarausAlkuPvm.Location = new System.Drawing.Point(100, 140);
            this.dateTimeMokinVarausAlkuPvm.Name = "dateTimeMokinVarausAlkuPvm";
            this.dateTimeMokinVarausAlkuPvm.Size = new System.Drawing.Size(209, 23);
            this.dateTimeMokinVarausAlkuPvm.TabIndex = 0;
            // 
            // dateTimeMokinVarausLoppuPvm
            // 
            this.dateTimeMokinVarausLoppuPvm.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimeMokinVarausLoppuPvm.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.dateTimeMokinVarausLoppuPvm.CalendarTitleBackColor = System.Drawing.Color.PaleGoldenrod;
            this.dateTimeMokinVarausLoppuPvm.Location = new System.Drawing.Point(100, 179);
            this.dateTimeMokinVarausLoppuPvm.Name = "dateTimeMokinVarausLoppuPvm";
            this.dateTimeMokinVarausLoppuPvm.Size = new System.Drawing.Size(209, 23);
            this.dateTimeMokinVarausLoppuPvm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Varaus alkaa:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Varaus loppuu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnValmisVaraus
            // 
            this.btnValmisVaraus.BackColor = System.Drawing.Color.DarkRed;
            this.btnValmisVaraus.Enabled = false;
            this.btnValmisVaraus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValmisVaraus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnValmisVaraus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValmisVaraus.Location = new System.Drawing.Point(136, 267);
            this.btnValmisVaraus.Name = "btnValmisVaraus";
            this.btnValmisVaraus.Size = new System.Drawing.Size(179, 31);
            this.btnValmisVaraus.TabIndex = 5;
            this.btnValmisVaraus.Text = "Tallenna varaus";
            this.btnValmisVaraus.UseVisualStyleBackColor = false;
            this.btnValmisVaraus.Click += new System.EventHandler(this.btnValmisVaraus_Click);
            // 
            // btnMokinVarausVahvista
            // 
            this.btnMokinVarausVahvista.BackColor = System.Drawing.Color.DarkRed;
            this.btnMokinVarausVahvista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMokinVarausVahvista.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMokinVarausVahvista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMokinVarausVahvista.Location = new System.Drawing.Point(136, 230);
            this.btnMokinVarausVahvista.Name = "btnMokinVarausVahvista";
            this.btnMokinVarausVahvista.Size = new System.Drawing.Size(179, 31);
            this.btnMokinVarausVahvista.TabIndex = 6;
            this.btnMokinVarausVahvista.Text = "Vahvista varauksen tiedot";
            this.btnMokinVarausVahvista.UseVisualStyleBackColor = false;
            this.btnMokinVarausVahvista.Click += new System.EventHandler(this.btnMokinVarausVahvista_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valittu mökki:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVarausValittuMokkiNimi
            // 
            this.lblVarausValittuMokkiNimi.AutoSize = true;
            this.lblVarausValittuMokkiNimi.Location = new System.Drawing.Point(100, 45);
            this.lblVarausValittuMokkiNimi.Name = "lblVarausValittuMokkiNimi";
            this.lblVarausValittuMokkiNimi.Size = new System.Drawing.Size(0, 15);
            this.lblVarausValittuMokkiNimi.TabIndex = 8;
            // 
            // dgMokkiVaraukset
            // 
            this.dgMokkiVaraukset.BackgroundColor = System.Drawing.Color.Firebrick;
            this.dgMokkiVaraukset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgMokkiVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMokkiVaraukset.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgMokkiVaraukset.EnableHeadersVisualStyles = false;
            this.dgMokkiVaraukset.Location = new System.Drawing.Point(332, 9);
            this.dgMokkiVaraukset.Name = "dgMokkiVaraukset";
            this.dgMokkiVaraukset.ReadOnly = true;
            this.dgMokkiVaraukset.RowTemplate.Height = 25;
            this.dgMokkiVaraukset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMokkiVaraukset.Size = new System.Drawing.Size(747, 299);
            this.dgMokkiVaraukset.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(43, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Varaaja:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbUusiVarausValitseAsiakas
            // 
            this.cmbUusiVarausValitseAsiakas.BackColor = System.Drawing.Color.Beige;
            this.cmbUusiVarausValitseAsiakas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUusiVarausValitseAsiakas.FormattingEnabled = true;
            this.cmbUusiVarausValitseAsiakas.Location = new System.Drawing.Point(100, 76);
            this.cmbUusiVarausValitseAsiakas.Name = "cmbUusiVarausValitseAsiakas";
            this.cmbUusiVarausValitseAsiakas.Size = new System.Drawing.Size(209, 23);
            this.cmbUusiVarausValitseAsiakas.TabIndex = 11;
            // 
            // cmbUusiVarausValitseMokki
            // 
            this.cmbUusiVarausValitseMokki.BackColor = System.Drawing.Color.Beige;
            this.cmbUusiVarausValitseMokki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUusiVarausValitseMokki.FormattingEnabled = true;
            this.cmbUusiVarausValitseMokki.Location = new System.Drawing.Point(100, 47);
            this.cmbUusiVarausValitseMokki.Name = "cmbUusiVarausValitseMokki";
            this.cmbUusiVarausValitseMokki.Size = new System.Drawing.Size(209, 23);
            this.cmbUusiVarausValitseMokki.TabIndex = 12;
            // 
            // tbUusiVarausVarausID
            // 
            this.tbUusiVarausVarausID.BackColor = System.Drawing.Color.MistyRose;
            this.tbUusiVarausVarausID.Location = new System.Drawing.Point(100, 105);
            this.tbUusiVarausVarausID.Name = "tbUusiVarausVarausID";
            this.tbUusiVarausVarausID.Size = new System.Drawing.Size(209, 23);
            this.tbUusiVarausVarausID.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(33, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Varaus_id:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVarausValittuAsiakasNimi
            // 
            this.lblVarausValittuAsiakasNimi.AutoSize = true;
            this.lblVarausValittuAsiakasNimi.Location = new System.Drawing.Point(100, 74);
            this.lblVarausValittuAsiakasNimi.Name = "lblVarausValittuAsiakasNimi";
            this.lblVarausValittuAsiakasNimi.Size = new System.Drawing.Size(0, 15);
            this.lblVarausValittuAsiakasNimi.TabIndex = 15;
            // 
            // lblPvmOhje
            // 
            this.lblPvmOhje.AutoSize = true;
            this.lblPvmOhje.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPvmOhje.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPvmOhje.Location = new System.Drawing.Point(23, 6);
            this.lblPvmOhje.Name = "lblPvmOhje";
            this.lblPvmOhje.Size = new System.Drawing.Size(285, 38);
            this.lblPvmOhje.TabIndex = 17;
            this.lblPvmOhje.Text = "Tarkasta, etteivät valitut päivämäärät mene\r\npäällekäin olemassaolevan varauksen " +
    "kanssa";
            // 
            // btnTakaisinAloitusFormiin
            // 
            this.btnTakaisinAloitusFormiin.BackColor = System.Drawing.Color.DarkRed;
            this.btnTakaisinAloitusFormiin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakaisinAloitusFormiin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTakaisinAloitusFormiin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTakaisinAloitusFormiin.Location = new System.Drawing.Point(7, 314);
            this.btnTakaisinAloitusFormiin.Name = "btnTakaisinAloitusFormiin";
            this.btnTakaisinAloitusFormiin.Size = new System.Drawing.Size(93, 31);
            this.btnTakaisinAloitusFormiin.TabIndex = 76;
            this.btnTakaisinAloitusFormiin.Text = "Takaisin";
            this.btnTakaisinAloitusFormiin.UseVisualStyleBackColor = false;
            this.btnTakaisinAloitusFormiin.Click += new System.EventHandler(this.btnTakaisinMokkiFormiin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.panelHakuOhjeet);
            this.panel1.Controls.Add(this.panelHaunRajaus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblPvmOhje);
            this.panel1.Controls.Add(this.dateTimeMokinVarausAlkuPvm);
            this.panel1.Controls.Add(this.dateTimeMokinVarausLoppuPvm);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbUusiVarausVarausID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbUusiVarausValitseMokki);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbUusiVarausValitseAsiakas);
            this.panel1.Location = new System.Drawing.Point(7, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 299);
            this.panel1.TabIndex = 77;
            // 
            // panelHaunRajaus
            // 
            this.panelHaunRajaus.Controls.Add(this.lblCheckVaraajaNimi);
            this.panelHaunRajaus.Controls.Add(this.lblCheckMokkiNimi);
            this.panelHaunRajaus.Controls.Add(this.checkMokkiNimiRajaus);
            this.panelHaunRajaus.Controls.Add(this.checkVaraajaNimiRajaus);
            this.panelHaunRajaus.Location = new System.Drawing.Point(7, 221);
            this.panelHaunRajaus.Name = "panelHaunRajaus";
            this.panelHaunRajaus.Size = new System.Drawing.Size(97, 65);
            this.panelHaunRajaus.TabIndex = 83;
            this.panelHaunRajaus.Visible = false;
            // 
            // lblCheckVaraajaNimi
            // 
            this.lblCheckVaraajaNimi.AutoSize = true;
            this.lblCheckVaraajaNimi.Location = new System.Drawing.Point(0, 43);
            this.lblCheckVaraajaNimi.Name = "lblCheckVaraajaNimi";
            this.lblCheckVaraajaNimi.Size = new System.Drawing.Size(78, 15);
            this.lblCheckVaraajaNimi.TabIndex = 84;
            this.lblCheckVaraajaNimi.Text = "Varaajan nimi";
            // 
            // lblCheckMokkiNimi
            // 
            this.lblCheckMokkiNimi.AutoSize = true;
            this.lblCheckMokkiNimi.Location = new System.Drawing.Point(10, 13);
            this.lblCheckMokkiNimi.Name = "lblCheckMokkiNimi";
            this.lblCheckMokkiNimi.Size = new System.Drawing.Size(68, 15);
            this.lblCheckMokkiNimi.TabIndex = 83;
            this.lblCheckMokkiNimi.Text = "Mökin nimi";
            // 
            // checkMokkiNimiRajaus
            // 
            this.checkMokkiNimiRajaus.AutoSize = true;
            this.checkMokkiNimiRajaus.Location = new System.Drawing.Point(78, 14);
            this.checkMokkiNimiRajaus.Name = "checkMokkiNimiRajaus";
            this.checkMokkiNimiRajaus.Size = new System.Drawing.Size(15, 14);
            this.checkMokkiNimiRajaus.TabIndex = 82;
            this.checkMokkiNimiRajaus.UseVisualStyleBackColor = true;
            this.checkMokkiNimiRajaus.CheckedChanged += new System.EventHandler(this.checkMokkiNimiRajaus_CheckedChanged);
            // 
            // checkVaraajaNimiRajaus
            // 
            this.checkVaraajaNimiRajaus.AutoSize = true;
            this.checkVaraajaNimiRajaus.Location = new System.Drawing.Point(78, 44);
            this.checkVaraajaNimiRajaus.Name = "checkVaraajaNimiRajaus";
            this.checkVaraajaNimiRajaus.Size = new System.Drawing.Size(15, 14);
            this.checkVaraajaNimiRajaus.TabIndex = 81;
            this.checkVaraajaNimiRajaus.UseVisualStyleBackColor = true;
            this.checkVaraajaNimiRajaus.CheckedChanged += new System.EventHandler(this.checkVaraajaNimiRajaus_CheckedChanged);
            // 
            // panelHakuOhjeet
            // 
            this.panelHakuOhjeet.BackColor = System.Drawing.Color.Firebrick;
            this.panelHakuOhjeet.Controls.Add(this.label6);
            this.panelHakuOhjeet.Location = new System.Drawing.Point(5, 105);
            this.panelHakuOhjeet.Name = "panelHakuOhjeet";
            this.panelHakuOhjeet.Size = new System.Drawing.Size(309, 191);
            this.panelHakuOhjeet.TabIndex = 84;
            this.panelHakuOhjeet.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 180);
            this.label6.TabIndex = 0;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // btnMuokkaaMokkiVarausta
            // 
            this.btnMuokkaaMokkiVarausta.BackColor = System.Drawing.Color.DarkRed;
            this.btnMuokkaaMokkiVarausta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMuokkaaMokkiVarausta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMuokkaaMokkiVarausta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMuokkaaMokkiVarausta.Location = new System.Drawing.Point(607, 314);
            this.btnMuokkaaMokkiVarausta.Name = "btnMuokkaaMokkiVarausta";
            this.btnMuokkaaMokkiVarausta.Size = new System.Drawing.Size(179, 31);
            this.btnMuokkaaMokkiVarausta.TabIndex = 78;
            this.btnMuokkaaMokkiVarausta.Text = "Muokkaa varausta";
            this.btnMuokkaaMokkiVarausta.UseVisualStyleBackColor = false;
            this.btnMuokkaaMokkiVarausta.Click += new System.EventHandler(this.btnMuokkaaMokkiVarausta_Click);
            // 
            // btnPoistaMokkiVaraus
            // 
            this.btnPoistaMokkiVaraus.BackColor = System.Drawing.Color.DarkRed;
            this.btnPoistaMokkiVaraus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPoistaMokkiVaraus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPoistaMokkiVaraus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPoistaMokkiVaraus.Location = new System.Drawing.Point(885, 314);
            this.btnPoistaMokkiVaraus.Name = "btnPoistaMokkiVaraus";
            this.btnPoistaMokkiVaraus.Size = new System.Drawing.Size(194, 31);
            this.btnPoistaMokkiVaraus.TabIndex = 79;
            this.btnPoistaMokkiVaraus.Text = "Poista varaus tietokannasta";
            this.btnPoistaMokkiVaraus.UseVisualStyleBackColor = false;
            this.btnPoistaMokkiVaraus.Click += new System.EventHandler(this.btnPoistaMokkiVaraus_Click);
            // 
            // btnRajaaVarausHakua
            // 
            this.btnRajaaVarausHakua.BackColor = System.Drawing.Color.DarkRed;
            this.btnRajaaVarausHakua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRajaaVarausHakua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRajaaVarausHakua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRajaaVarausHakua.Location = new System.Drawing.Point(332, 314);
            this.btnRajaaVarausHakua.Name = "btnRajaaVarausHakua";
            this.btnRajaaVarausHakua.Size = new System.Drawing.Size(179, 31);
            this.btnRajaaVarausHakua.TabIndex = 80;
            this.btnRajaaVarausHakua.Text = "Rajaa hakua";
            this.btnRajaaVarausHakua.UseVisualStyleBackColor = false;
            this.btnRajaaVarausHakua.Click += new System.EventHandler(this.btmRajaaVarausHakua_Click);
            // 
            // FormVaraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1083, 354);
            this.Controls.Add(this.btnRajaaVarausHakua);
            this.Controls.Add(this.btnPoistaMokkiVaraus);
            this.Controls.Add(this.btnMuokkaaMokkiVarausta);
            this.Controls.Add(this.btnTakaisinAloitusFormiin);
            this.Controls.Add(this.lblVarausValittuAsiakasNimi);
            this.Controls.Add(this.dgMokkiVaraukset);
            this.Controls.Add(this.lblVarausValittuMokkiNimi);
            this.Controls.Add(this.btnMokinVarausVahvista);
            this.Controls.Add(this.btnValmisVaraus);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormVaraus";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Varausten hallinta";
            ((System.ComponentModel.ISupportInitialize)(this.dgMokkiVaraukset)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHaunRajaus.ResumeLayout(false);
            this.panelHaunRajaus.PerformLayout();
            this.panelHakuOhjeet.ResumeLayout(false);
            this.panelHakuOhjeet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimeMokinVarausAlkuPvm;
        private DateTimePicker dateTimeMokinVarausLoppuPvm;
        private Label label1;
        private Label label2;
        private Button btnValmisVaraus;
        private Button btnMokinVarausVahvista;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label3;
        private Label lblVarausValittuMokkiNimi;
        private DataGridView dgMokkiVaraukset;
        private Label label4;
        private ComboBox cmbUusiVarausValitseAsiakas;
        private ComboBox cmbUusiVarausValitseMokki;
        private TextBox tbUusiVarausVarausID;
        private Label label5;
        private Label lblVarausValittuAsiakasNimi;
        private Label lblPvmOhje;
        private Button btnTakaisinAloitusFormiin;
        private Panel panel1;
        private Button btnMuokkaaMokkiVarausta;
        private Button btnPoistaMokkiVaraus;
        private Button btnRajaaVarausHakua;
        private Panel panelHaunRajaus;
        private Label lblCheckVaraajaNimi;
        private Label lblCheckMokkiNimi;
        private CheckBox checkMokkiNimiRajaus;
        private CheckBox checkVaraajaNimiRajaus;
        private Panel panelHakuOhjeet;
        private Label label6;
    }
}