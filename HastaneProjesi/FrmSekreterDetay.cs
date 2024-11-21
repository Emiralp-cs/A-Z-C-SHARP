using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneProjesi
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay(string id, string tarih, string saat, string brans, string doktor, string durum, string hastatc)

        {
            InitializeComponent();
            txt_id.Text = id;
            msk_Tarih.Text = tarih;
            msk_saat.Text = saat;
            cmb_brans.Text = brans;
            cmb_doktorlar.Text = doktor;
            msk_tc.Text = doktor;


        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tc;

        private void FrmSekreterDetay_Load(object sender, System.EventArgs e)
        {

            //Tc verisini sekreter giriş ekranından çekme
            lbl_tc.Text = tc;

            SqlCommand komut4 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTc=@z1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@z1", lbl_tc.Text);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lbl_adsoyad.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();




            //Branş Combo Box'ına sql den verileri çekme
            SqlCommand komut1 = new SqlCommand("Select BransAd From Tbl_Branslarr", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmb_brans.Items.Add(dr1[0].ToString());
            }
            bgl.baglanti().Close();

            //Branşları DataGride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd from Tbl_branslarr", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları Listeye Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + '  ' + DoktorSoyad) as Doktorlar, DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void cmb_brans_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            cmb_doktorlar.Items.Clear();
            SqlCommand komut2 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_doktorlar.Items.Add(dr2[0] + " " + dr2[1]);
            }
            bgl.baglanti().Close();
        }

        private void btn_kaydet_Click(object sender, System.EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,Randevudoktor) values(@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", msk_Tarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msk_saat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmb_brans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmb_doktorlar.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_duyuruolustur_Click(object sender, System.EventArgs e)
        {
            SqlCommand komutduyuru = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komutduyuru.Parameters.AddWithValue("@d1", rtb_duyuru.Text);
            komutduyuru.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_doktorpanel_Click(object sender, System.EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
        }



        private void button2_Click(object sender, System.EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
            this.Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            FrmBransPaneli frp = new FrmBransPaneli();
            frp.Show();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }


    }
}
