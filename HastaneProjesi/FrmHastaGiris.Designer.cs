namespace HastaneProjesi
{
    partial class FrmHastaGiris
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lnk_uyeol = new System.Windows.Forms.LinkLabel();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(129, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // msk_TC
            // 
            this.msk_TC.Location = new System.Drawing.Point(333, 110);
            this.msk_TC.Mask = "00000000000";
            this.msk_TC.Name = "msk_TC";
            this.msk_TC.Size = new System.Drawing.Size(173, 39);
            this.msk_TC.TabIndex = 3;
            this.msk_TC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msk_TC_MaskInputRejected);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(333, 166);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(173, 39);
            this.txt_sifre.TabIndex = 4;
            // 
            // lnk_uyeol
            // 
            this.lnk_uyeol.AutoSize = true;
            this.lnk_uyeol.Location = new System.Drawing.Point(528, 173);
            this.lnk_uyeol.Name = "lnk_uyeol";
            this.lnk_uyeol.Size = new System.Drawing.Size(100, 32);
            this.lnk_uyeol.TabIndex = 5;
            this.lnk_uyeol.TabStop = true;
            this.lnk_uyeol.Text = "Üye Ol";
            this.lnk_uyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_uyeol_LinkClicked);
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.Location = new System.Drawing.Point(353, 211);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(153, 56);
            this.btn_girisyap.TabIndex = 6;
            this.btn_girisyap.Text = "Giriş Yap";
            this.btn_girisyap.UseVisualStyleBackColor = true;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.btn_girisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 294);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.lnk_uyeol);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.msk_TC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msk_TC;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.LinkLabel lnk_uyeol;
        private System.Windows.Forms.Button btn_girisyap;
    }
}