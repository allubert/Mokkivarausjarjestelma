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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbValittuMokkiNimi = new System.Windows.Forms.TextBox();
            this.tbValittuMokkiOsoite = new System.Windows.Forms.TextBox();
            this.tbValittuMokkiPostiNro = new System.Windows.Forms.TextBox();
            this.tbValittuMokkiMokkiID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMokkiID = new System.Windows.Forms.Label();
            this.dgMokkiLista = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMokkiListaOhje = new System.Windows.Forms.Label();
            this.btnTakaisinAloitusFormiin = new System.Windows.Forms.Button();
            this.cmbUusiMokkiValitseAlueID = new System.Windows.Forms.ComboBox();
            this.cmbUusiMokkiValitsePostiNro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMokkiLista)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLisaaMokinTiedot
            // 
            this.btnLisaaMokinTiedot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLisaaMokinTiedot.Location = new System.Drawing.Point(15, 433);
            this.btnLisaaMokinTiedot.Name = "btnLisaaMokinTiedot";
            this.btnLisaaMokinTiedot.Size = new System.Drawing.Size(226, 30);
            this.btnLisaaMokinTiedot.TabIndex = 56;
            this.btnLisaaMokinTiedot.Text = "Lisää mökin tiedot";
            this.btnLisaaMokinTiedot.UseVisualStyleBackColor = true;
            this.btnLisaaMokinTiedot.Click += new System.EventHandler(this.btnLisaaMokinTiedot_Click);
            // 
            // btnMuokkaaValitunMokinTietoja
            // 
            this.btnMuokkaaValitunMokinTietoja.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMuokkaaValitunMokinTietoja.Location = new System.Drawing.Point(15, 396);
            this.btnMuokkaaValitunMokinTietoja.Name = "btnMuokkaaValitunMokinTietoja";
            this.btnMuokkaaValitunMokinTietoja.Size = new System.Drawing.Size(72, 30);
            this.btnMuokkaaValitunMokinTietoja.TabIndex = 61;
            this.btnMuokkaaValitunMokinTietoja.Text = "Muokkaa";
            this.btnMuokkaaValitunMokinTietoja.UseVisualStyleBackColor = true;
            this.btnMuokkaaValitunMokinTietoja.Click += new System.EventHandler(this.btnMuokkaaValitunMokinTietoja_Click);
            // 
            // btnMokkiPoista
            // 
            this.btnMokkiPoista.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMokkiPoista.Location = new System.Drawing.Point(1006, 468);
            this.btnMokkiPoista.Name = "btnMokkiPoista";
            this.btnMokkiPoista.Size = new System.Drawing.Size(187, 30);
            this.btnMokkiPoista.TabIndex = 60;
            this.btnMokkiPoista.Text = "Poista mökki tietokannasta";
            this.btnMokkiPoista.UseVisualStyleBackColor = true;
            this.btnMokkiPoista.Click += new System.EventHandler(this.btnPoistaValittuMokkiListalta_Click);
            // 
            // btnVaraaValittuMokki
            // 
            this.btnVaraaValittuMokki.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVaraaValittuMokki.Location = new System.Drawing.Point(349, 468);
            this.btnVaraaValittuMokki.Name = "btnVaraaValittuMokki";
            this.btnVaraaValittuMokki.Size = new System.Drawing.Size(99, 30);
            this.btnVaraaValittuMokki.TabIndex = 57;
            this.btnVaraaValittuMokki.Text = "Uusi Varaus";
            this.btnVaraaValittuMokki.UseVisualStyleBackColor = true;
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
            this.tbValittuMokkiHintaVrk.Location = new System.Drawing.Point(93, 151);
            this.tbValittuMokkiHintaVrk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiHintaVrk.Name = "tbValittuMokkiHintaVrk";
            this.tbValittuMokkiHintaVrk.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiHintaVrk.TabIndex = 52;
            // 
            // rtbValittuMokkiVarustelu
            // 
            this.rtbValittuMokkiVarustelu.Location = new System.Drawing.Point(93, 308);
            this.rtbValittuMokkiVarustelu.Name = "rtbValittuMokkiVarustelu";
            this.rtbValittuMokkiVarustelu.Size = new System.Drawing.Size(148, 118);
            this.rtbValittuMokkiVarustelu.TabIndex = 55;
            this.rtbValittuMokkiVarustelu.Text = "";
            // 
            // rtbValittuMokkiKuvaus
            // 
            this.rtbValittuMokkiKuvaus.Location = new System.Drawing.Point(93, 173);
            this.rtbValittuMokkiKuvaus.Name = "rtbValittuMokkiKuvaus";
            this.rtbValittuMokkiKuvaus.Size = new System.Drawing.Size(148, 112);
            this.rtbValittuMokkiKuvaus.TabIndex = 53;
            this.rtbValittuMokkiKuvaus.Text = "";
            // 
            // tbValittuMokkiHloMaara
            // 
            this.tbValittuMokkiHloMaara.Location = new System.Drawing.Point(93, 285);
            this.tbValittuMokkiHloMaara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiHloMaara.Name = "tbValittuMokkiHloMaara";
            this.tbValittuMokkiHloMaara.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiHloMaara.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 72;
            this.label11.Text = "Henkilömäärä";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 173);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 71;
            this.label12.Text = "Kuvaus";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(12, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 25);
            this.label13.TabIndex = 69;
            this.label13.Text = "Hinta (/vrk)";
            // 
            // tbValittuMokkiNimi
            // 
            this.tbValittuMokkiNimi.Location = new System.Drawing.Point(93, 105);
            this.tbValittuMokkiNimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiNimi.Name = "tbValittuMokkiNimi";
            this.tbValittuMokkiNimi.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiNimi.TabIndex = 50;
            // 
            // tbValittuMokkiOsoite
            // 
            this.tbValittuMokkiOsoite.Location = new System.Drawing.Point(93, 128);
            this.tbValittuMokkiOsoite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiOsoite.Name = "tbValittuMokkiOsoite";
            this.tbValittuMokkiOsoite.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiOsoite.TabIndex = 51;
            // 
            // tbValittuMokkiPostiNro
            // 
            this.tbValittuMokkiPostiNro.Location = new System.Drawing.Point(461, 27);
            this.tbValittuMokkiPostiNro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiPostiNro.Name = "tbValittuMokkiPostiNro";
            this.tbValittuMokkiPostiNro.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiPostiNro.TabIndex = 49;
            // 
            // tbValittuMokkiMokkiID
            // 
            this.tbValittuMokkiMokkiID.Location = new System.Drawing.Point(93, 34);
            this.tbValittuMokkiMokkiID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiMokkiID.Name = "tbValittuMokkiMokkiID";
            this.tbValittuMokkiMokkiID.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiMokkiID.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 45);
            this.label6.TabIndex = 70;
            this.label6.Text = "Varustelu";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 68;
            this.label7.Text = "Lähiosoite";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 105);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 67;
            this.label8.Text = "Mökin nimi";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 66;
            this.label9.Text = "Postinro";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 21);
            this.label10.TabIndex = 65;
            this.label10.Text = "Alue_ID";
            // 
            // lblMokkiID
            // 
            this.lblMokkiID.Location = new System.Drawing.Point(12, 34);
            this.lblMokkiID.Name = "lblMokkiID";
            this.lblMokkiID.Size = new System.Drawing.Size(88, 24);
            this.lblMokkiID.TabIndex = 64;
            this.lblMokkiID.Text = "Mokki_ID";
            // 
            // dgMokkiLista
            // 
            this.dgMokkiLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMokkiLista.Location = new System.Drawing.Point(250, 13);
            this.dgMokkiLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgMokkiLista.Name = "dgMokkiLista";
            this.dgMokkiLista.ReadOnly = true;
            this.dgMokkiLista.RowHeadersWidth = 51;
            this.dgMokkiLista.RowTemplate.Height = 29;
            this.dgMokkiLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMokkiLista.Size = new System.Drawing.Size(943, 450);
            this.dgMokkiLista.TabIndex = 62;
            this.dgMokkiLista.SelectionChanged += new System.EventHandler(this.dgMokkiLista_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblMokkiListaOhje);
            this.panel2.Controls.Add(this.tbValittuMokkiPostiNro);
            this.panel2.Location = new System.Drawing.Point(4, 504);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1189, 119);
            this.panel2.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "HUOMIO!";
            // 
            // lblMokkiListaOhje
            // 
            this.lblMokkiListaOhje.AutoSize = true;
            this.lblMokkiListaOhje.Location = new System.Drawing.Point(3, 25);
            this.lblMokkiListaOhje.Name = "lblMokkiListaOhje";
            this.lblMokkiListaOhje.Size = new System.Drawing.Size(631, 30);
            this.lblMokkiListaOhje.TabIndex = 43;
            this.lblMokkiListaOhje.Text = resources.GetString("lblMokkiListaOhje.Text");
            // 
            // btnTakaisinAloitusFormiin
            // 
            this.btnTakaisinAloitusFormiin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTakaisinAloitusFormiin.Location = new System.Drawing.Point(250, 468);
            this.btnTakaisinAloitusFormiin.Name = "btnTakaisinAloitusFormiin";
            this.btnTakaisinAloitusFormiin.Size = new System.Drawing.Size(93, 30);
            this.btnTakaisinAloitusFormiin.TabIndex = 74;
            this.btnTakaisinAloitusFormiin.Text = "Alkuvalikko";
            this.btnTakaisinAloitusFormiin.UseVisualStyleBackColor = true;
            this.btnTakaisinAloitusFormiin.Click += new System.EventHandler(this.btnTakaisinAloitusFormiin_Click);
            // 
            // cmbUusiMokkiValitseAlueID
            // 
            this.cmbUusiMokkiValitseAlueID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUusiMokkiValitseAlueID.FormattingEnabled = true;
            this.cmbUusiMokkiValitseAlueID.Location = new System.Drawing.Point(93, 59);
            this.cmbUusiMokkiValitseAlueID.Name = "cmbUusiMokkiValitseAlueID";
            this.cmbUusiMokkiValitseAlueID.Size = new System.Drawing.Size(148, 23);
            this.cmbUusiMokkiValitseAlueID.TabIndex = 75;
            // 
            // cmbUusiMokkiValitsePostiNro
            // 
            this.cmbUusiMokkiValitsePostiNro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUusiMokkiValitsePostiNro.FormattingEnabled = true;
            this.cmbUusiMokkiValitsePostiNro.Location = new System.Drawing.Point(93, 82);
            this.cmbUusiMokkiValitsePostiNro.Name = "cmbUusiMokkiValitsePostiNro";
            this.cmbUusiMokkiValitsePostiNro.Size = new System.Drawing.Size(148, 23);
            this.cmbUusiMokkiValitsePostiNro.TabIndex = 76;
            // 
            // FormMokitJaMokkivaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 626);
            this.Controls.Add(this.cmbUusiMokkiValitsePostiNro);
            this.Controls.Add(this.cmbUusiMokkiValitseAlueID);
            this.Controls.Add(this.btnTakaisinAloitusFormiin);
            this.Controls.Add(this.btnLisaaMokinTiedot);
            this.Controls.Add(this.btnMuokkaaValitunMokinTietoja);
            this.Controls.Add(this.btnMokkiPoista);
            this.Controls.Add(this.btnVaraaValittuMokki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbValittuMokkiHintaVrk);
            this.Controls.Add(this.rtbValittuMokkiVarustelu);
            this.Controls.Add(this.rtbValittuMokkiKuvaus);
            this.Controls.Add(this.tbValittuMokkiHloMaara);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbValittuMokkiNimi);
            this.Controls.Add(this.tbValittuMokkiOsoite);
            this.Controls.Add(this.tbValittuMokkiMokkiID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblMokkiID);
            this.Controls.Add(this.dgMokkiLista);
            this.Controls.Add(this.panel2);
            this.Name = "FormMokitJaMokkivaraukset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMokitJaMokkivaraukset";
            ((System.ComponentModel.ISupportInitialize)(this.dgMokkiLista)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox tbValittuMokkiNimi;
        private TextBox tbValittuMokkiOsoite;
        private TextBox tbValittuMokkiPostiNro;
        private TextBox tbValittuMokkiMokkiID;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblMokkiID;
        private DataGridView dgMokkiLista;
        private Panel panel2;
        private Label label1;
        private Label lblMokkiListaOhje;
        private Button btnTakaisinAloitusFormiin;
        private ComboBox cmbUusiMokkiValitseAlueID;
        private ComboBox cmbUusiMokkiValitsePostiNro;
    }
}