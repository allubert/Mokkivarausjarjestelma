namespace Mokkivarausjarjestelma
{
    partial class FormToiminta
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
            this.pnlToiminta = new System.Windows.Forms.Panel();
            this.lblToimintaOtsikko = new System.Windows.Forms.Label();
            this.lblToimintaAlue = new System.Windows.Forms.Label();
            this.tbToimintaAlue = new System.Windows.Forms.TextBox();
            this.btnToimintaKohteet = new System.Windows.Forms.Button();
            this.dgvToiminta = new System.Windows.Forms.DataGridView();
            this.btnToimintaPoistaAlue = new System.Windows.Forms.Button();
            this.btnToimintaLisaaAlue = new System.Windows.Forms.Button();
            this.btnTakaisinAloitusFormiin = new System.Windows.Forms.Button();
            this.pnlToiminta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToiminta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlToiminta
            // 
            this.pnlToiminta.Controls.Add(this.lblToimintaOtsikko);
            this.pnlToiminta.Controls.Add(this.lblToimintaAlue);
            this.pnlToiminta.Controls.Add(this.tbToimintaAlue);
            this.pnlToiminta.Location = new System.Drawing.Point(2, 51);
            this.pnlToiminta.Name = "pnlToiminta";
            this.pnlToiminta.Size = new System.Drawing.Size(223, 344);
            this.pnlToiminta.TabIndex = 23;
            // 
            // lblToimintaOtsikko
            // 
            this.lblToimintaOtsikko.AutoSize = true;
            this.lblToimintaOtsikko.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToimintaOtsikko.Location = new System.Drawing.Point(10, 0);
            this.lblToimintaOtsikko.Name = "lblToimintaOtsikko";
            this.lblToimintaOtsikko.Size = new System.Drawing.Size(203, 37);
            this.lblToimintaOtsikko.TabIndex = 18;
            this.lblToimintaOtsikko.Text = "Toiminta-alueet";
            // 
            // lblToimintaAlue
            // 
            this.lblToimintaAlue.AutoSize = true;
            this.lblToimintaAlue.Location = new System.Drawing.Point(3, 65);
            this.lblToimintaAlue.Name = "lblToimintaAlue";
            this.lblToimintaAlue.Size = new System.Drawing.Size(120, 15);
            this.lblToimintaAlue.TabIndex = 17;
            this.lblToimintaAlue.Text = "Toiminta-alueen nimi";
            // 
            // tbToimintaAlue
            // 
            this.tbToimintaAlue.Location = new System.Drawing.Point(6, 83);
            this.tbToimintaAlue.Name = "tbToimintaAlue";
            this.tbToimintaAlue.Size = new System.Drawing.Size(199, 23);
            this.tbToimintaAlue.TabIndex = 2;
            // 
            // btnToimintaKohteet
            // 
            this.btnToimintaKohteet.BackColor = System.Drawing.Color.Bisque;
            this.btnToimintaKohteet.Location = new System.Drawing.Point(8, 492);
            this.btnToimintaKohteet.Name = "btnToimintaKohteet";
            this.btnToimintaKohteet.Size = new System.Drawing.Size(94, 42);
            this.btnToimintaKohteet.TabIndex = 5;
            this.btnToimintaKohteet.Text = "Näytä kohteet";
            this.btnToimintaKohteet.UseVisualStyleBackColor = false;
            this.btnToimintaKohteet.Click += new System.EventHandler(this.btnToimintaKohteet_Click);
            // 
            // dgvToiminta
            // 
            this.dgvToiminta.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvToiminta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToiminta.Location = new System.Drawing.Point(252, 30);
            this.dgvToiminta.Name = "dgvToiminta";
            this.dgvToiminta.RowHeadersWidth = 51;
            this.dgvToiminta.RowTemplate.Height = 25;
            this.dgvToiminta.Size = new System.Drawing.Size(696, 450);
            this.dgvToiminta.TabIndex = 7;
            this.dgvToiminta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvToiminta_MouseClick);
            // 
            // btnToimintaPoistaAlue
            // 
            this.btnToimintaPoistaAlue.BackColor = System.Drawing.Color.Bisque;
            this.btnToimintaPoistaAlue.Location = new System.Drawing.Point(116, 444);
            this.btnToimintaPoistaAlue.Name = "btnToimintaPoistaAlue";
            this.btnToimintaPoistaAlue.Size = new System.Drawing.Size(99, 42);
            this.btnToimintaPoistaAlue.TabIndex = 4;
            this.btnToimintaPoistaAlue.Text = "Poista toiminta-alue";
            this.btnToimintaPoistaAlue.UseVisualStyleBackColor = false;
            this.btnToimintaPoistaAlue.Click += new System.EventHandler(this.btnToimintaPoistaAlue_Click);
            // 
            // btnToimintaLisaaAlue
            // 
            this.btnToimintaLisaaAlue.BackColor = System.Drawing.Color.Bisque;
            this.btnToimintaLisaaAlue.Location = new System.Drawing.Point(10, 444);
            this.btnToimintaLisaaAlue.Name = "btnToimintaLisaaAlue";
            this.btnToimintaLisaaAlue.Size = new System.Drawing.Size(94, 42);
            this.btnToimintaLisaaAlue.TabIndex = 3;
            this.btnToimintaLisaaAlue.Text = "Lisää toiminta-alue";
            this.btnToimintaLisaaAlue.UseVisualStyleBackColor = false;
            this.btnToimintaLisaaAlue.Click += new System.EventHandler(this.btnToimintaLisaaAlue_Click);
            // 
            // btnTakaisinAloitusFormiin
            // 
            this.btnTakaisinAloitusFormiin.BackColor = System.Drawing.Color.Bisque;
            this.btnTakaisinAloitusFormiin.Location = new System.Drawing.Point(116, 493);
            this.btnTakaisinAloitusFormiin.Name = "btnTakaisinAloitusFormiin";
            this.btnTakaisinAloitusFormiin.Size = new System.Drawing.Size(99, 41);
            this.btnTakaisinAloitusFormiin.TabIndex = 6;
            this.btnTakaisinAloitusFormiin.Text = "Takaisin aloitussivulle";
            this.btnTakaisinAloitusFormiin.UseVisualStyleBackColor = false;
            this.btnTakaisinAloitusFormiin.Click += new System.EventHandler(this.btnTakaisinAloitusFormiin_Click);
            // 
            // FormToiminta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(960, 626);
            this.Controls.Add(this.btnTakaisinAloitusFormiin);
            this.Controls.Add(this.pnlToiminta);
            this.Controls.Add(this.btnToimintaKohteet);
            this.Controls.Add(this.dgvToiminta);
            this.Controls.Add(this.btnToimintaPoistaAlue);
            this.Controls.Add(this.btnToimintaLisaaAlue);
            this.Name = "FormToiminta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormToiminta";
            this.Load += new System.EventHandler(this.FormToiminta_Load);
            this.pnlToiminta.ResumeLayout(false);
            this.pnlToiminta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToiminta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlToiminta;
        private Label lblToimintaOtsikko;
        private Label lblToimintaAlue;
        private TextBox tbToimintaAlue;
        private Button btnToimintaKohteet;
        private DataGridView dgvToiminta;
        private Button btnToimintaPoistaAlue;
        private Button btnToimintaLisaaAlue;
        private Button btnTakaisinAloitusFormiin;
    }
}