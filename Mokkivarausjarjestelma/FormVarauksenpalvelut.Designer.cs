namespace Mokkivarausjarjestelma
{
    partial class FormVarauksenpalvelut
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
            this.dgvVarauksenpalvelut = new System.Windows.Forms.DataGridView();
            this.cmbVarausID = new System.Windows.Forms.ComboBox();
            this.cmbPalveluID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLkm = new System.Windows.Forms.TextBox();
            this.btnVaraukseen = new System.Windows.Forms.Button();
            this.btnPalveluihin = new System.Windows.Forms.Button();
            this.btnLaskuihin = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenpalvelut)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVarauksenpalvelut
            // 
            this.dgvVarauksenpalvelut.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dgvVarauksenpalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarauksenpalvelut.Location = new System.Drawing.Point(280, 12);
            this.dgvVarauksenpalvelut.Name = "dgvVarauksenpalvelut";
            this.dgvVarauksenpalvelut.ReadOnly = true;
            this.dgvVarauksenpalvelut.RowTemplate.Height = 25;
            this.dgvVarauksenpalvelut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVarauksenpalvelut.Size = new System.Drawing.Size(508, 308);
            this.dgvVarauksenpalvelut.TabIndex = 0;
            // 
            // cmbVarausID
            // 
            this.cmbVarausID.FormattingEnabled = true;
            this.cmbVarausID.Location = new System.Drawing.Point(198, 48);
            this.cmbVarausID.Name = "cmbVarausID";
            this.cmbVarausID.Size = new System.Drawing.Size(67, 23);
            this.cmbVarausID.TabIndex = 1;
            // 
            // cmbPalveluID
            // 
            this.cmbPalveluID.FormattingEnabled = true;
            this.cmbPalveluID.Location = new System.Drawing.Point(198, 103);
            this.cmbPalveluID.Name = "cmbPalveluID";
            this.cmbPalveluID.Size = new System.Drawing.Size(67, 23);
            this.cmbPalveluID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valitse jo olemassa oleva varausID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valitse jo olemassa oleva palveluID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Syötä haluamasi lukumäärä varaamallesi \r\npalveluille alla olevaan tekstikenttään:" +
    "";
            // 
            // tbLkm
            // 
            this.tbLkm.Location = new System.Drawing.Point(12, 188);
            this.tbLkm.Name = "tbLkm";
            this.tbLkm.Size = new System.Drawing.Size(253, 23);
            this.tbLkm.TabIndex = 6;
            this.tbLkm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLkm_KeyPress);
            // 
            // btnVaraukseen
            // 
            this.btnVaraukseen.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnVaraukseen.Location = new System.Drawing.Point(12, 315);
            this.btnVaraukseen.Name = "btnVaraukseen";
            this.btnVaraukseen.Size = new System.Drawing.Size(180, 23);
            this.btnVaraukseen.TabIndex = 7;
            this.btnVaraukseen.Text = "Palaa varausten hallintaan";
            this.btnVaraukseen.UseVisualStyleBackColor = false;
            this.btnVaraukseen.Click += new System.EventHandler(this.btnVaraukseen_Click);
            // 
            // btnPalveluihin
            // 
            this.btnPalveluihin.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnPalveluihin.Location = new System.Drawing.Point(12, 351);
            this.btnPalveluihin.Name = "btnPalveluihin";
            this.btnPalveluihin.Size = new System.Drawing.Size(180, 23);
            this.btnPalveluihin.TabIndex = 8;
            this.btnPalveluihin.Text = "Palaa palveluiden hallintaan";
            this.btnPalveluihin.UseVisualStyleBackColor = false;
            this.btnPalveluihin.Click += new System.EventHandler(this.btnPalveluihin_Click);
            // 
            // btnLaskuihin
            // 
            this.btnLaskuihin.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnLaskuihin.Location = new System.Drawing.Point(12, 389);
            this.btnLaskuihin.Name = "btnLaskuihin";
            this.btnLaskuihin.Size = new System.Drawing.Size(180, 23);
            this.btnLaskuihin.TabIndex = 9;
            this.btnLaskuihin.Text = "Siirry laskujen hallintaan";
            this.btnLaskuihin.UseVisualStyleBackColor = false;
            this.btnLaskuihin.Click += new System.EventHandler(this.btnLaskuihin_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnLisaa.Location = new System.Drawing.Point(12, 235);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(75, 23);
            this.btnLisaa.TabIndex = 10;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = false;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnPoista.Location = new System.Drawing.Point(117, 235);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 11;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = false;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // FormVarauksenpalvelut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.btnLaskuihin);
            this.Controls.Add(this.btnPalveluihin);
            this.Controls.Add(this.btnVaraukseen);
            this.Controls.Add(this.tbLkm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPalveluID);
            this.Controls.Add(this.cmbVarausID);
            this.Controls.Add(this.dgvVarauksenpalvelut);
            this.Name = "FormVarauksenpalvelut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVarauksenpalvelut";
            this.Load += new System.EventHandler(this.FormVarauksenpalvelut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenpalvelut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvVarauksenpalvelut;
        private ComboBox cmbVarausID;
        private ComboBox cmbPalveluID;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbLkm;
        private Button btnVaraukseen;
        private Button btnPalveluihin;
        private Button btnLaskuihin;
        private Button btnLisaa;
        private Button btnPoista;
    }
}