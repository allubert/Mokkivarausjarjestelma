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
            btnTakaisinAloitusFormiin = new Button();
            btnTulosta = new Button();
            btnPoistaLasku = new Button();
            btnLahetalasku = new Button();
            dgvLaskutus = new DataGridView();
            tbLaskutusid = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbSahkoposti = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLaskutus).BeginInit();
            SuspendLayout();
            // 
            // btnTakaisinAloitusFormiin
            // 
            btnTakaisinAloitusFormiin.Location = new Point(12, 679);
            btnTakaisinAloitusFormiin.Margin = new Padding(3, 4, 3, 4);
            btnTakaisinAloitusFormiin.Name = "btnTakaisinAloitusFormiin";
            btnTakaisinAloitusFormiin.Size = new Size(106, 31);
            btnTakaisinAloitusFormiin.TabIndex = 76;
            btnTakaisinAloitusFormiin.Text = "Alkuvalikko";
            btnTakaisinAloitusFormiin.UseVisualStyleBackColor = true;
            btnTakaisinAloitusFormiin.Click += btnTakaisinAloitusFormiin_Click;
            // 
            // btnTulosta
            // 
            btnTulosta.Location = new Point(220, 571);
            btnTulosta.Name = "btnTulosta";
            btnTulosta.Size = new Size(109, 42);
            btnTulosta.TabIndex = 80;
            btnTulosta.Text = "Tulosta lasku";
            btnTulosta.UseVisualStyleBackColor = true;
            // 
            // btnPoistaLasku
            // 
            btnPoistaLasku.Location = new Point(109, 571);
            btnPoistaLasku.Name = "btnPoistaLasku";
            btnPoistaLasku.Size = new Size(105, 39);
            btnPoistaLasku.TabIndex = 79;
            btnPoistaLasku.Text = "Poista lasku";
            btnPoistaLasku.UseVisualStyleBackColor = true;
            // 
            // btnLahetalasku
            // 
            btnLahetalasku.Location = new Point(12, 571);
            btnLahetalasku.Name = "btnLahetalasku";
            btnLahetalasku.Size = new Size(91, 42);
            btnLahetalasku.TabIndex = 78;
            btnLahetalasku.Text = "Lähetä lasku";
            btnLahetalasku.UseVisualStyleBackColor = true;
            btnLahetalasku.Click += btnLahetalasku_Click;
            // 
            // dgvLaskutus
            // 
            dgvLaskutus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaskutus.Location = new Point(335, 3);
            dgvLaskutus.Name = "dgvLaskutus";
            dgvLaskutus.ReadOnly = true;
            dgvLaskutus.RowHeadersWidth = 51;
            dgvLaskutus.RowTemplate.Height = 29;
            dgvLaskutus.Size = new Size(831, 571);
            dgvLaskutus.TabIndex = 77;
            dgvLaskutus.Click += dgvLaskutus_Click;
            // 
            // tbLaskutusid
            // 
            tbLaskutusid.Location = new Point(109, 59);
            tbLaskutusid.Name = "tbLaskutusid";
            tbLaskutusid.Size = new Size(149, 27);
            tbLaskutusid.TabIndex = 81;
            // 
            // label1
            // 
            label1.Location = new Point(14, 62);
            label1.Name = "label1";
            label1.Size = new Size(89, 40);
            label1.TabIndex = 82;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Location = new Point(14, 117);
            label2.Name = "label2";
            label2.Size = new Size(89, 40);
            label2.TabIndex = 83;
            label2.Text = "label2";
            // 
            // tbSahkoposti
            // 
            tbSahkoposti.Location = new Point(109, 117);
            tbSahkoposti.Name = "tbSahkoposti";
            tbSahkoposti.Size = new Size(149, 27);
            tbSahkoposti.TabIndex = 84;
            // 
            // FormLaskutus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 723);
            Controls.Add(tbSahkoposti);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbLaskutusid);
            Controls.Add(btnTulosta);
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
        private Button btnTulosta;
        private Button btnPoistaLasku;
        private Button btnLahetalasku;
        private DataGridView dgvLaskutus;
        private TextBox tbLaskutusid;
        private Label label1;
        private Label label2;
        private TextBox tbSahkoposti;
    }
}