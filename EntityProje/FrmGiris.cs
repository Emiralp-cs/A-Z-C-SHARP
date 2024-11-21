using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EntityProje
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = (from x in db.TBLADMIN where x.KULLANICI == textBox1.Text && x.SIFRE == textBox2.Text select x);
            if (sorgu.Any())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
