using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace HastaneProjesi
{
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            msk_TC.Text = tc;

            SqlCommand komut = new SqlCommand("Select * From tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_TC.Text);
            SqlDataReader dt = komut.ExecuteReader();
            while (dt.Read())
            {
                txt_Ad.Text = dt[1].ToString();
                txt_soyad.Text = dt[2].ToString();
                cmb_brans.Text = dt[3].ToString();
                txt_Sifre.Text = dt[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btn_bilgiduzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar Set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut.Parameters.AddWithValue("p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", cmb_brans.Text);
            komut.Parameters.AddWithValue("@p4", txt_Sifre.Text);
            komut.Parameters.AddWithValue("@p5", msk_TC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
