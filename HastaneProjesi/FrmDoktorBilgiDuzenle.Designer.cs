namespace HastaneProjesi
{
    partial class FrmDoktorBilgiDuzenle
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
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_bilgiduzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(214, 110);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(173, 39);
            this.txt_soyad.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 32);
            this.label5.TabIndex = 33;
            this.label5.Text = "Soyad:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(214, 65);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(173, 39);
            this.txt_Ad.TabIndex = 32;
            // 
            // msk_TC
            // 
            this.msk_TC.Location = new System.Drawing.Point(214, 155);
            this.msk_TC.Mask = "00000000000";
            this.msk_TC.Name = "msk_TC";
            this.msk_TC.Size = new System.Drawing.Size(173, 39);
            this.msk_TC.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 32);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "TC Kimlik No:";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(214, 243);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(173, 39);
            this.txt_Sifre.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Şifre:";
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(214, 197);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(173, 40);
            this.cmb_brans.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "Branş:";
            // 
            // btn_bilgiduzenle
            // 
            this.btn_bilgiduzenle.BackColor = System.Drawing.Color.Silver;
            this.btn_bilgiduzenle.Location = new System.Drawing.Point(217, 288);
            this.btn_bilgiduzenle.Name = "btn_bilgiduzenle";
            this.btn_bilgiduzenle.Size = new System.Drawing.Size(170, 60);
            this.btn_bilgiduzenle.TabIndex = 39;
            this.btn_bilgiduzenle.Text = "Güncelle";
            this.btn_bilgiduzenle.UseVisualStyleBackColor = false;
            this.btn_bilgiduzenle.Click += new System.EventHandler(this.btn_bilgiduzenle_Click);
            // 
            // FrmDoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 385);
            this.Controls.Add(this.btn_bilgiduzenle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_brans);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.msk_TC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDoktorBilgiDuzenle";
            this.Text = "FrmDoktorBilgiDuzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.MaskedTextBox msk_TC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_bilgiduzenle;
    }
}