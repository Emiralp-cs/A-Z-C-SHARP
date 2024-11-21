namespace HastaneProjesi
{
    partial class FrmHastaKayit
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
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msk_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cmb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_kayitol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(206, 76);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(173, 39);
            this.txt_Ad.TabIndex = 0;
            // 
            // msk_TC
            // 
            this.msk_TC.Location = new System.Drawing.Point(206, 166);
            this.msk_TC.Mask = "00000000000";
            this.msk_TC.Name = "msk_TC";
            this.msk_TC.Size = new System.Drawing.Size(173, 39);
            this.msk_TC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No:";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(206, 256);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(173, 39);
            this.txt_Sifre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şifre:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(206, 121);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(173, 39);
            this.txt_soyad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Soyad:";
            // 
            // msk_Telefon
            // 
            this.msk_Telefon.Location = new System.Drawing.Point(206, 211);
            this.msk_Telefon.Mask = "(999) 000-0000";
            this.msk_Telefon.Name = "msk_Telefon";
            this.msk_Telefon.Size = new System.Drawing.Size(173, 39);
            this.msk_Telefon.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefon:";
            // 
            // Cmb_Cinsiyet
            // 
            this.Cmb_Cinsiyet.FormattingEnabled = true;
            this.Cmb_Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.Cmb_Cinsiyet.Location = new System.Drawing.Point(206, 301);
            this.Cmb_Cinsiyet.Name = "Cmb_Cinsiyet";
            this.Cmb_Cinsiyet.Size = new System.Drawing.Size(173, 40);
            this.Cmb_Cinsiyet.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cinsiyet:";
            // 
            // btn_kayitol
            // 
            this.btn_kayitol.BackColor = System.Drawing.Color.Silver;
            this.btn_kayitol.Location = new System.Drawing.Point(209, 347);
            this.btn_kayitol.Name = "btn_kayitol";
            this.btn_kayitol.Size = new System.Drawing.Size(170, 60);
            this.btn_kayitol.TabIndex = 6;
            this.btn_kayitol.Text = "Kayıt Yap";
            this.btn_kayitol.UseVisualStyleBackColor = false;
            this.btn_kayitol.Click += new System.EventHandler(this.btn_kayitol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 52);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hasta Kayıt Ekranı";
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btn_kayitol;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kayitol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cmb_Cinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msk_Telefon);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.msk_TC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.Load += new System.EventHandler(this.Frm_UyeOl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.MaskedTextBox msk_TC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msk_Telefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cmb_Cinsiyet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_kayitol;
        private System.Windows.Forms.Label label1;
    }
}