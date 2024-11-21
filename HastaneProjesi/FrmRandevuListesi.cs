using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneProjesi
{
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmRandevuListesi_Load(object sender, System.EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string tarih = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string saat = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string branş = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            string doktor = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            string durum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            string hastatc = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            FrmSekreterDetay fs = new FrmSekreterDetay(id, tarih, saat, branş, doktor, durum, hastatc);
            fs.Show();

        }
    }
}
