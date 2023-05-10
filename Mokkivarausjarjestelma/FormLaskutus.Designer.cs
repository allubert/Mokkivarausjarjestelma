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
            tbSumma = new TextBox();
            tbAlv = new TextBox();
            tbLaskuID = new TextBox();
            btnHae = new Button();
            btnLisää = new Button();
            cbVarausId = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvLaskutus).BeginInit();
            SuspendLayout();
            // 
            // btnTakaisinAloitusFormiin
            // 
            btnTakaisinAloitusFormiin.BackColor = Color.PeachPuff;
            btnTakaisinAloitusFormiin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTakaisinAloitusFormiin.Location = new Point(-1, 2);
            btnTakaisinAloitusFormiin.Margin = new Padding(3, 4, 3, 4);
            btnTakaisinAloitusFormiin.Name = "btnTakaisinAloitusFormiin";
            btnTakaisinAloitusFormiin.Size = new Size(128, 36);
            btnTakaisinAloitusFormiin.TabIndex = 76;
            btnTakaisinAloitusFormiin.Text = "Alkuvalikko";
            btnTakaisinAloitusFormiin.UseVisualStyleBackColor = false;
            btnTakaisinAloitusFormiin.Click += btnTakaisinAloitusFormiin_Click;
            // 
            // btnPoistaLasku
            // 
            btnPoistaLasku.BackColor = Color.PeachPuff;
            btnPoistaLasku.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPoistaLasku.Location = new Point(244, 378);
            btnPoistaLasku.Name = "btnPoistaLasku";
            btnPoistaLasku.Size = new Size(99, 75);
            btnPoistaLasku.TabIndex = 79;
            btnPoistaLasku.Text = "Poista lasku";
            btnPoistaLasku.UseVisualStyleBackColor = false;
            btnPoistaLasku.Click += btnPoistaLasku_Click;
            // 
            // btnLahetalasku
            // 
            btnLahetalasku.BackColor = Color.PeachPuff;
            btnLahetalasku.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLahetalasku.Location = new Point(113, 378);
            btnLahetalasku.Name = "btnLahetalasku";
            btnLahetalasku.Size = new Size(125, 75);
            btnLahetalasku.TabIndex = 78;
            btnLahetalasku.Text = "Tallenna lasku dokumentiksi";
            btnLahetalasku.UseVisualStyleBackColor = false;
            btnLahetalasku.Click += btnLahetalasku_Click;
            // 
            // dgvLaskutus
            // 
            dgvLaskutus.BackgroundColor = Color.Bisque;
            dgvLaskutus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaskutus.Location = new Point(358, 12);
            dgvLaskutus.Name = "dgvLaskutus";
            dgvLaskutus.ReadOnly = true;
            dgvLaskutus.RowHeadersWidth = 51;
            dgvLaskutus.RowTemplate.Height = 29;
            dgvLaskutus.Size = new Size(789, 509);
            dgvLaskutus.TabIndex = 77;
            dgvLaskutus.Click += dgvLaskutus_Click;
            // 
            // lblOhjeet
            // 
            lblOhjeet.BackColor = Color.Aqua;
            lblOhjeet.Location = new Point(-1, 524);
            lblOhjeet.Name = "lblOhjeet";
            lblOhjeet.Size = new Size(1148, 144);
            lblOhjeet.TabIndex = 80;
            lblOhjeet.Text = resources.GetString("lblOhjeet.Text");
            // 
            // lblVaraus_id
            // 
            lblVaraus_id.Location = new Point(14, 128);
            lblVaraus_id.Name = "lblVaraus_id";
            lblVaraus_id.Size = new Size(77, 31);
            lblVaraus_id.TabIndex = 81;
            lblVaraus_id.Text = "Varaus_id";
            // 
            // lblSumma
            // 
            lblSumma.Location = new Point(14, 191);
            lblSumma.Name = "lblSumma";
            lblSumma.Size = new Size(62, 25);
            lblSumma.TabIndex = 82;
            lblSumma.Text = "Summa ";
            // 
            // lblAlv
            // 
            lblAlv.Location = new Point(14, 244);
            lblAlv.Name = "lblAlv";
            lblAlv.Size = new Size(62, 25);
            lblAlv.TabIndex = 83;
            lblAlv.Text = "Alv";
            // 
            // lblLaskuID
            // 
            lblLaskuID.Location = new Point(14, 299);
            lblLaskuID.Name = "lblLaskuID";
            lblLaskuID.Size = new Size(77, 25);
            lblLaskuID.TabIndex = 84;
            lblLaskuID.Text = "Lasku_id";
            // 
            // tbSumma
            // 
            tbSumma.Location = new Point(113, 188);
            tbSumma.MaxLength = 11;
            tbSumma.Name = "tbSumma";
            tbSumma.ReadOnly = true;
            tbSumma.Size = new Size(125, 27);
            tbSumma.TabIndex = 86;
            // 
            // tbAlv
            // 
            tbAlv.Location = new Point(113, 244);
            tbAlv.MaxLength = 13;
            tbAlv.Name = "tbAlv";
            tbAlv.ReadOnly = true;
            tbAlv.Size = new Size(125, 27);
            tbAlv.TabIndex = 87;
            tbAlv.Text = "24";
            // 
            // tbLaskuID
            // 
            tbLaskuID.Location = new Point(113, 299);
            tbLaskuID.MaxLength = 11;
            tbLaskuID.Name = "tbLaskuID";
            tbLaskuID.Size = new Size(125, 27);
            tbLaskuID.TabIndex = 88;
            tbLaskuID.KeyPress += tbLaskuID_KeyPress;
            // 
            // btnHae
            // 
            btnHae.BackColor = Color.PeachPuff;
            btnHae.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnHae.Location = new Point(254, 127);
            btnHae.Name = "btnHae";
            btnHae.Size = new Size(89, 29);
            btnHae.TabIndex = 89;
            btnHae.Text = "Hae";
            btnHae.UseVisualStyleBackColor = false;
            btnHae.Click += btnHae_Click;
            // 
            // btnLisää
            // 
            btnLisää.BackColor = Color.PeachPuff;
            btnLisää.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLisää.Location = new Point(10, 378);
            btnLisää.Name = "btnLisää";
            btnLisää.Size = new Size(97, 75);
            btnLisää.TabIndex = 90;
            btnLisää.Text = "Lisää";
            btnLisää.UseVisualStyleBackColor = false;
            btnLisää.Click += btnLisää_Click;
            // 
            // cbVarausId
            // 
            cbVarausId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVarausId.FormattingEnabled = true;
            cbVarausId.Location = new Point(97, 128);
            cbVarausId.Name = "cbVarausId";
            cbVarausId.Size = new Size(151, 28);
            cbVarausId.TabIndex = 91;
            // 
            // FormLaskutus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1178, 677);
            Controls.Add(cbVarausId);
            Controls.Add(btnLisää);
            Controls.Add(btnHae);
            Controls.Add(tbLaskuID);
            Controls.Add(tbAlv);
            Controls.Add(tbSumma);
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
        private TextBox tbSumma;
        private TextBox tbAlv;
        private TextBox tbLaskuID;
        private Button btnHae;
        private Button btnLisää;
        private ComboBox cbVarausId;
    }
}