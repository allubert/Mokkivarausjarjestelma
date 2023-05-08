namespace Mokkivarausjarjestelma
{
    partial class FormAsiakashallinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsiakashallinta));
            btnTakaisinAloitusFormiin = new Button();
            btnAsiakasPoista = new Button();
            btnAsiakasPaivita = new Button();
            btnAsiakasLisaa = new Button();
            btnAsiakasHae = new Button();
            tbAsiakasSukunimi = new TextBox();
            tbAsiakasLahiosoite = new TextBox();
            tbAsiakasEtunimi = new TextBox();
            tbAsiakasSahkoposti = new TextBox();
            tbAsiakasPuhelinnumero = new TextBox();
            tbasiakasPostinumero = new TextBox();
            tbAsiakasid = new TextBox();
            lblPuhelinnumero = new Label();
            lblSahkoposti = new Label();
            lblLahiosoite = new Label();
            lblSukunimi = new Label();
            lblEtunimi = new Label();
            lblPostinumero = new Label();
            lblAsiakasid = new Label();
            dgvAsiakashallinta = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAsiakashallinta).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTakaisinAloitusFormiin
            // 
            btnTakaisinAloitusFormiin.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnTakaisinAloitusFormiin.Location = new Point(2, 1);
            btnTakaisinAloitusFormiin.Margin = new Padding(3, 4, 3, 4);
            btnTakaisinAloitusFormiin.Name = "btnTakaisinAloitusFormiin";
            btnTakaisinAloitusFormiin.Size = new Size(106, 31);
            btnTakaisinAloitusFormiin.TabIndex = 76;
            btnTakaisinAloitusFormiin.Text = "Alkuvalikko";
            btnTakaisinAloitusFormiin.UseVisualStyleBackColor = true;
            btnTakaisinAloitusFormiin.Click += btnTakaisinAloitusFormiin_Click;
            // 
            // btnAsiakasPoista
            // 
            btnAsiakasPoista.BackColor = Color.PeachPuff;
            btnAsiakasPoista.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAsiakasPoista.Location = new Point(207, 535);
            btnAsiakasPoista.Margin = new Padding(3, 4, 3, 4);
            btnAsiakasPoista.Name = "btnAsiakasPoista";
            btnAsiakasPoista.Size = new Size(72, 31);
            btnAsiakasPoista.TabIndex = 95;
            btnAsiakasPoista.Text = "Poista";
            btnAsiakasPoista.UseVisualStyleBackColor = false;
            btnAsiakasPoista.Visible = false;
            btnAsiakasPoista.Click += btnAsiakasPoista_Click;
            // 
            // btnAsiakasPaivita
            // 
            btnAsiakasPaivita.BackColor = Color.PeachPuff;
            btnAsiakasPaivita.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAsiakasPaivita.Location = new Point(121, 535);
            btnAsiakasPaivita.Margin = new Padding(3, 4, 3, 4);
            btnAsiakasPaivita.Name = "btnAsiakasPaivita";
            btnAsiakasPaivita.Size = new Size(72, 31);
            btnAsiakasPaivita.TabIndex = 94;
            btnAsiakasPaivita.Text = "Päivitä";
            btnAsiakasPaivita.UseVisualStyleBackColor = false;
            btnAsiakasPaivita.Visible = false;
            btnAsiakasPaivita.Click += btnAsiakasPaivita_Click;
            // 
            // btnAsiakasLisaa
            // 
            btnAsiakasLisaa.BackColor = Color.PeachPuff;
            btnAsiakasLisaa.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAsiakasLisaa.Location = new Point(31, 535);
            btnAsiakasLisaa.Margin = new Padding(3, 4, 3, 4);
            btnAsiakasLisaa.Name = "btnAsiakasLisaa";
            btnAsiakasLisaa.Size = new Size(72, 31);
            btnAsiakasLisaa.TabIndex = 93;
            btnAsiakasLisaa.Text = "Lisää";
            btnAsiakasLisaa.UseVisualStyleBackColor = false;
            btnAsiakasLisaa.Click += btnAsiakasLisaa_Click;
            // 
            // btnAsiakasHae
            // 
            btnAsiakasHae.BackColor = Color.PeachPuff;
            btnAsiakasHae.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAsiakasHae.Location = new Point(273, 73);
            btnAsiakasHae.Margin = new Padding(3, 4, 3, 4);
            btnAsiakasHae.Name = "btnAsiakasHae";
            btnAsiakasHae.Size = new Size(72, 31);
            btnAsiakasHae.TabIndex = 92;
            btnAsiakasHae.Text = "Hae";
            btnAsiakasHae.UseVisualStyleBackColor = false;
            btnAsiakasHae.Click += btnAsiakasHae_Click;
            // 
            // tbAsiakasSukunimi
            // 
            tbAsiakasSukunimi.Location = new Point(109, 259);
            tbAsiakasSukunimi.Name = "tbAsiakasSukunimi";
            tbAsiakasSukunimi.Size = new Size(157, 27);
            tbAsiakasSukunimi.TabIndex = 91;
            // 
            // tbAsiakasLahiosoite
            // 
            tbAsiakasLahiosoite.Location = new Point(109, 316);
            tbAsiakasLahiosoite.Name = "tbAsiakasLahiosoite";
            tbAsiakasLahiosoite.Size = new Size(157, 27);
            tbAsiakasLahiosoite.TabIndex = 90;
            // 
            // tbAsiakasEtunimi
            // 
            tbAsiakasEtunimi.Location = new Point(109, 189);
            tbAsiakasEtunimi.Name = "tbAsiakasEtunimi";
            tbAsiakasEtunimi.Size = new Size(157, 27);
            tbAsiakasEtunimi.TabIndex = 89;
            // 
            // tbAsiakasSahkoposti
            // 
            tbAsiakasSahkoposti.Location = new Point(109, 377);
            tbAsiakasSahkoposti.Name = "tbAsiakasSahkoposti";
            tbAsiakasSahkoposti.Size = new Size(157, 27);
            tbAsiakasSahkoposti.TabIndex = 88;
            // 
            // tbAsiakasPuhelinnumero
            // 
            tbAsiakasPuhelinnumero.Location = new Point(121, 452);
            tbAsiakasPuhelinnumero.Name = "tbAsiakasPuhelinnumero";
            tbAsiakasPuhelinnumero.Size = new Size(157, 27);
            tbAsiakasPuhelinnumero.TabIndex = 87;
            // 
            // tbasiakasPostinumero
            // 
            tbasiakasPostinumero.Location = new Point(109, 133);
            tbasiakasPostinumero.Name = "tbasiakasPostinumero";
            tbasiakasPostinumero.Size = new Size(157, 27);
            tbasiakasPostinumero.TabIndex = 86;
            // 
            // tbAsiakasid
            // 
            tbAsiakasid.Location = new Point(109, 73);
            tbAsiakasid.Name = "tbAsiakasid";
            tbAsiakasid.Size = new Size(157, 27);
            tbAsiakasid.TabIndex = 85;
            tbAsiakasid.Text = "0";
            // 
            // lblPuhelinnumero
            // 
            lblPuhelinnumero.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPuhelinnumero.Location = new Point(2, 452);
            lblPuhelinnumero.Name = "lblPuhelinnumero";
            lblPuhelinnumero.Size = new Size(122, 60);
            lblPuhelinnumero.TabIndex = 84;
            lblPuhelinnumero.Text = "Puhelinnumero";
            // 
            // lblSahkoposti
            // 
            lblSahkoposti.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSahkoposti.Location = new Point(2, 380);
            lblSahkoposti.Name = "lblSahkoposti";
            lblSahkoposti.Size = new Size(101, 60);
            lblSahkoposti.TabIndex = 83;
            lblSahkoposti.Text = "Sähköposti";
            // 
            // lblLahiosoite
            // 
            lblLahiosoite.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLahiosoite.Location = new Point(2, 320);
            lblLahiosoite.Name = "lblLahiosoite";
            lblLahiosoite.Size = new Size(101, 60);
            lblLahiosoite.TabIndex = 82;
            lblLahiosoite.Text = "Lähiosoite";
            // 
            // lblSukunimi
            // 
            lblSukunimi.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSukunimi.Location = new Point(2, 261);
            lblSukunimi.Name = "lblSukunimi";
            lblSukunimi.Size = new Size(101, 60);
            lblSukunimi.TabIndex = 81;
            lblSukunimi.Text = "Sukunimi";
            // 
            // lblEtunimi
            // 
            lblEtunimi.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblEtunimi.Location = new Point(2, 193);
            lblEtunimi.Name = "lblEtunimi";
            lblEtunimi.Size = new Size(101, 60);
            lblEtunimi.TabIndex = 80;
            lblEtunimi.Text = "Etunimi";
            // 
            // lblPostinumero
            // 
            lblPostinumero.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPostinumero.Location = new Point(-2, 133);
            lblPostinumero.Name = "lblPostinumero";
            lblPostinumero.Size = new Size(101, 35);
            lblPostinumero.TabIndex = 79;
            lblPostinumero.Text = "Postinumero";
            // 
            // lblAsiakasid
            // 
            lblAsiakasid.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAsiakasid.Location = new Point(2, 73);
            lblAsiakasid.Name = "lblAsiakasid";
            lblAsiakasid.Size = new Size(101, 60);
            lblAsiakasid.TabIndex = 78;
            lblAsiakasid.Text = "AsiakasID";
            // 
            // dgvAsiakashallinta
            // 
            dgvAsiakashallinta.BackgroundColor = Color.Bisque;
            dgvAsiakashallinta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsiakashallinta.Location = new Point(352, 15);
            dgvAsiakashallinta.Name = "dgvAsiakashallinta";
            dgvAsiakashallinta.ReadOnly = true;
            dgvAsiakashallinta.RowHeadersWidth = 51;
            dgvAsiakashallinta.RowTemplate.Height = 29;
            dgvAsiakashallinta.Size = new Size(731, 516);
            dgvAsiakashallinta.TabIndex = 77;
            dgvAsiakashallinta.Click += dgvAsiakashallinta_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 573);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 95);
            panel1.TabIndex = 96;
            // 
            // label1
            // 
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(965, 92);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormAsiakashallinta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1097, 835);
            Controls.Add(panel1);
            Controls.Add(btnAsiakasPoista);
            Controls.Add(btnAsiakasPaivita);
            Controls.Add(btnAsiakasLisaa);
            Controls.Add(btnAsiakasHae);
            Controls.Add(tbAsiakasSukunimi);
            Controls.Add(tbAsiakasLahiosoite);
            Controls.Add(tbAsiakasEtunimi);
            Controls.Add(tbAsiakasSahkoposti);
            Controls.Add(tbAsiakasPuhelinnumero);
            Controls.Add(tbasiakasPostinumero);
            Controls.Add(tbAsiakasid);
            Controls.Add(lblPuhelinnumero);
            Controls.Add(lblSahkoposti);
            Controls.Add(lblLahiosoite);
            Controls.Add(lblSukunimi);
            Controls.Add(lblEtunimi);
            Controls.Add(lblPostinumero);
            Controls.Add(lblAsiakasid);
            Controls.Add(dgvAsiakashallinta);
            Controls.Add(btnTakaisinAloitusFormiin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAsiakashallinta";
            Text = "FormAsiakashallinta";
            Load += FormAsiakashallinta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsiakashallinta).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTakaisinAloitusFormiin;
        private Button btnAsiakasPoista;
        private Button btnAsiakasPaivita;
        private Button btnAsiakasLisaa;
        private Button btnAsiakasHae;
        private TextBox tbAsiakasSukunimi;
        private TextBox tbAsiakasLahiosoite;
        private TextBox tbAsiakasEtunimi;
        private TextBox tbAsiakasSahkoposti;
        private TextBox tbAsiakasPuhelinnumero;
        private TextBox tbasiakasPostinumero;
        private TextBox tbAsiakasid;
        private Label lblPuhelinnumero;
        private Label lblSahkoposti;
        private Label lblLahiosoite;
        private Label lblSukunimi;
        private Label lblEtunimi;
        private Label lblPostinumero;
        private Label lblAsiakasid;
        private DataGridView dgvAsiakashallinta;
        private Panel panel1;
        private Label label1;
    }
}