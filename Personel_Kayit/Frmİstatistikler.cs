using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Personel_Kayit
{
    public partial class Frmİstatistikler : Form
    {
        public Frmİstatistikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=fatih\\;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select Count(*) From Tbl_Personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {

                lbl_toplam_personel.Text = dr1[0].ToString();

            }
            baglanti.Close();

            //Evli Personel Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select Count(*) From Tbl_Personel where PerDurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lbl_evli_personel.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //Bekar Personel Sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select Count(*) From Tbl_Personel where PerDurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lbl_bekar_personel.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //Sehir Sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select Count(distinct(Persehir)) From tbl_personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lbl_sehir_sayisi.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //Toplam Maaş
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select Sum(PerMaas) From tbl_personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lbl_toplam_maas.Text = dr5[0].ToString();

            }
            baglanti.Close();

            //Ortalama Maaş

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select avg(PerMaas) From tbl_personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lbl_ortalama_maas.Text = dr6[0].ToString();
            }



        }
    }
}