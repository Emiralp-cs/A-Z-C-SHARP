using System;
using System.Windows.Forms;

namespace Hata_Yönetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int toplam = sayi1 + sayi2;
                MessageBox.Show(toplam.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Değerlerinizi Kontrol Edin");
            }
        }
    }
}
