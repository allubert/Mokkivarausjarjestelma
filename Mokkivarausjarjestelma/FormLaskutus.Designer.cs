namespace Mokkivarausjarjestelma
{
    partial class FormLaskutus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaskutus));
            btnTakaisinAloitusFormiin = new Button();
            btnPoistaLasku = new Button();
            btnLahetalasku = new Button();
            dgvLaskutus = new DataGridView();
            lblOhjeet = new Label();
            lblVaraus_id = new Label();
            lblSumma = new Label();
            lblAlv = new Label();
            lblLaskuID = new Label();
            tbVarausID = new TextBox();
            tbSumma = new TextBox();
            tbAlv = new TextBox();
            tbLaskuID = new TextBox();
            btnHae = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLaskutus).BeginInit();
            SuspendLayout();
            // 
            // btnTakaisinAloitusFormiin
            // 
            btnTakaisinAloitusFormiin.BackColor = Color.Yellow;
            btnTakaisinAloitusFormiin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTakaisinAloitusFormiin.Location = new Point(940, 544);
            btnTakaisinAloitusFormiin.Margin = new Padding(3, 4, 3, 4);
            btnTakaisinAloitusFormiin.Name = "btnTakaisinAloitusFormiin";
            btnTakaisinAloitusFormiin.Size = new Size(216, 166);
            btnTakaisinAloitusFormiin.TabIndex = 76;
            btnTakaisinAloitusFormiin.Text = "Alkuvalikko";
            btnTakaisinAloitusFormiin.UseVisualStyleBackColor = false;
            btnTakaisinAloitusFormiin.Click += btnTakaisinAloitusFormiin_Click;
            // 
            // btnPoistaLasku
            // 
            btnPoistaLasku.BackColor = Color.Yellow;
            btnPoistaLasku.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPoistaLasku.Location = new Point(218, 544);
            btnPoistaLasku.Name = "btnPoistaLasku";
            btnPoistaLasku.Size = new Size(196, 167);
            btnPoistaLasku.TabIndex = 79;
            btnPoistaLasku.Text = "Poista lasku";
            btnPoistaLasku.UseVisualStyleBackColor = false;
            btnPoistaLasku.Click += btnPoistaLasku_Click;
            // 
            // btnLahetalasku
            // 
            btnLahetalasku.BackColor = Color.Yellow;
            btnLahetalasku.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLahetalasku.Location = new Point(12, 544);
            btnLahetalasku.Name = "btnLahetalasku";
            btnLahetalasku.Size = new Size(200, 167);
            btnLahetalasku.TabIndex = 78;
            btnLahetalasku.Text = "Tallenna lasku";
            btnLahetalasku.UseVisualStyleBackColor = false;
            btnLahetalasku.Click += btnLahetalasku_Click;
            // 
            // dgvLaskutus
            // 
            dgvLaskutus.BackgroundColor = Color.Bisque;
            dgvLaskutus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaskutus.Location = new Point(339, 12);
            dgvLaskutus.Name = "dgvLaskutus";
            dgvLaskutus.ReadOnly = true;
            dgvLaskutus.RowHeadersWidth = 51;
            dgvLaskutus.RowTemplate.Height = 29;
            dgvLaskutus.Size = new Size(808, 509);
            dgvLaskutus.TabIndex = 77;
            // 
            // lblOhjeet
            // 
            lblOhjeet.BackColor = Color.Aqua;
            lblOhjeet.Location = new Point(440, 524);
            lblOhjeet.Name = "lblOhjeet";
            lblOhjeet.Size = new Size(461, 201);
            lblOhjeet.TabIndex = 80;
            lblOhjeet.Text = resources.GetString("lblOhjeet.Text");
            // 
            // lblVaraus_id
            // 
            lblVaraus_id.Location = new Point(16, 33);
            lblVaraus_id.Name = "lblVaraus_id";
            lblVaraus_id.Size = new Size(77, 31);
            lblVaraus_id.TabIndex = 81;
            lblVaraus_id.Text = "Varaus_id";
            // 
            // lblSumma
            // 
            lblSumma.Location = new Point(16, 96);
            lblSumma.Name = "lblSumma";
            lblSumma.Size = new Size(62, 25);
            lblSumma.TabIndex = 82;
            lblSumma.Text = "Summa ";
            // 
            // lblAlv
            // 
            lblAlv.Location = new Point(16, 149);
            lblAlv.Name = "lblAlv";
            lblAlv.Size = new Size(62, 25);
            lblAlv.TabIndex = 83;
            lblAlv.Text = "Alv";
            // 
            // lblLaskuID
            // 
            lblLaskuID.Location = new Point(16, 204);
            lblLaskuID.Name = "lblLaskuID";
            lblLaskuID.Size = new Size(77, 25);
            lblLaskuID.TabIndex = 84;
            lblLaskuID.Text = "Lasku_id";
            // 
            // tbVarausID
            // 
            tbVarausID.Location = new Point(115, 30);
            tbVarausID.Name = "tbVarausID";
            tbVarausID.Size = new Size(125, 27);
            tbVarausID.TabIndex = 85;
            // 
            // tbSumma
            // 
            tbSumma.Location = new Point(115, 96);
            tbSumma.Name = "tbSumma";
            tbSumma.Size = new Size(125, 27);
            tbSumma.TabIndex = 86;
            // 
            // tbAlv
            // 
            tbAlv.Location = new Point(115, 149);
            tbAlv.Name = "tbAlv";
            tbAlv.Size = new Size(125, 27);
            tbAlv.TabIndex = 87;
            tbAlv.Text = "24%";
            // 
            // tbLaskuID
            // 
            tbLaskuID.Location = new Point(115, 204);
            tbLaskuID.Name = "tbLaskuID";
            tbLaskuID.Size = new Size(125, 27);
            tbLaskuID.TabIndex = 88;
            // 
            // btnHae
            // 
            btnHae.Location = new Point(246, 28);
            btnHae.Name = "btnHae";
            btnHae.Size = new Size(69, 29);
            btnHae.TabIndex = 89;
            btnHae.Text = "Hae";
            btnHae.UseVisualStyleBackColor = true;
            btnHae.Click += btnHae_Click;
            // 
            // FormLaskutus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1178, 723);
            Controls.Add(btnHae);
            Controls.Add(tbLaskuID);
            Controls.Add(tbAlv);
            Controls.Add(tbSumma);
            Controls.Add(tbVarausID);
            Controls.Add(lblLaskuID);
            Controls.Add(lblAlv);
            Controls.Add(lblSumma);
            Controls.Add(lblVaraus_id);
            Controls.Add(lblOhjeet);
            Controls.Add(btnPoistaLasku);
            Controls.Add(btnLahetalasku);
            Controls.Add(dgvLaskutus);
            Controls.Add(btnTakaisinAloitusFormiin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLaskutus";
            Text = "FormLaskutus";
            ((System.ComponentModel.ISupportInitialize)dgvLaskutus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTakaisinAloitusFormiin;
        private Button btnPoistaLasku;
        private Button btnLahetalasku;
        private DataGridView dgvLaskutus;
        private Label lblOhjeet;
        private Label lblVaraus_id;
        private Label lblSumma;
        private Label lblAlv;
        private Label lblLaskuID;
        private TextBox tbVarausID;
        private TextBox tbSumma;
        private TextBox tbAlv;
        private TextBox tbLaskuID;
        private Button btnHae;
    }
}