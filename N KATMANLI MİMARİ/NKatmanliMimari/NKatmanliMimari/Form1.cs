using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LogicLayerPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txt_ad.Text;
            ent.Soyad = txt_soyad.Text;
            ent.Maas = short.Parse(txt_maas.Text);
            ent.Sehir = txt_sehir.Text;
            ent.Gorev = txt_gorev.Text;
            LogicPersonel.LogicLayerPersonelEkle(ent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txt_id.Text);
            LogicPersonel.LogicLayerPersonelSil(ent.Id);

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txt_id.Text);
            ent.Ad = txt_ad.Text;
            ent.Soyad = txt_soyad.Text;
            ent.Maas = short.Parse(txt_maas.Text);
            ent.Sehir= txt_sehir.Text;
            ent.Gorev= txt_gorev.Text;
            LogicPersonel.LogicLayerPersonelGuncelle(ent);




        }
    }
}
