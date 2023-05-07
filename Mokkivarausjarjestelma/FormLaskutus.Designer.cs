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
            ((System.ComponentModel.ISupportInitialize)dgvLaskutus).BeginInit();
            SuspendLayout();
            // 
            // btnTakaisinAloitusFormiin
            // 
            btnTakaisinAloitusFormiin.Location = new Point(982, 617);
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
            btnTulosta.Location = new Point(329, 591);
            btnTulosta.Name = "btnTulosta";
            btnTulosta.Size = new Size(146, 83);
            btnTulosta.TabIndex = 80;
            btnTulosta.Text = "Tulosta lasku";
            btnTulosta.UseVisualStyleBackColor = true;
            // 
            // btnPoistaLasku
            // 
            btnPoistaLasku.Location = new Point(167, 591);
            btnPoistaLasku.Name = "btnPoistaLasku";
            btnPoistaLasku.Size = new Size(156, 83);
            btnPoistaLasku.TabIndex = 79;
            btnPoistaLasku.Text = "Poista lasku";
            btnPoistaLasku.UseVisualStyleBackColor = true;
            // 
            // btnLahetalasku
            // 
            btnLahetalasku.Location = new Point(12, 591);
            btnLahetalasku.Name = "btnLahetalasku";
            btnLahetalasku.Size = new Size(149, 83);
            btnLahetalasku.TabIndex = 78;
            btnLahetalasku.Text = "Lähetä lasku";
            btnLahetalasku.UseVisualStyleBackColor = true;
            btnLahetalasku.Click += btnLahetalasku_Click;
            // 
            // dgvLaskutus
            // 
            dgvLaskutus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaskutus.Location = new Point(12, 12);
            dgvLaskutus.Name = "dgvLaskutus";
            dgvLaskutus.RowHeadersWidth = 51;
            dgvLaskutus.RowTemplate.Height = 29;
            dgvLaskutus.Size = new Size(1063, 571);
            dgvLaskutus.TabIndex = 77;
            // 
            // FormLaskutus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 696);
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
        }

        #endregion

        private Button btnTakaisinAloitusFormiin;
        private Button btnTulosta;
        private Button btnPoistaLasku;
        private Button btnLahetalasku;
        private DataGridView dgvLaskutus;
    }
}