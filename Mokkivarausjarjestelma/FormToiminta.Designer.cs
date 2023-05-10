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
            this.lblToimintaPostinro = new System.Windows.Forms.Label();
            this.tbToimintaPostinro = new System.Windows.Forms.TextBox();
            this.tbToimintaPostitoimi = new System.Windows.Forms.TextBox();
            this.lblToimintaPostitoimip = new System.Windows.Forms.Label();
            this.dgvToimintaPosti = new System.Windows.Forms.DataGridView();
            this.btnToimintaPoistaPostinro = new System.Windows.Forms.Button();
            this.btnToimintaLisaaPostinro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlToiminta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToiminta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimintaPosti)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.pnlToiminta.TabIndex = 0;
            // 
            // lblToimintaOtsikko
            // 
            this.lblToimintaOtsikko.AutoSize = true;
            this.lblToimintaOtsikko.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToimintaOtsikko.Location = new System.Drawing.Point(10, 0);
            this.lblToimintaOtsikko.Name = "lblToimintaOtsikko";
            this.lblToimintaOtsikko.Size = new System.Drawing.Size(203, 37);
            this.lblToimintaOtsikko.TabIndex = 0;
            this.lblToimintaOtsikko.Text = "Toiminta-alueet";
            // 
            // lblToimintaAlue
            // 
            this.lblToimintaAlue.AutoSize = true;
            this.lblToimintaAlue.Location = new System.Drawing.Point(3, 65);
            this.lblToimintaAlue.Name = "lblToimintaAlue";
            this.lblToimintaAlue.Size = new System.Drawing.Size(120, 15);
            this.lblToimintaAlue.TabIndex = 0;
            this.lblToimintaAlue.Text = "Toiminta-alueen nimi";
            // 
            // tbToimintaAlue
            // 
            this.tbToimintaAlue.Location = new System.Drawing.Point(6, 83);
            this.tbToimintaAlue.Name = "tbToimintaAlue";
            this.tbToimintaAlue.Size = new System.Drawing.Size(199, 23);
            this.tbToimintaAlue.TabIndex = 2;
            this.tbToimintaAlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbToimintaAlue_KeyPress);
            // 
            // btnToimintaKohteet
            // 
            this.btnToimintaKohteet.BackColor = System.Drawing.Color.Bisque;
            this.btnToimintaKohteet.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToimintaKohteet.Location = new System.Drawing.Point(231, 521);
            this.btnToimintaKohteet.Name = "btnToimintaKohteet";
            this.btnToimintaKohteet.Size = new System.Drawing.Size(251, 93);
            this.btnToimintaKohteet.TabIndex = 7;
            this.btnToimintaKohteet.Text = "Näytä kohteet";
            this.btnToimintaKohteet.UseVisualStyleBackColor = false;
            this.btnToimintaKohteet.Click += new System.EventHandler(this.btnToimintaKohteet_Click);
            // 
            // dgvToiminta
            // 
            this.dgvToiminta.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvToiminta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToiminta.Location = new System.Drawing.Point(231, 36);
            this.dgvToiminta.Name = "dgvToiminta";
            this.dgvToiminta.ReadOnly = true;
            this.dgvToiminta.RowHeadersWidth = 51;
            this.dgvToiminta.RowTemplate.Height = 25;
            this.dgvToiminta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToiminta.Size = new System.Drawing.Size(251, 450);
            this.dgvToiminta.TabIndex = 99;
            this.dgvToiminta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvToiminta_MouseClick);
            // 
            // btnToimintaPoistaAlue
            // 
            this.btnToimintaPoistaAlue.BackColor = System.Drawing.Color.Bisque;
            this.btnToimintaPoistaAlue.Location = new System.Drawing.Point(116, 444);
            this.btnToimintaPoistaAlue.Name = "btnToimintaPoistaAlue";
            this.btnToimintaPoistaAlue.Size = new System.Drawing.Size(99, 42);
            this.btnToimintaPoistaAlue.TabIndex = 2;
            this.btnToimintaPoistaAlue.Text = "Poista rivi";
            this.btnToimintaPoistaAlue.UseVisualStyleBackColor = false;
            this.btnToimintaPoistaAlue.Click += new System.EventHandler(this.btnToimintaPoistaAlue_Click);
            // 
            // btnToimintaLisaaAlue
            // 
            this.btnToimintaLisaaAlue.BackColor = System.Drawing.Color.Bisque;
            this.btnToimintaLisaaAlue.Location = new System.Drawing.Point(10, 444);
            this.btnToimintaLisaaAlue.Name = "btnToimintaLisaaAlue";
            this.btnToimintaLisaaAlue.Size = new System.Drawing.Size(94, 42);
            this.btnToimintaLisaaAlue.TabIndex = 1;
            this.btnToimintaLisaaAlue.Text = "Lisää toiminta-alue";
            this.btnToimintaLisaaAlue.UseVisualStyleBackColor = false;
            this.btnToimintaLisaaAlue.Click += new System.EventHandler(this.btnToimintaLisaaAlue_Click);
            // 
            // btnTakaisinAloitusFormiin
            // 
            this.btnTakaisinAloitusFormiin.BackColor = System.Drawing.Color.Bisque;
            this.btnTakaisinAloitusFormiin.Location = new System.Drawing.Point(849, 573);
            this.btnTakaisinAloitusFormiin.Name = "btnTakaisinAloitusFormiin";
            this.btnTakaisinAloitusFormiin.Size = new System.Drawing.Size(99, 41);
            this.btnTakaisinAloitusFormiin.TabIndex = 8;
            this.btnTakaisinAloitusFormiin.Text = "Alkuvalikko";
            this.btnTakaisinAloitusFormiin.UseVisualStyleBackColor = false;
            this.btnTakaisinAloitusFormiin.Click += new System.EventHandler(this.btnTakaisinAloitusFormiin_Click);
            // 
            // lblToimintaPostinro
            // 
            this.lblToimintaPostinro.AutoSize = true;
            this.lblToimintaPostinro.Location = new System.Drawing.Point(3, 44);
            this.lblToimintaPostinro.Name = "lblToimintaPostinro";
            this.lblToimintaPostinro.Size = new System.Drawing.Size(75, 15);
            this.lblToimintaPostinro.TabIndex = 24;
            this.lblToimintaPostinro.Text = "Postinumero";
            // 
            // tbToimintaPostinro
            // 
            this.tbToimintaPostinro.Location = new System.Drawing.Point(3, 62);
            this.tbToimintaPostinro.Name = "tbToimintaPostinro";
            this.tbToimintaPostinro.Size = new System.Drawing.Size(197, 23);
            this.tbToimintaPostinro.TabIndex = 0;
            this.tbToimintaPostinro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbToimintaPostinro_KeyPress);
            // 
            // tbToimintaPostitoimi
            // 
            this.tbToimintaPostitoimi.Location = new System.Drawing.Point(3, 106);
            this.tbToimintaPostitoimi.Name = "tbToimintaPostitoimi";
            this.tbToimintaPostitoimi.Size = new System.Drawing.Size(197, 23);
            this.tbToimintaPostitoimi.TabIndex = 1;
            this.tbToimintaPostitoimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbToimintaPostitoimi_KeyPress);
            // 
            // lblToimintaPostitoimip
            // 
            this.lblToimintaPostitoimip.AutoSize = true;
            this.lblToimintaPostitoimip.Location = new System.Drawing.Point(3, 88);
            this.lblToimintaPostitoimip.Name = "lblToimintaPostitoimip";
            this.lblToimintaPostitoimip.Size = new System.Drawing.Size(95, 15);
            this.lblToimintaPostitoimip.TabIndex = 27;
            this.lblToimintaPostitoimip.Text = "Postitoimipaikka";
            // 
            // dgvToimintaPosti
            // 
            this.dgvToimintaPosti.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvToimintaPosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToimintaPosti.Location = new System.Drawing.Point(697, 36);
            this.dgvToimintaPosti.Name = "dgvToimintaPosti";
            this.dgvToimintaPosti.ReadOnly = true;
            this.dgvToimintaPosti.RowHeadersWidth = 51;
            this.dgvToimintaPosti.RowTemplate.Height = 25;
            this.dgvToimintaPosti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToimintaPosti.Size = new System.Drawing.Size(251, 450);
            this.dgvToimintaPosti.TabIndex = 999;
            // 
            // btnToimintaPoistaPostinro
            // 
            this.btnToimintaPoistaPostinro.BackColor = System.Drawing.Color.Bisque;
            this.btnToimintaPoistaPostinro.Location = new System.Drawing.Point(592, 445);
            this.btnToimintaPoistaPostinro.Name = "btnToimintaPoistaPostinro";
            this.btnToimintaPoistaPostinro.Size = new System.Drawing.Size(99, 42);
            this.btnToimintaPoistaPostinro.TabIndex = 5;
            this.btnToimintaPoistaPostinro.Text = "Poista rivi";
            this.btnToimintaPoistaPostinro.UseVisualStyleBackColor = false;
            this.btnToimintaPoistaPostinro.Click += new System.EventHandler(this.btnToimintaPoistaPostinro_Click);
            // 
            // btnToimintaLisaaPostinro
            // 
            this.btnToimintaLisaaPostinro.BackColor = System.Drawing.Color.Bisque;
            this.btnToimintaLisaaPostinro.Location = new System.Drawing.Point(488, 445);
            this.btnToimintaLisaaPostinro.Name = "btnToimintaLisaaPostinro";
            this.btnToimintaLisaaPostinro.Size = new System.Drawing.Size(94, 42);
            this.btnToimintaLisaaPostinro.TabIndex = 4;
            this.btnToimintaLisaaPostinro.Text = "Lisää tiedot";
            this.btnToimintaLisaaPostinro.UseVisualStyleBackColor = false;
            this.btnToimintaLisaaPostinro.Click += new System.EventHandler(this.btnToimintaLisaaPostinro_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblToimintaPostinro);
            this.panel1.Controls.Add(this.tbToimintaPostinro);
            this.panel1.Controls.Add(this.tbToimintaPostitoimi);
            this.panel1.Controls.Add(this.lblToimintaPostitoimip);
            this.panel1.Location = new System.Drawing.Point(488, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 351);
            this.panel1.TabIndex = 3;
            // 
            // FormToiminta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(960, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnToimintaLisaaPostinro);
            this.Controls.Add(this.btnToimintaPoistaPostinro);
            this.Controls.Add(this.dgvToimintaPosti);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvToimintaPosti)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Label lblToimintaPostinro;
        private TextBox tbToimintaPostinro;
        private TextBox tbToimintaPostitoimi;
        private Label lblToimintaPostitoimip;
        private DataGridView dgvToimintaPosti;
        private Button btnToimintaPoistaPostinro;
        private Button btnToimintaLisaaPostinro;
        private Panel panel1;
    }
}