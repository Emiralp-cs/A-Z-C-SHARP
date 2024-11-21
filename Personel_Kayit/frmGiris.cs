using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Personel_Kayit
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=fatih\\;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_yonetici where KullaniciAdi=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_KullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
