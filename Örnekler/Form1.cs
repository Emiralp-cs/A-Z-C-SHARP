using System;
using System.Windows.Forms;

namespace Örnekler
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
                int s1, s2, sonuc;
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                sonuc = s2 * s1;
                label1.Text = sonuc.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata var burası çalıştı");
            }
            finally
            {
                MessageBox.Show("Finally kodu çalıştı");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
