using System;
using System.Windows.Forms;

namespace E_Okul_Benzeri_Uygulama
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKulupler fm = new frmKulupler();
            fm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDersler fm = new FrmDersler();
            fm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOgrenciler fm = new FrmOgrenciler();
            fm.Show();
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSınavNotlar fm = new FrmSınavNotlar();
            fm.Show();
        }
    }
}
