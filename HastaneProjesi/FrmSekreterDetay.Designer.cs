namespace HastaneProjesi
{
    partial class FrmSekreterDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_duyuruolustur = new System.Windows.Forms.Button();
            this.rtb_duyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.chk_durum = new System.Windows.Forms.CheckBox();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.cmb_doktorlar = new System.Windows.Forms.ComboBox();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.msk_saat = new System.Windows.Forms.MaskedTextBox();
            this.msk_Tarih = new System.Windows.Forms.MaskedTextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_doktorpanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_adsoyad);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(188, 107);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(121, 32);
            this.lbl_adsoyad.TabIndex = 3;
            this.lbl_adsoyad.Text = "Null Null";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(188, 55);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(190, 32);
            this.lbl_tc.TabIndex = 2;
            this.lbl_tc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_duyuruolustur);
            this.groupBox2.Controls.Add(this.rtb_duyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 314);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btn_duyuruolustur
            // 
            this.btn_duyuruolustur.Location = new System.Drawing.Point(6, 255);
            this.btn_duyuruolustur.Name = "btn_duyuruolustur";
            this.btn_duyuruolustur.Size = new System.Drawing.Size(396, 53);
            this.btn_duyuruolustur.TabIndex = 1;
            this.btn_duyuruolustur.Text = "Oluştur";
            this.btn_duyuruolustur.UseVisualStyleBackColor = true;
            this.btn_duyuruolustur.Click += new System.EventHandler(this.btn_duyuruolustur_Click);
            // 
            // rtb_duyuru
            // 
            this.rtb_duyuru.Location = new System.Drawing.Point(6, 38);
            this.rtb_duyuru.Name = "rtb_duyuru";
            this.rtb_duyuru.Size = new System.Drawing.Size(396, 211);
            this.rtb_duyuru.TabIndex = 0;
            this.rtb_duyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_kaydet);
            this.groupBox3.Controls.Add(this.chk_durum);
            this.groupBox3.Controls.Add(this.msk_tc);
            this.groupBox3.Controls.Add(this.cmb_doktorlar);
            this.groupBox3.Controls.Add(this.cmb_brans);
            this.groupBox3.Controls.Add(this.msk_saat);
            this.groupBox3.Controls.Add(this.msk_Tarih);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(426, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 484);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(127, 374);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(180, 45);
            this.btn_kaydet.TabIndex = 14;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // chk_durum
            // 
            this.chk_durum.AutoSize = true;
            this.chk_durum.Location = new System.Drawing.Point(129, 332);
            this.chk_durum.Name = "chk_durum";
            this.chk_durum.Size = new System.Drawing.Size(124, 36);
            this.chk_durum.TabIndex = 13;
            this.chk_durum.Text = "Durum";
            this.chk_durum.UseVisualStyleBackColor = true;
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(127, 287);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(181, 39);
            this.msk_tc.TabIndex = 12;
            this.msk_tc.ValidatingType = typeof(int);
            // 
            // cmb_doktorlar
            // 
            this.cmb_doktorlar.FormattingEnabled = true;
            this.cmb_doktorlar.Location = new System.Drawing.Point(127, 241);
            this.cmb_doktorlar.Name = "cmb_doktorlar";
            this.cmb_doktorlar.Size = new System.Drawing.Size(181, 40);
            this.cmb_doktorlar.TabIndex = 11;
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(127, 195);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(181, 40);
            this.cmb_brans.TabIndex = 10;
            this.cmb_brans.SelectedIndexChanged += new System.EventHandler(this.cmb_brans_SelectedIndexChanged);
            // 
            // msk_saat
            // 
            this.msk_saat.Location = new System.Drawing.Point(127, 149);
            this.msk_saat.Mask = "00:00";
            this.msk_saat.Name = "msk_saat";
            this.msk_saat.Size = new System.Drawing.Size(181, 39);
            this.msk_saat.TabIndex = 9;
            this.msk_saat.ValidatingType = typeof(System.DateTime);
            // 
            // msk_Tarih
            // 
            this.msk_Tarih.Location = new System.Drawing.Point(127, 104);
            this.msk_Tarih.Mask = "00/00/0000";
            this.msk_Tarih.Name = "msk_Tarih";
            this.msk_Tarih.Size = new System.Drawing.Size(181, 39);
            this.msk_Tarih.TabIndex = 8;
            this.msk_Tarih.ValidatingType = typeof(System.DateTime);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(127, 59);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(181, 39);
            this.txt_id.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 32);
            this.label11.TabIndex = 6;
            this.label11.Text = "Branş:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 32);
            this.label9.TabIndex = 4;
            this.label9.Text = "TC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Doktor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "id:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(802, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(608, 326);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(602, 288);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(802, 344);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(608, 307);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(602, 269);
            this.dataGridView2.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btn_doktorpanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 502);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(784, 149);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(573, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 57);
            this.button3.TabIndex = 5;
            this.button3.Text = "Duyurular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "Randevu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Branş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_doktorpanel
            // 
            this.btn_doktorpanel.Location = new System.Drawing.Point(45, 66);
            this.btn_doktorpanel.Name = "btn_doktorpanel";
            this.btn_doktorpanel.Size = new System.Drawing.Size(167, 57);
            this.btn_doktorpanel.TabIndex = 0;
            this.btn_doktorpanel.Text = "Doktor";
            this.btn_doktorpanel.UseVisualStyleBackColor = true;
            this.btn_doktorpanel.Click += new System.EventHandler(this.btn_doktorpanel_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 657);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSekreterDetay";
            this.Text = "FrmSekreterDetay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_duyuruolustur;
        private System.Windows.Forms.RichTextBox rtb_duyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox msk_Tarih;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.CheckBox chk_durum;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.ComboBox cmb_doktorlar;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.MaskedTextBox msk_saat;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_doktorpanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}