using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneProjesi
{
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglantisi = new SqlBaglantisi();
        private void Frm_UyeOl_Load(object sender, EventArgs e)
        {

        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", msk_TC.Text);
            komut.Parameters.AddWithValue("@p4", msk_Telefon.Text);
            komut.Parameters.AddWithValue("@p5", txt_Sifre.Text);
            komut.Parameters.AddWithValue("@p6", Cmb_Cinsiyet.Text);
            komut.ExecuteNonQuery();
            baglantisi.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz: " + txt_Sifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
