namespace HastaneProjesi
{
    partial class FrmBilgiDuzenle
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_bilgiduzenle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Cmb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msk_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 52);
            this.label1.TabIndex = 34;
            this.label1.Text = "Hasta Bilgi Düzenle";
            // 
            // btn_bilgiduzenle
            // 
            this.btn_bilgiduzenle.BackColor = System.Drawing.Color.Silver;
            this.btn_bilgiduzenle.Location = new System.Drawing.Point(234, 372);
            this.btn_bilgiduzenle.Name = "btn_bilgiduzenle";
            this.btn_bilgiduzenle.Size = new System.Drawing.Size(170, 60);
            this.btn_bilgiduzenle.TabIndex = 33;
            this.btn_bilgiduzenle.Text = "Güncelle";
            this.btn_bilgiduzenle.UseVisualStyleBackColor = false;
            this.btn_bilgiduzenle.Click += new System.EventHandler(this.btn_bilgiduzenle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 32);
            this.label7.TabIndex = 32;
            this.label7.Text = "Cinsiyet:";
            // 
            // Cmb_Cinsiyet
            // 
            this.Cmb_Cinsiyet.FormattingEnabled = true;
            this.Cmb_Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.Cmb_Cinsiyet.Location = new System.Drawing.Point(231, 326);
            this.Cmb_Cinsiyet.Name = "Cmb_Cinsiyet";
            this.Cmb_Cinsiyet.Size = new System.Drawing.Size(173, 40);
            this.Cmb_Cinsiyet.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 30;
            this.label6.Text = "Telefon:";
            // 
            // msk_Telefon
            // 
            this.msk_Telefon.Location = new System.Drawing.Point(231, 236);
            this.msk_Telefon.Mask = "(999) 000-0000";
            this.msk_Telefon.Name = "msk_Telefon";
            this.msk_Telefon.Size = new System.Drawing.Size(173, 39);
            this.msk_Telefon.TabIndex = 29;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(231, 146);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(173, 39);
            this.txt_soyad.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Soyad:";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(231, 281);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(173, 39);
            this.txt_Sifre.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Şifre:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(231, 101);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(173, 39);
            this.txt_Ad.TabIndex = 24;
            // 
            // msk_TC
            // 
            this.msk_TC.Location = new System.Drawing.Point(231, 191);
            this.msk_TC.Mask = "00000000000";
            this.msk_TC.Name = "msk_TC";
            this.msk_TC.Size = new System.Drawing.Size(173, 39);
            this.msk_TC.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "TC Kimlik No:";
            // 
            // FrmBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_bilgiduzenle);
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
            this.Name = "FrmBilgiDuzenle";
            this.Text = "FrmBilgiDuzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_bilgiduzenle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cmb_Cinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msk_Telefon;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.MaskedTextBox msk_TC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}