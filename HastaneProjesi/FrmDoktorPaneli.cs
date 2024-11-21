using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneProjesi
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (Doktorad,DoktorSoyad,Doktorbrans,DoktorTc,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txt_ad.Text);
            komut.Parameters.AddWithValue("@d2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@d3", cmb_brans.Text);
            komut.Parameters.AddWithValue("@d4", msk_tc.Text);
            komut.Parameters.AddWithValue("@d5", txt_sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);





        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msk_tc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
