namespace Mokkivarausjarjestelma
{
    partial class FormMokitJaMokkivaraukset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMokitJaMokkivaraukset));
            this.btnLisaaMokinTiedot = new System.Windows.Forms.Button();
            this.btnMuokkaaValitunMokinTietoja = new System.Windows.Forms.Button();
            this.btnMokkiPoista = new System.Windows.Forms.Button();
            this.btnPaivitaMokkiLista = new System.Windows.Forms.Button();
            this.btnVaraaValittuMokki = new System.Windows.Forms.Button();
            this.btnMokkiHae = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbValittuMokkiHintaVrk = new System.Windows.Forms.TextBox();
            this.rtbValittuMokkiVarustelu = new System.Windows.Forms.RichTextBox();
            this.rtbValittuMokkiKuvaus = new System.Windows.Forms.RichTextBox();
            this.tbValittuMokkiHloMaara = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbValittuMokkiNimi = new System.Windows.Forms.TextBox();
            this.tbValittuMokkiOsoite = new System.Windows.Forms.TextBox();
            this.tbValittuMokkiPostiNro = new System.Windows.Forms.TextBox();
            this.tbValittuMokkiAlueID = new System.Windows.Forms.TextBox();
            this.tbValittuMokkiMokkiID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMokkiID = new System.Windows.Forms.Label();
            this.dgMokkiLista = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMokkiListaOhje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMokkiLista)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLisaaMokinTiedot
            // 
            this.btnLisaaMokinTiedot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLisaaMokinTiedot.Location = new System.Drawing.Point(15, 449);
            this.btnLisaaMokinTiedot.Name = "btnLisaaMokinTiedot";
            this.btnLisaaMokinTiedot.Size = new System.Drawing.Size(140, 30);
            this.btnLisaaMokinTiedot.TabIndex = 56;
            this.btnLisaaMokinTiedot.Text = "Lisää mökin tiedot";
            this.btnLisaaMokinTiedot.UseVisualStyleBackColor = true;
            // 
            // btnMuokkaaValitunMokinTietoja
            // 
            this.btnMuokkaaValitunMokinTietoja.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMuokkaaValitunMokinTietoja.Location = new System.Drawing.Point(166, 449);
            this.btnMuokkaaValitunMokinTietoja.Name = "btnMuokkaaValitunMokinTietoja";
            this.btnMuokkaaValitunMokinTietoja.Size = new System.Drawing.Size(75, 30);
            this.btnMuokkaaValitunMokinTietoja.TabIndex = 61;
            this.btnMuokkaaValitunMokinTietoja.Text = "Muokkaa";
            this.btnMuokkaaValitunMokinTietoja.UseVisualStyleBackColor = true;
            // 
            // btnMokkiPoista
            // 
            this.btnMokkiPoista.Location = new System.Drawing.Point(818, 468);
            this.btnMokkiPoista.Name = "btnMokkiPoista";
            this.btnMokkiPoista.Size = new System.Drawing.Size(138, 23);
            this.btnMokkiPoista.TabIndex = 60;
            this.btnMokkiPoista.Text = "Poista mökki listalta";
            this.btnMokkiPoista.UseVisualStyleBackColor = true;
            // 
            // btnPaivitaMokkiLista
            // 
            this.btnPaivitaMokkiLista.Location = new System.Drawing.Point(398, 468);
            this.btnPaivitaMokkiLista.Name = "btnPaivitaMokkiLista";
            this.btnPaivitaMokkiLista.Size = new System.Drawing.Size(95, 23);
            this.btnPaivitaMokkiLista.TabIndex = 59;
            this.btnPaivitaMokkiLista.Text = "Päivitä Lista";
            this.btnPaivitaMokkiLista.UseVisualStyleBackColor = true;
            // 
            // btnVaraaValittuMokki
            // 
            this.btnVaraaValittuMokki.Location = new System.Drawing.Point(166, 19);
            this.btnVaraaValittuMokki.Name = "btnVaraaValittuMokki";
            this.btnVaraaValittuMokki.Size = new System.Drawing.Size(75, 23);
            this.btnVaraaValittuMokki.TabIndex = 57;
            this.btnVaraaValittuMokki.Text = "Uusi Varaus";
            this.btnVaraaValittuMokki.UseVisualStyleBackColor = true;
            // 
            // btnMokkiHae
            // 
            this.btnMokkiHae.Location = new System.Drawing.Point(250, 468);
            this.btnMokkiHae.Name = "btnMokkiHae";
            this.btnMokkiHae.Size = new System.Drawing.Size(142, 23);
            this.btnMokkiHae.TabIndex = 58;
            this.btnMokkiHae.Text = "Tuo tiedot tekstikenttiin";
            this.btnMokkiHae.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 63;
            // 
            // tbValittuMokkiHintaVrk
            // 
            this.tbValittuMokkiHintaVrk.Location = new System.Drawing.Point(93, 168);
            this.tbValittuMokkiHintaVrk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiHintaVrk.Name = "tbValittuMokkiHintaVrk";
            this.tbValittuMokkiHintaVrk.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiHintaVrk.TabIndex = 52;
            // 
            // rtbValittuMokkiVarustelu
            // 
            this.rtbValittuMokkiVarustelu.Location = new System.Drawing.Point(93, 325);
            this.rtbValittuMokkiVarustelu.Name = "rtbValittuMokkiVarustelu";
            this.rtbValittuMokkiVarustelu.Size = new System.Drawing.Size(148, 118);
            this.rtbValittuMokkiVarustelu.TabIndex = 55;
            this.rtbValittuMokkiVarustelu.Text = "";
            // 
            // rtbValittuMokkiKuvaus
            // 
            this.rtbValittuMokkiKuvaus.Location = new System.Drawing.Point(93, 190);
            this.rtbValittuMokkiKuvaus.Name = "rtbValittuMokkiKuvaus";
            this.rtbValittuMokkiKuvaus.Size = new System.Drawing.Size(148, 112);
            this.rtbValittuMokkiKuvaus.TabIndex = 53;
            this.rtbValittuMokkiKuvaus.Text = "";
            // 
            // tbValittuMokkiHloMaara
            // 
            this.tbValittuMokkiHloMaara.Location = new System.Drawing.Point(93, 302);
            this.tbValittuMokkiHloMaara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiHloMaara.Name = "tbValittuMokkiHloMaara";
            this.tbValittuMokkiHloMaara.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiHloMaara.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(9, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 72;
            this.label11.Text = "Henkilömäärä";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(9, 190);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 71;
            this.label12.Text = "Kuvaus";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(9, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 25);
            this.label13.TabIndex = 69;
            this.label13.Text = "Hinta (/vrk)";
            // 
            // tbValittuMokkiNimi
            // 
            this.tbValittuMokkiNimi.Location = new System.Drawing.Point(93, 122);
            this.tbValittuMokkiNimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiNimi.Name = "tbValittuMokkiNimi";
            this.tbValittuMokkiNimi.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiNimi.TabIndex = 50;
            // 
            // tbValittuMokkiOsoite
            // 
            this.tbValittuMokkiOsoite.Location = new System.Drawing.Point(93, 145);
            this.tbValittuMokkiOsoite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiOsoite.Name = "tbValittuMokkiOsoite";
            this.tbValittuMokkiOsoite.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiOsoite.TabIndex = 51;
            // 
            // tbValittuMokkiPostiNro
            // 
            this.tbValittuMokkiPostiNro.Location = new System.Drawing.Point(93, 99);
            this.tbValittuMokkiPostiNro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiPostiNro.Name = "tbValittuMokkiPostiNro";
            this.tbValittuMokkiPostiNro.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiPostiNro.TabIndex = 49;
            // 
            // tbValittuMokkiAlueID
            // 
            this.tbValittuMokkiAlueID.Location = new System.Drawing.Point(93, 76);
            this.tbValittuMokkiAlueID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiAlueID.Name = "tbValittuMokkiAlueID";
            this.tbValittuMokkiAlueID.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiAlueID.TabIndex = 48;
            // 
            // tbValittuMokkiMokkiID
            // 
            this.tbValittuMokkiMokkiID.Location = new System.Drawing.Point(93, 51);
            this.tbValittuMokkiMokkiID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValittuMokkiMokkiID.Name = "tbValittuMokkiMokkiID";
            this.tbValittuMokkiMokkiID.Size = new System.Drawing.Size(148, 23);
            this.tbValittuMokkiMokkiID.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 45);
            this.label6.TabIndex = 70;
            this.label6.Text = "Varustelu";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 68;
            this.label7.Text = "Lähiosoite";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 122);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 67;
            this.label8.Text = "Mökin nimi";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(9, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 66;
            this.label9.Text = "Postinro";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(9, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 21);
            this.label10.TabIndex = 65;
            this.label10.Text = "Alue_ID";
            // 
            // lblMokkiID
            // 
            this.lblMokkiID.Location = new System.Drawing.Point(9, 57);
            this.lblMokkiID.Name = "lblMokkiID";
            this.lblMokkiID.Size = new System.Drawing.Size(88, 24);
            this.lblMokkiID.TabIndex = 64;
            this.lblMokkiID.Text = "Mokki_ID";
            // 
            // dgMokkiLista
            // 
            this.dgMokkiLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMokkiLista.Location = new System.Drawing.Point(250, 13);
            this.dgMokkiLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgMokkiLista.Name = "dgMokkiLista";
            this.dgMokkiLista.RowHeadersWidth = 51;
            this.dgMokkiLista.RowTemplate.Height = 29;
            this.dgMokkiLista.Size = new System.Drawing.Size(706, 450);
            this.dgMokkiLista.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblMokkiListaOhje);
            this.panel2.Location = new System.Drawing.Point(4, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 117);
            this.panel2.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "HUOMIO!";
            // 
            // lblMokkiListaOhje
            // 
            this.lblMokkiListaOhje.AutoSize = true;
            this.lblMokkiListaOhje.Location = new System.Drawing.Point(3, 25);
            this.lblMokkiListaOhje.Name = "lblMokkiListaOhje";
            this.lblMokkiListaOhje.Size = new System.Drawing.Size(631, 30);
            this.lblMokkiListaOhje.TabIndex = 43;
            this.lblMokkiListaOhje.Text = resources.GetString("lblMokkiListaOhje.Text");
            // 
            // FormMokitJaMokkivaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 626);
            this.Controls.Add(this.btnLisaaMokinTiedot);
            this.Controls.Add(this.btnMuokkaaValitunMokinTietoja);
            this.Controls.Add(this.btnMokkiPoista);
            this.Controls.Add(this.btnPaivitaMokkiLista);
            this.Controls.Add(this.btnVaraaValittuMokki);
            this.Controls.Add(this.btnMokkiHae);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbValittuMokkiHintaVrk);
            this.Controls.Add(this.rtbValittuMokkiVarustelu);
            this.Controls.Add(this.rtbValittuMokkiKuvaus);
            this.Controls.Add(this.tbValittuMokkiHloMaara);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbValittuMokkiNimi);
            this.Controls.Add(this.tbValittuMokkiOsoite);
            this.Controls.Add(this.tbValittuMokkiPostiNro);
            this.Controls.Add(this.tbValittuMokkiAlueID);
            this.Controls.Add(this.tbValittuMokkiMokkiID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblMokkiID);
            this.Controls.Add(this.dgMokkiLista);
            this.Controls.Add(this.panel2);
            this.Name = "FormMokitJaMokkivaraukset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMokitJaMokkivaraukset";
            ((System.ComponentModel.ISupportInitialize)(this.dgMokkiLista)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLisaaMokinTiedot;
        private Button btnMuokkaaValitunMokinTietoja;
        private Button btnMokkiPoista;
        private Button btnPaivitaMokkiLista;
        private Button btnVaraaValittuMokki;
        private Button btnMokkiHae;
        private Label label5;
        private TextBox tbValittuMokkiHintaVrk;
        private RichTextBox rtbValittuMokkiVarustelu;
        private RichTextBox rtbValittuMokkiKuvaus;
        private TextBox tbValittuMokkiHloMaara;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox tbValittuMokkiNimi;
        private TextBox tbValittuMokkiOsoite;
        private TextBox tbValittuMokkiPostiNro;
        private TextBox tbValittuMokkiAlueID;
        private TextBox tbValittuMokkiMokkiID;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblMokkiID;
        private DataGridView dgMokkiLista;
        private Panel panel2;
        private Label label1;
        private Label lblMokkiListaOhje;
    }
}