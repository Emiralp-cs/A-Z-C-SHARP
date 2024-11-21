using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Kitaplık_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\emira\\Desktop\\Kitaplik.mdb");

        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Kitaplar", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
        string durum = string.Empty;

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("insert into Kitaplar(KitapAd,Yazar,Tur,Sayfa,Durum) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut1.Parameters.AddWithValue("@p1", txt_kitapad.Text);
            komut1.Parameters.AddWithValue("@p2", txt_kitapyazar.Text);
            komut1.Parameters.AddWithValue("@p3", cmb_tur.Text);
            komut1.Parameters.AddWithValue("@p4", txt_kitapsayfa.Text);
            komut1.Parameters.AddWithValue("@p5", durum);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txt_kitapid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_kitapad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_kitapyazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_kitapsayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmb_tur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Delete From Kitaplar where Kitapid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_kitapid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void txt_kitapid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Update Kitaplar set Kitapad=@p1,Yazar=@p2,Tur=@p3,Sayfa=@p4,Durum=@p5 where Kitapid=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_kitapad.Text);
            komut.Parameters.AddWithValue("@p2", txt_kitapyazar.Text);
            komut.Parameters.AddWithValue("@p3", cmb_tur.Text);
            komut.Parameters.AddWithValue("@p4", txt_kitapsayfa.Text);
            if (radioButton1.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", "0");
            }
            else if (radioButton2.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", "1");
            }

            komut.Parameters.AddWithValue("@p6", txt_kitapid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Bilgisi Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar where KitapAd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_bul.Text);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txt_kitapad.Text = dr[1].ToString();
                txt_kitapyazar.Text = dr[2].ToString();
                txt_kitapsayfa.Text = dr[4].ToString();
                cmb_tur.Text = dr[3].ToString();

                if (dr[5].ToString() == "False")
                {
                    radioButton1.Checked = true;

                }
                else if (dr[5].ToString() == "True")
                {
                    radioButton2.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Aradığınız Kitabı Bulamadım", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Kitaplar Where KitapAd like '%" + txt_bul.Text + "%'", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
