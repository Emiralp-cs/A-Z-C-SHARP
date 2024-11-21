using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneProjesi
{
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("Select * From Tbl_Duyurular", bgl.baglanti());
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
