namespace EntityProje
{
    partial class FrmAnaForm
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
            this.btn_kategori = new System.Windows.Forms.Button();
            this.btn_urunislemleri = new System.Windows.Forms.Button();
            this.btn_istatistikler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kategori
            // 
            this.btn_kategori.Location = new System.Drawing.Point(12, 12);
            this.btn_kategori.Name = "btn_kategori";
            this.btn_kategori.Size = new System.Drawing.Size(167, 54);
            this.btn_kategori.TabIndex = 0;
            this.btn_kategori.Text = "Kategori İşlemleri";
            this.btn_kategori.UseVisualStyleBackColor = true;
            this.btn_kategori.Click += new System.EventHandler(this.btn_kategori_Click);
            // 
            // btn_urunislemleri
            // 
            this.btn_urunislemleri.Location = new System.Drawing.Point(12, 72);
            this.btn_urunislemleri.Name = "btn_urunislemleri";
            this.btn_urunislemleri.Size = new System.Drawing.Size(167, 54);
            this.btn_urunislemleri.TabIndex = 1;
            this.btn_urunislemleri.Text = "Ürün İşlemleri";
            this.btn_urunislemleri.UseVisualStyleBackColor = true;
            this.btn_urunislemleri.Click += new System.EventHandler(this.btn_urunislemleri_Click);
            // 
            // btn_istatistikler
            // 
            this.btn_istatistikler.Location = new System.Drawing.Point(11, 133);
            this.btn_istatistikler.Name = "btn_istatistikler";
            this.btn_istatistikler.Size = new System.Drawing.Size(167, 54);
            this.btn_istatistikler.TabIndex = 2;
            this.btn_istatistikler.Text = "İstatistikler";
            this.btn_istatistikler.UseVisualStyleBackColor = true;
            this.btn_istatistikler.Click += new System.EventHandler(this.btn_istatistikler_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 194);
            this.Controls.Add(this.btn_istatistikler);
            this.Controls.Add(this.btn_urunislemleri);
            this.Controls.Add(this.btn_kategori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kategori;
        private System.Windows.Forms.Button btn_urunislemleri;
        private System.Windows.Forms.Button btn_istatistikler;
    }
}