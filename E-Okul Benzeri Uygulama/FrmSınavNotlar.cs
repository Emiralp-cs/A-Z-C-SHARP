using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace E_Okul_Benzeri_Uygulama
{
    public partial class FrmSınavNotlar : Form
    {

        public FrmSınavNotlar()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLNOTLARTableAdapter ds = new DataSet1TableAdapters.TBLNOTLARTableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=FATIH;Initial Catalog=""Okul Projesi"";Integrated Security=True");

        private void btn_ara_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txt_id.Text));

        }

        private void FrmSınavNotlar_Load(object sender, System.EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLDERSLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_dersler.DisplayMember = "DERSAD";
            cmb_dersler.ValueMember = "DERSID";
            cmb_dersler.DataSource = dt;
        }
        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_sinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_sinav2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_sinav3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_proje.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_ortalama.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_durum.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmb_dersler.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();


        }
        int sinav1, sinav2, sinav3, proje;
        double ortalama;
        string durum;
        private void btn_hesapla_Click(object sender, System.EventArgs e)
        {
            int sinav1, sinav2, sinav3, proje;
            double ortalama;
            string durum;
            sinav1 = Convert.ToInt16(txt_sinav1.Text);
            sinav2 = Convert.ToInt16(txt_sinav2.Text);
            sinav3 = Convert.ToInt16(txt_sinav3.Text);
            proje = Convert.ToInt16(txt_proje.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4.0;
            txt_ortalama.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                txt_durum.Text = "True";
            }
            else
            {
                txt_durum.Text = "False";
            }




        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cmb_dersler.SelectedValue.ToString()), int.Parse(txt_id.Text), byte.Parse(txt_sinav1.Text), byte.Parse(txt_sinav2.Text), byte.Parse(txt_sinav3.Text), byte.Parse(txt_proje.Text), decimal.Parse(txt_ortalama.Text), bool.Parse(txt_durum.Text), notid);
        }
    }
}
