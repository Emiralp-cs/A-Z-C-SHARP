using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace E_Okul_Benzeri_Uygulama
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=FATIH;Initial Catalog=""Okul Projesi"";Integrated Security=True");
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select DERSAD,SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM from TBLNOTLAR\r\nINNER JOIN TBLDERSLER ON TBLNOTLAR.DERSID=TBLDERSLER.DERSID WHERE OGRID=" + numara + "", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
