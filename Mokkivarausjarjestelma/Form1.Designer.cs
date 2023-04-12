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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLasku = new System.Windows.Forms.Button();
            this.btnAsiakas = new System.Windows.Forms.Button();
            this.btnMokkivaraus = new System.Windows.Forms.Button();
            this.btnToiminta = new System.Windows.Forms.Button();
            this.btnPalvelu = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 771);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLasku);
            this.tabPage1.Controls.Add(this.btnAsiakas);
            this.tabPage1.Controls.Add(this.btnMokkivaraus);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 743);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 743);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLasku
            // 
            this.btnLasku.Location = new System.Drawing.Point(351, 578);
            this.btnLasku.Name = "btnLasku";
            this.btnLasku.Size = new System.Drawing.Size(260, 75);
            this.btnLasku.TabIndex = 10;
            this.btnLasku.Text = "Laskujen hallinta";
            this.btnLasku.UseVisualStyleBackColor = true;
            // 
            // btnAsiakas
            // 
            this.btnAsiakas.Location = new System.Drawing.Point(351, 480);
            this.btnAsiakas.Name = "btnAsiakas";
            this.btnAsiakas.Size = new System.Drawing.Size(260, 75);
            this.btnAsiakas.TabIndex = 9;
            this.btnAsiakas.Text = "Asiakashallinta";
            this.btnAsiakas.UseVisualStyleBackColor = true;
            // 
            // btnMokkivaraus
            // 
            this.btnMokkivaraus.Location = new System.Drawing.Point(351, 383);
            this.btnMokkivaraus.Name = "btnMokkivaraus";
            this.btnMokkivaraus.Size = new System.Drawing.Size(260, 75);
            this.btnMokkivaraus.TabIndex = 8;
            this.btnMokkivaraus.Text = "Mökkivarausten hallinta";
            this.btnMokkivaraus.UseVisualStyleBackColor = true;
            // 
            // btnToiminta
            // 
            this.btnToiminta.Location = new System.Drawing.Point(88, 131);
            this.btnToiminta.Name = "btnToiminta";
            this.btnToiminta.Size = new System.Drawing.Size(260, 75);
            this.btnToiminta.TabIndex = 0;
            this.btnToiminta.Text = "Toiminta-alueiden hallinta";
            this.btnToiminta.UseVisualStyleBackColor = true;
            // 
            // btnPalvelu
            // 
            this.btnPalvelu.Location = new System.Drawing.Point(88, 225);
            this.btnPalvelu.Name = "btnPalvelu";
            this.btnPalvelu.Size = new System.Drawing.Size(260, 75);
            this.btnPalvelu.TabIndex = 1;
            this.btnPalvelu.Text = "Palveluiden hallinta";
            this.btnPalvelu.UseVisualStyleBackColor = true;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("TI-Nspire Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTittle.Location = new System.Drawing.Point(6, 4);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(413, 98);
            this.lblTittle.TabIndex = 5;
            this.lblTittle.Text = "Mökkivarausjärjestelmä\r\n    Village Newbies Oy\r\n";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTittle);
            this.panel1.Controls.Add(this.btnPalvelu);
            this.panel1.Controls.Add(this.btnToiminta);
            this.panel1.Location = new System.Drawing.Point(264, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 632);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 769);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mökkivarausjärjestelmä - Village Newbies Oy";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnLasku;
        private Button btnAsiakas;
        private Button btnMokkivaraus;
        private Panel panel1;
        private Label lblTittle;
        private Button btnPalvelu;
        private Button btnToiminta;
        private TabPage tabPage2;
    }
}