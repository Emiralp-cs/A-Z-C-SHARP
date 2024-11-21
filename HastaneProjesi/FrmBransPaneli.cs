using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneProjesi
{
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_branslarr", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into Tbl_branslarr (BransAd) values (@b1)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@b1", txt_ad.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsilme = new SqlCommand("Delete From Tbl_branslarr where Bransad=@b1", bgl.baglanti());
            komutsilme.Parameters.AddWithValue("@b1", txt_ad.Text);
            komutsilme.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update Tbl_Branslarr set BransAd=@s1 where bransid=@s2", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@s1", txt_ad.Text);
            komutguncelle.Parameters.AddWithValue("@s2", txt_id.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
