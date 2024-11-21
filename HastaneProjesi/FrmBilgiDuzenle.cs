using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneProjesi
{
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select * from Tbl_Hastalar where HastaTc=" + tc, bgl.baglanti());
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                txt_Ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                msk_TC.Text = dr[3].ToString();
                msk_Telefon.Text = dr[4].ToString();
                txt_Sifre.Text = dr[5].ToString();
                Cmb_Cinsiyet.Text = dr[6].ToString();


            }
            bgl.baglanti().Close();


        }

        private void btn_bilgiduzenle_Click(object sender, EventArgs e)
        {

            SqlCommand komut2 = new SqlCommand("Update Tbl_Hastalar Set HastaAd=@a1,HastaSoyad=@a2,HastaTelefon=@a3,HastaSifre=@a4,HastaCinsiyet=@a5 where HastaTc=" + tc, bgl.baglanti());
            komut2.Parameters.AddWithValue("@a1", txt_Ad.Text);
            komut2.Parameters.AddWithValue("@a2", txt_soyad.Text);
            komut2.Parameters.AddWithValue("@a3", msk_Telefon.Text);
            komut2.Parameters.AddWithValue("@a4", txt_Sifre.Text);
            komut2.Parameters.AddWithValue("@a5", Cmb_Cinsiyet.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
