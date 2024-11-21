using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace HastaneProjesi
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        public string TC;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbl_Tc.Text = TC;

            //Doktor Ad Soyad
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_Tc.Text);
            komut.ExecuteNonQuery();
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                lbl_AdSoyad.Text = reader[0] + " " + reader[1];
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + lbl_AdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frm = new FrmDoktorBilgiDuzenle();
            frm.tc = lbl_Tc.Text;
            frm.Show();
        }

        private void btn_duyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rtb_sikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
