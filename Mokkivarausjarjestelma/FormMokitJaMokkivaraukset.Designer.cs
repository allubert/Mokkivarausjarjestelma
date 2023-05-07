namespace Mokkivarausjarjestelma
{
    partial class FormMokitJaMokkivaraukset
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMokitJaMokkivaraukset));
            this.btnLisaaMokinTiedot = new System.Windows.Forms.Button();
            this.btnMuokkaaValitunMokinTietoja = new System.Windows.Forms.Button();
            this.btnMokkiPoista = new System.Windows.Forms.Button();
            this.btnVaraaValittuMokki = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbValittuMokkiHintaVrk = new System.Windows.Forms.TextBox();
            this.rtbValittuMokkiVarustelu = new System.Windows.Forms.RichTextBox();
            this.rtbValittuMokkiKuvaus = new System.Windows.Forms.RichTextBox();
            this.tbValittuMokkiHloMaara = new System.Windows.Forms.TextBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.tbValittuMokkiNimi = new System.Windows.Forms.TextBox();
            this.tbValittuMokkiOsoite = new System.Windows.Forms.TextBox();
            this.tbValittuMokkiMokkiID = new System.Windows.Forms.TextBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgMokkiLista = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMokkiListaOhje = new System.Windows.Forms.Label();
            this.btnTakaisinAloitusFormiin = new System.Windows.Forms.Button();
            this.cmbUusiMokkiValitseAlueID = new System.Windows.Forms.ComboBox();
            this.cmbUusiMokkiValitsePostiNro = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkPostiNro = new System.Windows.Forms.CheckBox();
            this.checkAlueID = new System.Windows.Forms.CheckBox();
            this.btnSuoritaMokkienHaku = new System.Windows.Forms.Button();
            this.btnHaeMokit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMokkiLista)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLisaaMokinTiedot
            // 
            this.btnLisaaMokinTiedot.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLisaaMokinTiedot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLisaaMokinTiedot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLisaaMokinTiedot.Location = new System.Drawing.Point(7, 441);
            this.btnLisaaMokinTiedot.Name = "btnLisaaMokinTiedot";
            this.btnLisaaMokinTiedot.Size = new System.Drawing.Size(226, 30);
            this.btnLisaaMokinTiedot.TabIndex = 56;
            this.btnLisaaMokinTiedot.Text = "Lisää mökin tiedot";
            this.btnLisaaMokinTiedot.UseVisualStyleBackColor = false;
            this.btnLisaaMokinTiedot.Click += new System.EventHandler(this.btnLisaaMokinTiedot_Click);
            // 
            // btnMuokkaaValitunMokinTietoja
            // 
            this.btnMuokkaaValitunMokinTietoja.BackColor = System.Drawing.Color.PeachPuff;
            this.btnMuokkaaValitunMokinTietoja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMuokkaaValitunMokinTietoja.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMuokkaaValitunMokinTietoja.Location = new System.Drawing.Point(7, 369);
            this.btnMuokkaaValitunMokinTietoja.Name = "btnMuokkaaValitunMokinTietoja";
            this.btnMuokkaaValitunMokinTietoja.Size = new System.Drawing.Size(72, 30);
            this.btnMuokkaaValitunMokinTietoja.TabIndex = 61;
            this.btnMuokkaaValitunMokinTietoja.Text = "Muokkaa";
            this.btnMuokkaaValitunMokinTietoja.UseVisualStyleBackColor = false;
            this.btnMuokkaaValitunMokinTietoja.Click += new System.EventHandler(this.btnMuokkaaValitunMokinTietoja_Click);
            // 
            // btnMokkiPoista
            // 
            this.btnMokkiPoista.BackColor = System.Drawing.Color.PeachPuff;
            this.btnMokkiPoista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMokkiPoista.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMokkiPoista.Location = new System.Drawing.Point(1006, 490);
            this.btnMokkiPoista.Name = "btnMokkiPoista";
            this.btnMokkiPoista.Size = new System.Drawing.Size(187, 30);
            this.btnMokkiPoista.TabIndex = 60;
            this.btnMokkiPoista.Text = "Poista mökki tietokannasta";
            this.btnMokkiPoista.UseVisualStyleBackColor = false;
            this.btnMokkiPoista.Click += new System.EventHandler(this.btnPoistaValittuMokkiListalta_Click);
            // 
            // btnVaraaValittuMokki
            // 
            this.btnVaraaValittuMokki.BackColor = System.Drawing.Color.PeachPuff;
            this.btnVaraaValittuMokki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVaraaValittuMokki.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVaraaValittuMokki.Location = new System.Drawing.Point(250, 490);
            this.btnVaraaValittuMokki.Name = "btnVaraaValittuMokki";
            this.btnVaraaValittuMokki.Size = new System.Drawing.Size(166, 30);
            this.btnVaraaValittuMokki.TabIndex = 57;
            this.btnVaraaValittuMokki.Text = "Mökkivarausten hallinta";
            this.btnVaraaValittuMokki.UseVisualStyleBackColor = false;
            this.btnVaraaValittuMokki.Click += new System.EventHandler(this.btnUusiVaraus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 63;
            // 
            // tbValittuMokkiHintaVrk
            // 
            this.tbValittuMokkiHintaVrk.BackColor = System.Drawing.Color.PeachPuff;
            this.tbValittuMokkiHintaVrk.Location = new System.Drawing.Point(88, 165);
            this.tbValittuMokkiHintaVrk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiHintaVrk.Name = "tbValittuMokkiHintaVrk";
            this.tbValittuMokkiHintaVrk.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiHintaVrk.TabIndex = 52;
            // 
            // rtbValittuMokkiVarustelu
            // 
            this.rtbValittuMokkiVarustelu.BackColor = System.Drawing.Color.PeachPuff;
            this.rtbValittuMokkiVarustelu.Location = new System.Drawing.Point(88, 322);
            this.rtbValittuMokkiVarustelu.Name = "rtbValittuMokkiVarustelu";
            this.rtbValittuMokkiVarustelu.Size = new System.Drawing.Size(148, 113);
            this.rtbValittuMokkiVarustelu.TabIndex = 55;
            this.rtbValittuMokkiVarustelu.Text = "";
            // 
            // rtbValittuMokkiKuvaus
            // 
            this.rtbValittuMokkiKuvaus.BackColor = System.Drawing.Color.PeachPuff;
            this.rtbValittuMokkiKuvaus.Location = new System.Drawing.Point(88, 187);
            this.rtbValittuMokkiKuvaus.Name = "rtbValittuMokkiKuvaus";
            this.rtbValittuMokkiKuvaus.Size = new System.Drawing.Size(148, 112);
            this.rtbValittuMokkiKuvaus.TabIndex = 53;
            this.rtbValittuMokkiKuvaus.Text = "";
            // 
            // tbValittuMokkiHloMaara
            // 
            this.tbValittuMokkiHloMaara.BackColor = System.Drawing.Color.PeachPuff;
            this.tbValittuMokkiHloMaara.Location = new System.Drawing.Point(88, 299);
            this.tbValittuMokkiHloMaara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiHloMaara.Name = "tbValittuMokkiHloMaara";
            this.tbValittuMokkiHloMaara.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiHloMaara.TabIndex = 54;
            // 
            // lbl8
            // 
            this.lbl8.BackColor = System.Drawing.Color.Bisque;
            this.lbl8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl8.Location = new System.Drawing.Point(-2, 302);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(88, 20);
            this.lbl8.TabIndex = 72;
            this.lbl8.Text = "Henkilömäärä";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl7
            // 
            this.lbl7.BackColor = System.Drawing.Color.Bisque;
            this.lbl7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl7.Location = new System.Drawing.Point(-2, 190);
            this.lbl7.Name = "lbl7";
            this.lbl7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl7.Size = new System.Drawing.Size(88, 20);
            this.lbl7.TabIndex = 71;
            this.lbl7.Text = "Kuvaus";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl6
            // 
            this.lbl6.BackColor = System.Drawing.Color.Bisque;
            this.lbl6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl6.Location = new System.Drawing.Point(-2, 168);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(88, 25);
            this.lbl6.TabIndex = 69;
            this.lbl6.Text = "Hinta (€/vrk)";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbValittuMokkiNimi
            // 
            this.tbValittuMokkiNimi.BackColor = System.Drawing.Color.PeachPuff;
            this.tbValittuMokkiNimi.Location = new System.Drawing.Point(88, 119);
            this.tbValittuMokkiNimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiNimi.Name = "tbValittuMokkiNimi";
            this.tbValittuMokkiNimi.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiNimi.TabIndex = 50;
            // 
            // tbValittuMokkiOsoite
            // 
            this.tbValittuMokkiOsoite.BackColor = System.Drawing.Color.PeachPuff;
            this.tbValittuMokkiOsoite.Location = new System.Drawing.Point(88, 142);
            this.tbValittuMokkiOsoite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiOsoite.Name = "tbValittuMokkiOsoite";
            this.tbValittuMokkiOsoite.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiOsoite.TabIndex = 51;
            // 
            // tbValittuMokkiMokkiID
            // 
            this.tbValittuMokkiMokkiID.BackColor = System.Drawing.Color.PeachPuff;
            this.tbValittuMokkiMokkiID.Location = new System.Drawing.Point(88, 48);
            this.tbValittuMokkiMokkiID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiMokkiID.Name = "tbValittuMokkiMokkiID";
            this.tbValittuMokkiMokkiID.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiMokkiID.TabIndex = 47;
            // 
            // lbl9
            // 
            this.lbl9.BackColor = System.Drawing.Color.Bisque;
            this.lbl9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl9.Location = new System.Drawing.Point(-2, 325);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(88, 45);
            this.lbl9.TabIndex = 70;
            this.lbl9.Text = "Varustelu";
            this.lbl9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.Bisque;
            this.lbl5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl5.Location = new System.Drawing.Point(-2, 145);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(88, 23);
            this.lbl5.TabIndex = 68;
            this.lbl5.Text = "Lähiosoite";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.Bisque;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(-2, 122);
            this.lbl4.Name = "lbl4";
            this.lbl4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl4.Size = new System.Drawing.Size(88, 21);
            this.lbl4.TabIndex = 67;
            this.lbl4.Text = "Mökin nimi";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Bisque;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(-2, 99);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(88, 23);
            this.lbl3.TabIndex = 66;
            this.lbl3.Text = "Postinro";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Bisque;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(-2, 76);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(88, 21);
            this.lbl2.TabIndex = 65;
            this.lbl2.Text = "Alue_ID";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Bisque;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(-2, 51);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(88, 24);
            this.lbl1.TabIndex = 64;
            this.lbl1.Text = "Mokki_ID";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgMokkiLista
            // 
            this.dgMokkiLista.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgMokkiLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgMokkiLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgMokkiLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMokkiLista.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgMokkiLista.EnableHeadersVisualStyles = false;
            this.dgMokkiLista.GridColor = System.Drawing.Color.BurlyWood;
            this.dgMokkiLista.Location = new System.Drawing.Point(250, 5);
            this.dgMokkiLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgMokkiLista.Name = "dgMokkiLista";
            this.dgMokkiLista.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMokkiLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgMokkiLista.RowHeadersWidth = 51;
            this.dgMokkiLista.RowTemplate.Height = 29;
            this.dgMokkiLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMokkiLista.Size = new System.Drawing.Size(943, 480);
            this.dgMokkiLista.TabIndex = 62;
            this.dgMokkiLista.SelectionChanged += new System.EventHandler(this.dgMokkiLista_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblMokkiListaOhje);
            this.panel2.Controls.Add(this.btnTakaisinAloitusFormiin);
            this.panel2.Location = new System.Drawing.Point(3, 526);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 119);
            this.panel2.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "HUOMIO!";
            // 
            // lblMokkiListaOhje
            // 
            this.lblMokkiListaOhje.AutoSize = true;
            this.lblMokkiListaOhje.Location = new System.Drawing.Point(106, 0);
            this.lblMokkiListaOhje.Name = "lblMokkiListaOhje";
            this.lblMokkiListaOhje.Size = new System.Drawing.Size(1025, 75);
            this.lblMokkiListaOhje.TabIndex = 43;
            this.lblMokkiListaOhje.Text = resources.GetString("lblMokkiListaOhje.Text");
            // 
            // btnTakaisinAloitusFormiin
            // 
            this.btnTakaisinAloitusFormiin.BackColor = System.Drawing.Color.PeachPuff;
            this.btnTakaisinAloitusFormiin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakaisinAloitusFormiin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTakaisinAloitusFormiin.Location = new System.Drawing.Point(3, 82);
            this.btnTakaisinAloitusFormiin.Name = "btnTakaisinAloitusFormiin";
            this.btnTakaisinAloitusFormiin.Size = new System.Drawing.Size(93, 30);
            this.btnTakaisinAloitusFormiin.TabIndex = 74;
            this.btnTakaisinAloitusFormiin.Text = "Alkuvalikko";
            this.btnTakaisinAloitusFormiin.UseVisualStyleBackColor = false;
            this.btnTakaisinAloitusFormiin.Click += new System.EventHandler(this.btnTakaisinAloitusFormiin_Click);
            // 
            // cmbUusiMokkiValitseAlueID
            // 
            this.cmbUusiMokkiValitseAlueID.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbUusiMokkiValitseAlueID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUusiMokkiValitseAlueID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUusiMokkiValitseAlueID.FormattingEnabled = true;
            this.cmbUusiMokkiValitseAlueID.Location = new System.Drawing.Point(88, 73);
            this.cmbUusiMokkiValitseAlueID.Name = "cmbUusiMokkiValitseAlueID";
            this.cmbUusiMokkiValitseAlueID.Size = new System.Drawing.Size(148, 23);
            this.cmbUusiMokkiValitseAlueID.TabIndex = 75;
            // 
            // cmbUusiMokkiValitsePostiNro
            // 
            this.cmbUusiMokkiValitsePostiNro.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbUusiMokkiValitsePostiNro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUusiMokkiValitsePostiNro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUusiMokkiValitsePostiNro.FormattingEnabled = true;
            this.cmbUusiMokkiValitsePostiNro.Location = new System.Drawing.Point(88, 96);
            this.cmbUusiMokkiValitsePostiNro.Name = "cmbUusiMokkiValitsePostiNro";
            this.cmbUusiMokkiValitsePostiNro.Size = new System.Drawing.Size(148, 23);
            this.cmbUusiMokkiValitsePostiNro.TabIndex = 76;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkPostiNro);
            this.panel1.Controls.Add(this.checkAlueID);
            this.panel1.Controls.Add(this.btnSuoritaMokkienHaku);
            this.panel1.Controls.Add(this.btnHaeMokit);
            this.panel1.Controls.Add(this.btnLisaaMokinTiedot);
            this.panel1.Controls.Add(this.cmbUusiMokkiValitsePostiNro);
            this.panel1.Controls.Add(this.btnMuokkaaValitunMokinTietoja);
            this.panel1.Controls.Add(this.cmbUusiMokkiValitseAlueID);
            this.panel1.Controls.Add(this.lbl7);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.tbValittuMokkiHintaVrk);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Controls.Add(this.rtbValittuMokkiKuvaus);
            this.panel1.Controls.Add(this.rtbValittuMokkiVarustelu);
            this.panel1.Controls.Add(this.tbValittuMokkiHloMaara);
            this.panel1.Controls.Add(this.lbl5);
            this.panel1.Controls.Add(this.tbValittuMokkiNimi);
            this.panel1.Controls.Add(this.lbl9);
            this.panel1.Controls.Add(this.tbValittuMokkiOsoite);
            this.panel1.Controls.Add(this.lbl6);
            this.panel1.Controls.Add(this.tbValittuMokkiMokkiID);
            this.panel1.Controls.Add(this.lbl8);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 479);
            this.panel1.TabIndex = 0;
            // 
            // checkPostiNro
            // 
            this.checkPostiNro.AutoSize = true;
            this.checkPostiNro.Location = new System.Drawing.Point(67, 100);
            this.checkPostiNro.Name = "checkPostiNro";
            this.checkPostiNro.Size = new System.Drawing.Size(15, 14);
            this.checkPostiNro.TabIndex = 79;
            this.checkPostiNro.UseVisualStyleBackColor = true;
            this.checkPostiNro.Visible = false;
            this.checkPostiNro.CheckedChanged += new System.EventHandler(this.checkPostiNro_CheckedChanged);
            // 
            // checkAlueID
            // 
            this.checkAlueID.AutoSize = true;
            this.checkAlueID.Location = new System.Drawing.Point(67, 77);
            this.checkAlueID.Name = "checkAlueID";
            this.checkAlueID.Size = new System.Drawing.Size(15, 14);
            this.checkAlueID.TabIndex = 78;
            this.checkAlueID.UseVisualStyleBackColor = true;
            this.checkAlueID.Visible = false;
            this.checkAlueID.Click += new System.EventHandler(this.checkAlueID_Click);
            // 
            // btnSuoritaMokkienHaku
            // 
            this.btnSuoritaMokkienHaku.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSuoritaMokkienHaku.Enabled = false;
            this.btnSuoritaMokkienHaku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuoritaMokkienHaku.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuoritaMokkienHaku.Location = new System.Drawing.Point(203, 5);
            this.btnSuoritaMokkienHaku.Name = "btnSuoritaMokkienHaku";
            this.btnSuoritaMokkienHaku.Size = new System.Drawing.Size(31, 30);
            this.btnSuoritaMokkienHaku.TabIndex = 77;
            this.btnSuoritaMokkienHaku.Text = "L";
            this.btnSuoritaMokkienHaku.UseVisualStyleBackColor = false;
            this.btnSuoritaMokkienHaku.Visible = false;
            this.btnSuoritaMokkienHaku.Click += new System.EventHandler(this.btnSuoritaMokkienHaku_Click);
            // 
            // btnHaeMokit
            // 
            this.btnHaeMokit.BackColor = System.Drawing.Color.PeachPuff;
            this.btnHaeMokit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHaeMokit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHaeMokit.Location = new System.Drawing.Point(7, 5);
            this.btnHaeMokit.Name = "btnHaeMokit";
            this.btnHaeMokit.Size = new System.Drawing.Size(112, 30);
            this.btnHaeMokit.TabIndex = 73;
            this.btnHaeMokit.Text = "Hae mökkejä";
            this.btnHaeMokit.UseVisualStyleBackColor = false;
            this.btnHaeMokit.Click += new System.EventHandler(this.btnHaeMokit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(431, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 24);
            this.label2.TabIndex = 77;
            this.label2.Text = "H    Q    l    P    H    Q    l    P    H    Q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 24);
            this.label3.TabIndex = 78;
            this.label3.Text = "H    Q    l    P";
            // 
            // FormMokitJaMokkivaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1199, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMokkiPoista);
            this.Controls.Add(this.btnVaraaValittuMokki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgMokkiLista);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMokitJaMokkivaraukset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mökkien hallinta";
            ((System.ComponentModel.ISupportInitialize)(this.dgMokkiLista)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLisaaMokinTiedot;
        private Button btnMuokkaaValitunMokinTietoja;
        private Button btnMokkiPoista;
        private Button btnVaraaValittuMokki;
        private Label label5;
        private TextBox tbValittuMokkiHintaVrk;
        private RichTextBox rtbValittuMokkiVarustelu;
        private RichTextBox rtbValittuMokkiKuvaus;
        private TextBox tbValittuMokkiHloMaara;
        private Label lbl8;
        private Label lbl7;
        private Label lbl6;
        private TextBox tbValittuMokkiNimi;
        private TextBox tbValittuMokkiOsoite;
        private TextBox tbValittuMokkiMokkiID;
        private Label lbl9;
        private Label lbl5;
        private Label lbl4;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
        private DataGridView dgMokkiLista;
        private Panel panel2;
        private Label label1;
        private Label lblMokkiListaOhje;
        private Button btnTakaisinAloitusFormiin;
        private ComboBox cmbUusiMokkiValitseAlueID;
        private ComboBox cmbUusiMokkiValitsePostiNro;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Button btnHaeMokit;
        private Button btnSuoritaMokkienHaku;
        private CheckBox checkPostiNro;
        private CheckBox checkAlueID;
    }
}