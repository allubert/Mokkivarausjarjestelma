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
            btnPoistaLasku = new Button();
            btnLahetalasku = new Button();
            dgvLaskutus = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLaskutus).BeginInit();
            SuspendLayout();
            // 
            // btnTakaisinAloitusFormiin
            // 
            btnTakaisinAloitusFormiin.BackColor = Color.Yellow;
            btnTakaisinAloitusFormiin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTakaisinAloitusFormiin.Location = new Point(940, 608);
            btnTakaisinAloitusFormiin.Margin = new Padding(3, 4, 3, 4);
            btnTakaisinAloitusFormiin.Name = "btnTakaisinAloitusFormiin";
            btnTakaisinAloitusFormiin.Size = new Size(216, 102);
            btnTakaisinAloitusFormiin.TabIndex = 76;
            btnTakaisinAloitusFormiin.Text = "Alkuvalikko";
            btnTakaisinAloitusFormiin.UseVisualStyleBackColor = false;
            btnTakaisinAloitusFormiin.Click += btnTakaisinAloitusFormiin_Click;
            // 
            // btnPoistaLasku
            // 
            btnPoistaLasku.BackColor = Color.Yellow;
            btnPoistaLasku.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPoistaLasku.Location = new Point(218, 608);
            btnPoistaLasku.Name = "btnPoistaLasku";
            btnPoistaLasku.Size = new Size(196, 103);
            btnPoistaLasku.TabIndex = 79;
            btnPoistaLasku.Text = "Poista lasku";
            btnPoistaLasku.UseVisualStyleBackColor = false;
            btnPoistaLasku.Click += btnPoistaLasku_Click;
            // 
            // btnLahetalasku
            // 
            btnLahetalasku.BackColor = Color.Yellow;
            btnLahetalasku.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLahetalasku.Location = new Point(12, 608);
            btnLahetalasku.Name = "btnLahetalasku";
            btnLahetalasku.Size = new Size(200, 103);
            btnLahetalasku.TabIndex = 78;
            btnLahetalasku.Text = "Tallenna lasku";
            btnLahetalasku.UseVisualStyleBackColor = false;
            btnLahetalasku.Click += btnLahetalasku_Click;
            // 
            // dgvLaskutus
            // 
            dgvLaskutus.BackgroundColor = Color.Navy;
            dgvLaskutus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaskutus.Location = new Point(12, 2);
            dgvLaskutus.Name = "dgvLaskutus";
            dgvLaskutus.ReadOnly = true;
            dgvLaskutus.RowHeadersWidth = 51;
            dgvLaskutus.RowTemplate.Height = 29;
            dgvLaskutus.Size = new Size(1135, 577);
            dgvLaskutus.TabIndex = 77;
            // 
            // FormLaskutus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1178, 723);
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
        private Button btnPoistaLasku;
        private Button btnLahetalasku;
        private DataGridView dgvLaskutus;
    }
}