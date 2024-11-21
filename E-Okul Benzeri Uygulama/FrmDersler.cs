using System;
using System.Windows.Forms;

namespace E_Okul_Benzeri_Uygulama
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLDERSLERTableAdapter ds = new DataSet1TableAdapters.TBLDERSLERTableAdapter();

        private void FrmDersler_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ds.GetData();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txt_kulupad.Text);
            MessageBox.Show("Ders Ekleme İşlemi Yapılmıştır");
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.GetData();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                ds.DersSil(byte.Parse(txt_kulupid.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Bu dersi silmek için öncelikle bu dersi veren öğretmeni bu dersten kaldırmanız gerekmektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            ds.DersGüncelle(txt_kulupad.Text, Convert.ToByte(txt_kulupid.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kulupid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_kulupad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
