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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnLasku = new System.Windows.Forms.Button();
            this.btnPalvelu = new System.Windows.Forms.Button();
            this.btnAsiakas = new System.Windows.Forms.Button();
            this.btnToiminta = new System.Windows.Forms.Button();
            this.btnMokkivaraus = new System.Windows.Forms.Button();
            this.tbpgAsiakashallinta = new System.Windows.Forms.TabPage();
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
            this.tbpgPalveluhallinta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalvelut)).BeginInit();
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
            this.tbpgAsiakashallinta.Location = new System.Drawing.Point(4, 24);
            this.tbpgAsiakashallinta.Name = "tbpgAsiakashallinta";
            this.tbpgAsiakashallinta.Padding = new System.Windows.Forms.Padding(2);
            this.tbpgAsiakashallinta.Size = new System.Drawing.Size(952, 743);
            this.tbpgAsiakashallinta.TabIndex = 1;
            this.tbpgAsiakashallinta.Text = "Asiakashallinta";
            this.tbpgAsiakashallinta.UseVisualStyleBackColor = true;
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
            this.dgvPalvelut.RowTemplate.Height = 25;
            this.dgvPalvelut.Size = new System.Drawing.Size(587, 386);
            this.dgvPalvelut.TabIndex = 0;
            // 
            // tbpgMokkivaraushallinta
            // 
            this.tbpgMokkivaraushallinta.Location = new System.Drawing.Point(4, 24);
            this.tbpgMokkivaraushallinta.Name = "tbpgMokkivaraushallinta";
            this.tbpgMokkivaraushallinta.Padding = new System.Windows.Forms.Padding(2);
            this.tbpgMokkivaraushallinta.Size = new System.Drawing.Size(952, 743);
            this.tbpgMokkivaraushallinta.TabIndex = 3;
            this.tbpgMokkivaraushallinta.Text = "Mökkivarausten hallinta";
            this.tbpgMokkivaraushallinta.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 630);
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
    }
}