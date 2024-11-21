using EntityProje;
using System;
using System.Linq;
using System.Windows.Forms;

namespace E_Okul_Benzeri_Uygulama
{
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            lbl_toplamkategori.Text = db.TBLKATEGORI.Count().ToString();
            lbl_toplamurun.Text = db.TBLURUN.Count().ToString();
            lbl_aktifmusteri.Text = db.TBLMUSTERI.Count(x => x.DURUM == true).ToString();
            lbl_pasifmusteri.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString();
            lbl_toplamstok.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            lbl_kasadakitutar.Text = db.TBLSATIS.Sum(x => x.FIYAT).ToString() + " TL";
            lbl_enpahaliurun.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            lbl_enucuzurun.Text = (from x in db.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            lbl_toplambeyazesya.Text = db.TBLURUN.Count(x => x.KATEGORI == 5).ToString();
            lbl_toplambuzdolabi.Text = db.TBLURUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            lbl_toplamsehirsayisi.Text = (from x in db.TBLMUSTERI select x.MUSTERISEHIR).Distinct().Count().ToString();
            lbl_enfazlaurunlumarka.Text = db.MARKAGETIR().FirstOrDefault().ToString();
        }


    }
}
