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
            this.btnTakaisinAloitusFormiin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTakaisinAloitusFormiin
            // 
            this.btnTakaisinAloitusFormiin.Location = new System.Drawing.Point(695, 415);
            this.btnTakaisinAloitusFormiin.Name = "btnTakaisinAloitusFormiin";
            this.btnTakaisinAloitusFormiin.Size = new System.Drawing.Size(93, 23);
            this.btnTakaisinAloitusFormiin.TabIndex = 76;
            this.btnTakaisinAloitusFormiin.Text = "Alkuvalikko";
            this.btnTakaisinAloitusFormiin.UseVisualStyleBackColor = true;
            this.btnTakaisinAloitusFormiin.Click += new System.EventHandler(this.btnTakaisinAloitusFormiin_Click);
            // 
            // FormLaskutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTakaisinAloitusFormiin);
            this.Name = "FormLaskutus";
            this.Text = "FormLaskutus";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTakaisinAloitusFormiin;
    }
}