using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace E_Okul_Benzeri_Uygulama
{
    public partial class frmKulupler : Form
    {
        public frmKulupler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=FATIH;Initial Catalog=""Okul Projesi"";Integrated Security=True");
        private void Listele()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLKULUPLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frmKulupler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKULUPLER (KULUPAD) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_kulupad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Listeye Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kulupid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_kulupad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From TBLKULUPLER WHERE KULUPID=@P1", baglanti);
                komut.Parameters.AddWithValue("@P1", txt_kulupid.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kulüp Silme İşlemi Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Belirtilen kulübü silebilmek için öncelikle o kulübe üye olan öğrencileri o kulüpten çıkartmanız gerekmektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLKULUPLER SET KULUPAD=@P1 WHERE KULUPID=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", txt_kulupad.Text);
            komut.Parameters.AddWithValue("@P2", txt_kulupid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Güncelleme İşlemi Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
