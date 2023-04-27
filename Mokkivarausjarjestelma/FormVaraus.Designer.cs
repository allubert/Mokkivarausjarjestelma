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
            this.lblVarausMokinNimi = new System.Windows.Forms.Label();
            this.dgMokkiVaraukset = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgMokkiVaraukset)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeMokinVarausAlkuPvm
            // 
            this.dateTimeMokinVarausAlkuPvm.Location = new System.Drawing.Point(78, 108);
            this.dateTimeMokinVarausAlkuPvm.Name = "dateTimeMokinVarausAlkuPvm";
            this.dateTimeMokinVarausAlkuPvm.Size = new System.Drawing.Size(200, 23);
            this.dateTimeMokinVarausAlkuPvm.TabIndex = 0;
            // 
            // dateTimeMokinVarausLoppuPvm
            // 
            this.dateTimeMokinVarausLoppuPvm.Location = new System.Drawing.Point(78, 151);
            this.dateTimeMokinVarausLoppuPvm.Name = "dateTimeMokinVarausLoppuPvm";
            this.dateTimeMokinVarausLoppuPvm.Size = new System.Drawing.Size(200, 23);
            this.dateTimeMokinVarausLoppuPvm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alkaa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loppuu";
            // 
            // btnValmisVaraus
            // 
            this.btnValmisVaraus.Enabled = false;
            this.btnValmisVaraus.Location = new System.Drawing.Point(212, 239);
            this.btnValmisVaraus.Name = "btnValmisVaraus";
            this.btnValmisVaraus.Size = new System.Drawing.Size(75, 23);
            this.btnValmisVaraus.TabIndex = 5;
            this.btnValmisVaraus.Text = "Valmis";
            this.btnValmisVaraus.UseVisualStyleBackColor = true;
            this.btnValmisVaraus.Click += new System.EventHandler(this.btnValmisVaraus_Click);
            // 
            // btnMokinVarausVahvista
            // 
            this.btnMokinVarausVahvista.Location = new System.Drawing.Point(145, 180);
            this.btnMokinVarausVahvista.Name = "btnMokinVarausVahvista";
            this.btnMokinVarausVahvista.Size = new System.Drawing.Size(133, 35);
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
            this.label3.Location = new System.Drawing.Point(2, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valittu mökki:";
            // 
            // lblVarausMokinNimi
            // 
            this.lblVarausMokinNimi.AutoSize = true;
            this.lblVarausMokinNimi.Location = new System.Drawing.Point(87, 33);
            this.lblVarausMokinNimi.Name = "lblVarausMokinNimi";
            this.lblVarausMokinNimi.Size = new System.Drawing.Size(38, 15);
            this.lblVarausMokinNimi.TabIndex = 8;
            this.lblVarausMokinNimi.Text = "label4";
            // 
            // dgMokkiVaraukset
            // 
            this.dgMokkiVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMokkiVaraukset.Location = new System.Drawing.Point(284, 2);
            this.dgMokkiVaraukset.Name = "dgMokkiVaraukset";
            this.dgMokkiVaraukset.RowTemplate.Height = 25;
            this.dgMokkiVaraukset.Size = new System.Drawing.Size(752, 310);
            this.dgMokkiVaraukset.TabIndex = 9;
            // 
            // FormVaraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 312);
            this.Controls.Add(this.dgMokkiVaraukset);
            this.Controls.Add(this.lblVarausMokinNimi);
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
        private Label lblVarausMokinNimi;
        private DataGridView dgMokkiVaraukset;
    }
}