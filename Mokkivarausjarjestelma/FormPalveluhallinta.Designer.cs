namespace Mokkivarausjarjestelma
{
    partial class FormPalveluhallinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPalveluhallinta));
            this.rtbPalvelukuvaus = new System.Windows.Forms.RichTextBox();
            this.tbPalvelualv = new System.Windows.Forms.TextBox();
            this.tbPalveluhinta = new System.Windows.Forms.TextBox();
            this.tbPalvelutyyppi = new System.Windows.Forms.TextBox();
            this.tbPalvelunimi = new System.Windows.Forms.TextBox();
            this.tbPalveluID = new System.Windows.Forms.TextBox();
            this.btnPalveluLisaa = new System.Windows.Forms.Button();
            this.btnPalveluPaivita = new System.Windows.Forms.Button();
            this.btnPalveluPoista = new System.Windows.Forms.Button();
            this.btnPalveluTyhj = new System.Windows.Forms.Button();
            this.lblHinta = new System.Windows.Forms.Label();
            this.lblAlv = new System.Windows.Forms.Label();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.lblTyyppi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPalveluID = new System.Windows.Forms.Label();
            this.dgvPalvelut = new System.Windows.Forms.DataGridView();
            this.tbAlueID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTakaisinAloitusFormiin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHae = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbPalvelukuvaus
            // 
            this.rtbPalvelukuvaus.Location = new System.Drawing.Point(94, 184);
            this.rtbPalvelukuvaus.Name = "rtbPalvelukuvaus";
            this.rtbPalvelukuvaus.Size = new System.Drawing.Size(197, 65);
            this.rtbPalvelukuvaus.TabIndex = 4;
            this.rtbPalvelukuvaus.Text = "";
            // 
            // tbPalvelualv
            // 
            this.tbPalvelualv.Location = new System.Drawing.Point(94, 299);
            this.tbPalvelualv.Name = "tbPalvelualv";
            this.tbPalvelualv.Size = new System.Drawing.Size(130, 23);
            this.tbPalvelualv.TabIndex = 6;
            // 
            // tbPalveluhinta
            // 
            this.tbPalveluhinta.Location = new System.Drawing.Point(94, 255);
            this.tbPalveluhinta.Name = "tbPalveluhinta";
            this.tbPalveluhinta.Size = new System.Drawing.Size(130, 23);
            this.tbPalveluhinta.TabIndex = 5;
            // 
            // tbPalvelutyyppi
            // 
            this.tbPalvelutyyppi.Location = new System.Drawing.Point(94, 143);
            this.tbPalvelutyyppi.Name = "tbPalvelutyyppi";
            this.tbPalvelutyyppi.Size = new System.Drawing.Size(130, 23);
            this.tbPalvelutyyppi.TabIndex = 3;
            // 
            // tbPalvelunimi
            // 
            this.tbPalvelunimi.Location = new System.Drawing.Point(94, 102);
            this.tbPalvelunimi.Name = "tbPalvelunimi";
            this.tbPalvelunimi.Size = new System.Drawing.Size(130, 23);
            this.tbPalvelunimi.TabIndex = 2;
            // 
            // tbPalveluID
            // 
            this.tbPalveluID.Location = new System.Drawing.Point(94, 22);
            this.tbPalveluID.Name = "tbPalveluID";
            this.tbPalveluID.Size = new System.Drawing.Size(130, 23);
            this.tbPalveluID.TabIndex = 0;
            // 
            // btnPalveluLisaa
            // 
            this.btnPalveluLisaa.BackColor = System.Drawing.Color.Turquoise;
            this.btnPalveluLisaa.Location = new System.Drawing.Point(11, 367);
            this.btnPalveluLisaa.Name = "btnPalveluLisaa";
            this.btnPalveluLisaa.Size = new System.Drawing.Size(75, 23);
            this.btnPalveluLisaa.TabIndex = 7;
            this.btnPalveluLisaa.Text = "Syötä";
            this.btnPalveluLisaa.UseVisualStyleBackColor = false;
            this.btnPalveluLisaa.Click += new System.EventHandler(this.btnPalveluLisaa_Click);
            // 
            // btnPalveluPaivita
            // 
            this.btnPalveluPaivita.BackColor = System.Drawing.Color.Turquoise;
            this.btnPalveluPaivita.Location = new System.Drawing.Point(110, 367);
            this.btnPalveluPaivita.Name = "btnPalveluPaivita";
            this.btnPalveluPaivita.Size = new System.Drawing.Size(75, 23);
            this.btnPalveluPaivita.TabIndex = 8;
            this.btnPalveluPaivita.Text = "Päivitä";
            this.btnPalveluPaivita.UseVisualStyleBackColor = false;
            this.btnPalveluPaivita.Click += new System.EventHandler(this.btnPalveluPaivita_Click);
            // 
            // btnPalveluPoista
            // 
            this.btnPalveluPoista.BackColor = System.Drawing.Color.Turquoise;
            this.btnPalveluPoista.Location = new System.Drawing.Point(216, 367);
            this.btnPalveluPoista.Name = "btnPalveluPoista";
            this.btnPalveluPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPalveluPoista.TabIndex = 9;
            this.btnPalveluPoista.Text = "Poista";
            this.btnPalveluPoista.UseVisualStyleBackColor = false;
            this.btnPalveluPoista.Click += new System.EventHandler(this.btnPalveluPoista_Click);
            // 
            // btnPalveluTyhj
            // 
            this.btnPalveluTyhj.BackColor = System.Drawing.Color.Turquoise;
            this.btnPalveluTyhj.Location = new System.Drawing.Point(14, 416);
            this.btnPalveluTyhj.Name = "btnPalveluTyhj";
            this.btnPalveluTyhj.Size = new System.Drawing.Size(134, 23);
            this.btnPalveluTyhj.TabIndex = 11;
            this.btnPalveluTyhj.Text = "Tyhjennä tekstikentät";
            this.btnPalveluTyhj.UseVisualStyleBackColor = false;
            this.btnPalveluTyhj.Click += new System.EventHandler(this.btnPalveluTyhj_Click);
            // 
            // lblHinta
            // 
            this.lblHinta.AutoSize = true;
            this.lblHinta.Location = new System.Drawing.Point(11, 258);
            this.lblHinta.Name = "lblHinta";
            this.lblHinta.Size = new System.Drawing.Size(53, 15);
            this.lblHinta.TabIndex = 23;
            this.lblHinta.Text = "Hinta (€)";
            // 
            // lblAlv
            // 
            this.lblAlv.AutoSize = true;
            this.lblAlv.Location = new System.Drawing.Point(14, 299);
            this.lblAlv.Name = "lblAlv";
            this.lblAlv.Size = new System.Drawing.Size(24, 15);
            this.lblAlv.TabIndex = 22;
            this.lblAlv.Text = "Alv";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Location = new System.Drawing.Point(14, 184);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(45, 15);
            this.lblKuvaus.TabIndex = 21;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // lblTyyppi
            // 
            this.lblTyyppi.AutoSize = true;
            this.lblTyyppi.Location = new System.Drawing.Point(14, 143);
            this.lblTyyppi.Name = "lblTyyppi";
            this.lblTyyppi.Size = new System.Drawing.Size(41, 15);
            this.lblTyyppi.TabIndex = 20;
            this.lblTyyppi.Text = "Tyyppi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nimi";
            // 
            // lblPalveluID
            // 
            this.lblPalveluID.AutoSize = true;
            this.lblPalveluID.Location = new System.Drawing.Point(14, 22);
            this.lblPalveluID.Name = "lblPalveluID";
            this.lblPalveluID.Size = new System.Drawing.Size(56, 15);
            this.lblPalveluID.TabIndex = 18;
            this.lblPalveluID.Text = "PalveluID";
            // 
            // dgvPalvelut
            // 
            this.dgvPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalvelut.Location = new System.Drawing.Point(343, 12);
            this.dgvPalvelut.Name = "dgvPalvelut";
            this.dgvPalvelut.RowHeadersWidth = 51;
            this.dgvPalvelut.RowTemplate.Height = 25;
            this.dgvPalvelut.Size = new System.Drawing.Size(587, 386);
            this.dgvPalvelut.TabIndex = 17;
            this.dgvPalvelut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPalvelut_MouseClick);
            // 
            // tbAlueID
            // 
            this.tbAlueID.Location = new System.Drawing.Point(94, 64);
            this.tbAlueID.Name = "tbAlueID";
            this.tbAlueID.Size = new System.Drawing.Size(130, 23);
            this.tbAlueID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "AlueID";
            // 
            // btnTakaisinAloitusFormiin
            // 
            this.btnTakaisinAloitusFormiin.BackColor = System.Drawing.Color.Turquoise;
            this.btnTakaisinAloitusFormiin.Location = new System.Drawing.Point(11, 558);
            this.btnTakaisinAloitusFormiin.Name = "btnTakaisinAloitusFormiin";
            this.btnTakaisinAloitusFormiin.Size = new System.Drawing.Size(137, 23);
            this.btnTakaisinAloitusFormiin.TabIndex = 12;
            this.btnTakaisinAloitusFormiin.Text = "Takaisin aloitussivulle";
            this.btnTakaisinAloitusFormiin.UseVisualStyleBackColor = false;
            this.btnTakaisinAloitusFormiin.Click += new System.EventHandler(this.btnTakaisinAloitusFormiin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(540, 150);
            this.label3.TabIndex = 77;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(343, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 78;
            this.label4.Text = "KÄYTTÖOHJE!";
            // 
            // btnHae
            // 
            this.btnHae.BackColor = System.Drawing.Color.Turquoise;
            this.btnHae.Location = new System.Drawing.Point(240, 16);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(49, 32);
            this.btnHae.TabIndex = 10;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = false;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // FormPalveluhallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(942, 593);
            this.Controls.Add(this.btnHae);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTakaisinAloitusFormiin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAlueID);
            this.Controls.Add(this.rtbPalvelukuvaus);
            this.Controls.Add(this.tbPalvelualv);
            this.Controls.Add(this.tbPalveluhinta);
            this.Controls.Add(this.tbPalvelutyyppi);
            this.Controls.Add(this.tbPalvelunimi);
            this.Controls.Add(this.tbPalveluID);
            this.Controls.Add(this.btnPalveluLisaa);
            this.Controls.Add(this.btnPalveluPaivita);
            this.Controls.Add(this.btnPalveluPoista);
            this.Controls.Add(this.btnPalveluTyhj);
            this.Controls.Add(this.lblHinta);
            this.Controls.Add(this.lblAlv);
            this.Controls.Add(this.lblKuvaus);
            this.Controls.Add(this.lblTyyppi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPalveluID);
            this.Controls.Add(this.dgvPalvelut);
            this.Name = "FormPalveluhallinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.Load += new System.EventHandler(this.FormPalveluhallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtbPalvelukuvaus;
        private TextBox tbPalvelualv;
        private TextBox tbPalveluhinta;
        private TextBox tbPalvelutyyppi;
        private TextBox tbPalvelunimi;
        private TextBox tbPalveluID;
        private Button btnPalveluLisaa;
        private Button btnPalveluPaivita;
        private Button btnPalveluPoista;
        private Button btnPalveluTyhj;
        private Label lblHinta;
        private Label lblAlv;
        private Label lblKuvaus;
        private Label lblTyyppi;
        private Label label2;
        private Label lblPalveluID;
        private DataGridView dgvPalvelut;
        private TextBox tbAlueID;
        private Label label1;
        private Button btnTakaisinAloitusFormiin;
        private Label label3;
        private Label label4;
        private Button btnHae;
    }
}