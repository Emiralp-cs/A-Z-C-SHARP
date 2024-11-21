using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Personel_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=fatih\\;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.Tbl_Personel' table. You can move, or remove it, as needed.

        }

        void Temizle()
        {
            txt_ad.Text = string.Empty;
            txt_Personelid.Text = string.Empty;
            txt_meslek.Text = string.Empty;
            txt_soyad.Text = string.Empty;
            msk_maas.Text = string.Empty;
            comboBox1.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txt_ad.Focus();


        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }
        //Insert(Ekle)
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerDurum,PerMeslek) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut.Parameters.AddWithValue("@p4", msk_maas.Text);
            komut.Parameters.AddWithValue("@p5", label8.Text);
            komut.Parameters.AddWithValue("@p6", txt_meslek.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "False";
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txt_Personelid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msk_maas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_meslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            label9.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            if (label9.Text == "True")
            {
                radioButton1.Checked = true;

            }
            else if (label9.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }
        //Delete(Sil)
        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txt_Personelid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Update(Güncelle)
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txt_ad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txt_soyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", comboBox1.Text);
            komutguncelle.Parameters.AddWithValue("@a4", msk_maas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txt_meslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txt_Personelid.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_istatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistikler fr = new Frmİstatistikler();
            fr.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_grafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frg = new FrmGrafikler();
            frg.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

