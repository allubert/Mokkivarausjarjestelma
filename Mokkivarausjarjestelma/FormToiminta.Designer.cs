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
            this.btnToimintaRaportointi = new System.Windows.Forms.Button();
            this.pnlToiminta = new System.Windows.Forms.Panel();
            this.lblToimintaAlueid = new System.Windows.Forms.Label();
            this.tbToimintaAlueid = new System.Windows.Forms.TextBox();
            this.lblToimintaOtsikko = new System.Windows.Forms.Label();
            this.lblToimintaAlue = new System.Windows.Forms.Label();
            this.tbToimintaAlue = new System.Windows.Forms.TextBox();
            this.lblToimintaOsoite = new System.Windows.Forms.Label();
            this.tbToimintaToimip = new System.Windows.Forms.TextBox();
            this.tbToimintaPostinro = new System.Windows.Forms.TextBox();
            this.lblToimintaPostinro = new System.Windows.Forms.Label();
            this.btnToimintaKohteet = new System.Windows.Forms.Button();
            this.dgvHallinta = new System.Windows.Forms.DataGridView();
            this.btnToimintaPoistaAlue = new System.Windows.Forms.Button();
            this.btnToimintaLisaaAlue = new System.Windows.Forms.Button();
            this.pnlToiminta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallinta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToimintaRaportointi
            // 
            this.btnToimintaRaportointi.Location = new System.Drawing.Point(116, 492);
            this.btnToimintaRaportointi.Name = "btnToimintaRaportointi";
            this.btnToimintaRaportointi.Size = new System.Drawing.Size(99, 42);
            this.btnToimintaRaportointi.TabIndex = 27;
            this.btnToimintaRaportointi.Text = "Näytä raportointi";
            this.btnToimintaRaportointi.UseVisualStyleBackColor = true;
            // 
            // pnlToiminta
            // 
            this.pnlToiminta.Controls.Add(this.lblToimintaAlueid);
            this.pnlToiminta.Controls.Add(this.tbToimintaAlueid);
            this.pnlToiminta.Controls.Add(this.lblToimintaOtsikko);
            this.pnlToiminta.Controls.Add(this.lblToimintaAlue);
            this.pnlToiminta.Controls.Add(this.tbToimintaAlue);
            this.pnlToiminta.Controls.Add(this.lblToimintaOsoite);
            this.pnlToiminta.Controls.Add(this.tbToimintaToimip);
            this.pnlToiminta.Controls.Add(this.tbToimintaPostinro);
            this.pnlToiminta.Controls.Add(this.lblToimintaPostinro);
            this.pnlToiminta.Location = new System.Drawing.Point(2, 51);
            this.pnlToiminta.Name = "pnlToiminta";
            this.pnlToiminta.Size = new System.Drawing.Size(223, 344);
            this.pnlToiminta.TabIndex = 23;
            // 
            // lblToimintaAlueid
            // 
            this.lblToimintaAlueid.AutoSize = true;
            this.lblToimintaAlueid.Location = new System.Drawing.Point(8, 125);
            this.lblToimintaAlueid.Name = "lblToimintaAlueid";
            this.lblToimintaAlueid.Size = new System.Drawing.Size(46, 15);
            this.lblToimintaAlueid.TabIndex = 29;
            this.lblToimintaAlueid.Text = "Alue_id";
            // 
            // tbToimintaAlueid
            // 
            this.tbToimintaAlueid.Location = new System.Drawing.Point(6, 143);
            this.tbToimintaAlueid.Name = "tbToimintaAlueid";
            this.tbToimintaAlueid.Size = new System.Drawing.Size(199, 23);
            this.tbToimintaAlueid.TabIndex = 28;
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
            this.tbToimintaAlue.Location = new System.Drawing.Point(3, 83);
            this.tbToimintaAlue.Name = "tbToimintaAlue";
            this.tbToimintaAlue.Size = new System.Drawing.Size(199, 23);
            this.tbToimintaAlue.TabIndex = 16;
            // 
            // lblToimintaOsoite
            // 
            this.lblToimintaOsoite.AutoSize = true;
            this.lblToimintaOsoite.Location = new System.Drawing.Point(8, 230);
            this.lblToimintaOsoite.Name = "lblToimintaOsoite";
            this.lblToimintaOsoite.Size = new System.Drawing.Size(70, 15);
            this.lblToimintaOsoite.TabIndex = 9;
            this.lblToimintaOsoite.Text = "Toimipaikka";
            // 
            // tbToimintaToimip
            // 
            this.tbToimintaToimip.Location = new System.Drawing.Point(6, 250);
            this.tbToimintaToimip.Name = "tbToimintaToimip";
            this.tbToimintaToimip.Size = new System.Drawing.Size(199, 23);
            this.tbToimintaToimip.TabIndex = 3;
            // 
            // tbToimintaPostinro
            // 
            this.tbToimintaPostinro.Location = new System.Drawing.Point(6, 204);
            this.tbToimintaPostinro.Name = "tbToimintaPostinro";
            this.tbToimintaPostinro.Size = new System.Drawing.Size(199, 23);
            this.tbToimintaPostinro.TabIndex = 4;
            // 
            // lblToimintaPostinro
            // 
            this.lblToimintaPostinro.AutoSize = true;
            this.lblToimintaPostinro.Location = new System.Drawing.Point(6, 186);
            this.lblToimintaPostinro.Name = "lblToimintaPostinro";
            this.lblToimintaPostinro.Size = new System.Drawing.Size(75, 15);
            this.lblToimintaPostinro.TabIndex = 10;
            this.lblToimintaPostinro.Text = "Postinumero";
            // 
            // btnToimintaKohteet
            // 
            this.btnToimintaKohteet.Location = new System.Drawing.Point(8, 492);
            this.btnToimintaKohteet.Name = "btnToimintaKohteet";
            this.btnToimintaKohteet.Size = new System.Drawing.Size(94, 42);
            this.btnToimintaKohteet.TabIndex = 26;
            this.btnToimintaKohteet.Text = "Näytä kohteet";
            this.btnToimintaKohteet.UseVisualStyleBackColor = true;
            // 
            // dgvHallinta
            // 
            this.dgvHallinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHallinta.Location = new System.Drawing.Point(252, 30);
            this.dgvHallinta.Name = "dgvHallinta";
            this.dgvHallinta.RowHeadersWidth = 51;
            this.dgvHallinta.RowTemplate.Height = 25;
            this.dgvHallinta.Size = new System.Drawing.Size(696, 450);
            this.dgvHallinta.TabIndex = 22;
            // 
            // btnToimintaPoistaAlue
            // 
            this.btnToimintaPoistaAlue.Location = new System.Drawing.Point(116, 444);
            this.btnToimintaPoistaAlue.Name = "btnToimintaPoistaAlue";
            this.btnToimintaPoistaAlue.Size = new System.Drawing.Size(99, 42);
            this.btnToimintaPoistaAlue.TabIndex = 25;
            this.btnToimintaPoistaAlue.Text = "Poista toiminta-alue";
            this.btnToimintaPoistaAlue.UseVisualStyleBackColor = true;
            // 
            // btnToimintaLisaaAlue
            // 
            this.btnToimintaLisaaAlue.Location = new System.Drawing.Point(8, 444);
            this.btnToimintaLisaaAlue.Name = "btnToimintaLisaaAlue";
            this.btnToimintaLisaaAlue.Size = new System.Drawing.Size(94, 42);
            this.btnToimintaLisaaAlue.TabIndex = 24;
            this.btnToimintaLisaaAlue.Text = "Lisää toiminta-alue";
            this.btnToimintaLisaaAlue.UseVisualStyleBackColor = true;
            // 
            // FormToiminta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 626);
            this.Controls.Add(this.btnToimintaRaportointi);
            this.Controls.Add(this.pnlToiminta);
            this.Controls.Add(this.btnToimintaKohteet);
            this.Controls.Add(this.dgvHallinta);
            this.Controls.Add(this.btnToimintaPoistaAlue);
            this.Controls.Add(this.btnToimintaLisaaAlue);
            this.Name = "FormToiminta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormToiminta";
            this.pnlToiminta.ResumeLayout(false);
            this.pnlToiminta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallinta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnToimintaRaportointi;
        private Panel pnlToiminta;
        private Label lblToimintaAlueid;
        private TextBox tbToimintaAlueid;
        private Label lblToimintaOtsikko;
        private Label lblToimintaAlue;
        private TextBox tbToimintaAlue;
        private Label lblToimintaOsoite;
        private TextBox tbToimintaToimip;
        private TextBox tbToimintaPostinro;
        private Label lblToimintaPostinro;
        private Button btnToimintaKohteet;
        private DataGridView dgvHallinta;
        private Button btnToimintaPoistaAlue;
        private Button btnToimintaLisaaAlue;
    }
}