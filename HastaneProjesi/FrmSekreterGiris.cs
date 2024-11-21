using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace HastaneProjesi
{
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTc=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_TC.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                FrmSekreterDetay fr = new FrmSekreterDetay(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                fr.tc = msk_TC.Text;
                fr.Show();


            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
