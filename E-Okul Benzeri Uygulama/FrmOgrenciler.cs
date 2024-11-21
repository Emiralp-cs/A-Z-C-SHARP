using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace E_Okul_Benzeri_Uygulama
{
    public partial class FrmOgrenciler : Form
    {
        public FrmOgrenciler()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        DataSet1TableAdapters.TBLOGRENCILERTableAdapter ds = new DataSet1TableAdapters.TBLOGRENCILERTableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=FATIH;Initial Catalog=""Okul Projesi"";Integrated Security=True");

        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKULUPLER", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_kulup.Items.Add(dr[1].ToString());
            }
            baglanti.Close();

        }
        string c = "";
        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (rd_kız.Checked == true)
            {
                c = "KIZ";
            }
            if (rd_erkek.Checked == true)
            {
                c = "ERKEK";
            }

            ds.OgrenciEkle(txt_ograd.Text.ToUpper(), txt_ogrsoyad.Text.ToUpper(), c, Convert.ToByte(kulupiddegeri));
            MessageBox.Show("Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }
        int kulupiddegeri = 0;
        private void cmb_kulup_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select KULUPID FROM TBLKULUPLER WHERE KULUPAD=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmb_kulup.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kulupiddegeri = (byte)dr[0];

            }
            baglanti.Close();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(Convert.ToInt32(txt_ogrid.Text));

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ogrid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ograd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ogrsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_kulup.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();


            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "KIZ")
            {
                rd_kız.Checked = true;
                rd_erkek.Checked = false;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "ERKEK")
            {
                rd_kız.Checked = false;
                rd_erkek.Checked = true;
            }


        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {

            if (rd_erkek.Checked == true && rd_kız.Checked == false)
            {
                c = "ERKEK";
            }
            else if (rd_erkek.Checked == false && rd_kız.Checked == true)
            {
                c = "KIZ";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLOGRENCILER SET OGRAD=@P1,OGRSOYAD=@P2,OGRKULUP=@P3,OGRCINSIYET=@P4 where OGRID=@P5", baglanti);
            komut.Parameters.AddWithValue("@P1", txt_ograd.Text);
            komut.Parameters.AddWithValue("@P2", txt_ogrsoyad.Text);
            komut.Parameters.AddWithValue("@P3", kulupiddegeri);
            komut.Parameters.AddWithValue("@P4", c);
            komut.Parameters.AddWithValue("@P5", Convert.ToInt16(txt_ogrid.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciArama(txt_arama.Text);
        }
    }
}
