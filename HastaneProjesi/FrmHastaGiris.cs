using System.Data.SqlClient;
using System.Windows.Forms;
namespace HastaneProjesi
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglantisi = new SqlBaglantisi();
        private void FrmHastaGiris_Load(object sender, System.EventArgs e)
        {

        }

        private void lnk_uyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();

        }

        private void msk_TC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_girisyap_Click(object sender, System.EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTc='" + msk_TC.Text + "' and " + "HastaSifre='" + txt_sifre.Text + "'", baglantisi.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = msk_TC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglantisi.baglanti().Close();
        }
    }
}
