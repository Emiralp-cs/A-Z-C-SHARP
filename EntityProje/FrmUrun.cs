using System;
using System.Linq;
using System.Windows.Forms;

namespace EntityProje
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btn_listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.TBLKATEGORI.AD,
                                            x.DURUM
                                        }).ToList();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = txt_urunad.Text;
            t.MARKA = txt_marka.Text;
            t.STOK = short.Parse(txt_stok.Text);
            t.KATEGORI = int.Parse(comboBox1.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(txt_fiyat.Text);
            t.DURUM = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_id.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Sistem Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_id.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD = txt_urunad.Text;
            urun.MARKA = txt_marka.Text;
            urun.STOK = short.Parse(txt_stok.Text);
            urun.FIYAT = decimal.Parse(txt_fiyat.Text);
            urun.DURUM = true;
            urun.KATEGORI = int.Parse(comboBox1.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellemesi Yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORI
                               select new
                               { x.ID, x.AD }
                               ).ToList();
            comboBox1.DataSource = kategoriler;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "AD";
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_id.Text = string.Empty;
            txt_urunad.Text = string.Empty;
            txt_marka.Text = string.Empty;
            txt_stok.Text = string.Empty;
            txt_fiyat.Text = string.Empty;
            comboBox1.Text = string.Empty;
            txt_durum.Text = string.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_urunad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_marka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_stok.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_fiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_durum.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
