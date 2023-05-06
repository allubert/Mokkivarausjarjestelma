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
            this.btnMokinVarausTarkastaPvm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTakaisinAloitusFormiin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMokkiVaraukset)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeMokinVarausAlkuPvm
            // 
            this.dateTimeMokinVarausAlkuPvm.Location = new System.Drawing.Point(117, 129);
            this.dateTimeMokinVarausAlkuPvm.Name = "dateTimeMokinVarausAlkuPvm";
            this.dateTimeMokinVarausAlkuPvm.Size = new System.Drawing.Size(209, 23);
            this.dateTimeMokinVarausAlkuPvm.TabIndex = 0;
            // 
            // dateTimeMokinVarausLoppuPvm
            // 
            this.dateTimeMokinVarausLoppuPvm.Location = new System.Drawing.Point(117, 168);
            this.dateTimeMokinVarausLoppuPvm.Name = "dateTimeMokinVarausLoppuPvm";
            this.dateTimeMokinVarausLoppuPvm.Size = new System.Drawing.Size(209, 23);
            this.dateTimeMokinVarausLoppuPvm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Varaus alkaa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Varaus loppuu:";
            // 
            // btnValmisVaraus
            // 
            this.btnValmisVaraus.Enabled = false;
            this.btnValmisVaraus.Location = new System.Drawing.Point(187, 271);
            this.btnValmisVaraus.Name = "btnValmisVaraus";
            this.btnValmisVaraus.Size = new System.Drawing.Size(139, 31);
            this.btnValmisVaraus.TabIndex = 5;
            this.btnValmisVaraus.Text = "Tallenna varaus";
            this.btnValmisVaraus.UseVisualStyleBackColor = true;
            this.btnValmisVaraus.Click += new System.EventHandler(this.btnValmisVaraus_Click);
            // 
            // btnMokinVarausVahvista
            // 
            this.btnMokinVarausVahvista.Enabled = false;
            this.btnMokinVarausVahvista.Location = new System.Drawing.Point(187, 234);
            this.btnMokinVarausVahvista.Name = "btnMokinVarausVahvista";
            this.btnMokinVarausVahvista.Size = new System.Drawing.Size(139, 31);
            this.btnMokinVarausVahvista.TabIndex = 6;
            this.btnMokinVarausVahvista.Text = "Vahvista päivämäärät";
            this.btnMokinVarausVahvista.UseVisualStyleBackColor = true;
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
            this.label3.Location = new System.Drawing.Point(29, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valittu mökki:";
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
            this.dgMokkiVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMokkiVaraukset.Location = new System.Drawing.Point(332, 2);
            this.dgMokkiVaraukset.Name = "dgMokkiVaraukset";
            this.dgMokkiVaraukset.RowTemplate.Height = 25;
            this.dgMokkiVaraukset.Size = new System.Drawing.Size(704, 310);
            this.dgMokkiVaraukset.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Varauksen tekijä:";
            // 
            // cmbUusiVarausValitseAsiakas
            // 
            this.cmbUusiVarausValitseAsiakas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUusiVarausValitseAsiakas.FormattingEnabled = true;
            this.cmbUusiVarausValitseAsiakas.Location = new System.Drawing.Point(117, 71);
            this.cmbUusiVarausValitseAsiakas.Name = "cmbUusiVarausValitseAsiakas";
            this.cmbUusiVarausValitseAsiakas.Size = new System.Drawing.Size(209, 23);
            this.cmbUusiVarausValitseAsiakas.TabIndex = 11;
            // 
            // cmbUusiVarausValitseMokki
            // 
            this.cmbUusiVarausValitseMokki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUusiVarausValitseMokki.FormattingEnabled = true;
            this.cmbUusiVarausValitseMokki.Location = new System.Drawing.Point(117, 42);
            this.cmbUusiVarausValitseMokki.Name = "cmbUusiVarausValitseMokki";
            this.cmbUusiVarausValitseMokki.Size = new System.Drawing.Size(209, 23);
            this.cmbUusiVarausValitseMokki.TabIndex = 12;
            // 
            // tbUusiVarausVarausID
            // 
            this.tbUusiVarausVarausID.Location = new System.Drawing.Point(117, 100);
            this.tbUusiVarausVarausID.Name = "tbUusiVarausVarausID";
            this.tbUusiVarausVarausID.Size = new System.Drawing.Size(147, 23);
            this.tbUusiVarausVarausID.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Anna varaus_id:";
            // 
            // lblVarausValittuAsiakasNimi
            // 
            this.lblVarausValittuAsiakasNimi.AutoSize = true;
            this.lblVarausValittuAsiakasNimi.Location = new System.Drawing.Point(100, 74);
            this.lblVarausValittuAsiakasNimi.Name = "lblVarausValittuAsiakasNimi";
            this.lblVarausValittuAsiakasNimi.Size = new System.Drawing.Size(0, 15);
            this.lblVarausValittuAsiakasNimi.TabIndex = 15;
            // 
            // btnMokinVarausTarkastaPvm
            // 
            this.btnMokinVarausTarkastaPvm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMokinVarausTarkastaPvm.Location = new System.Drawing.Point(187, 197);
            this.btnMokinVarausTarkastaPvm.Name = "btnMokinVarausTarkastaPvm";
            this.btnMokinVarausTarkastaPvm.Size = new System.Drawing.Size(139, 31);
            this.btnMokinVarausTarkastaPvm.TabIndex = 16;
            this.btnMokinVarausTarkastaPvm.Text = "Tarkasta päivämäärät";
            this.btnMokinVarausTarkastaPvm.UseVisualStyleBackColor = true;
            this.btnMokinVarausTarkastaPvm.Click += new System.EventHandler(this.btnMokinVarausTarkistaPvm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(89, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tarkasta, etteivät valitut päivämäärät mene\r\npäällekäin olemassaolevan varauksen " +
    "kanssa";
            // 
            // btnTakaisinAloitusFormiin
            // 
            this.btnTakaisinAloitusFormiin.Location = new System.Drawing.Point(7, 277);
            this.btnTakaisinAloitusFormiin.Name = "btnTakaisinAloitusFormiin";
            this.btnTakaisinAloitusFormiin.Size = new System.Drawing.Size(93, 23);
            this.btnTakaisinAloitusFormiin.TabIndex = 76;
            this.btnTakaisinAloitusFormiin.Text = "Alkuvalikko";
            this.btnTakaisinAloitusFormiin.UseVisualStyleBackColor = true;
            this.btnTakaisinAloitusFormiin.Click += new System.EventHandler(this.btnTakaisinAloitusFormiin_Click);
            // 
            // FormVaraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 312);
            this.Controls.Add(this.btnTakaisinAloitusFormiin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMokinVarausTarkastaPvm);
            this.Controls.Add(this.lblVarausValittuAsiakasNimi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUusiVarausVarausID);
            this.Controls.Add(this.cmbUusiVarausValitseMokki);
            this.Controls.Add(this.cmbUusiVarausValitseAsiakas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgMokkiVaraukset);
            this.Controls.Add(this.lblVarausValittuMokkiNimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMokinVarausVahvista);
            this.Controls.Add(this.btnValmisVaraus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeMokinVarausLoppuPvm);
            this.Controls.Add(this.dateTimeMokinVarausAlkuPvm);
            this.Name = "FormVaraus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uusi Varaus";
            ((System.ComponentModel.ISupportInitialize)(this.dgMokkiVaraukset)).EndInit();
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
        private Button btnMokinVarausTarkastaPvm;
        private Label label6;
        private Button btnTakaisinAloitusFormiin;
    }
}