using System;
using System.Linq;
using System.Windows.Forms;
using Kuzey.BLL.Repository;
using Kuzey.Model.Entities;

namespace Kuzey.UI.WFA
{
    public partial class FormUrun : Form
    {
        public FormUrun()
        {
            InitializeComponent();
        }

        private void UrunleriYukle()
        {
            if (cmbKategoriler.SelectedItem == null) return;
            var seciliKategori = cmbKategoriler.SelectedItem as Kategori;
            //var urunler = new UrunRepo().KategorininUrunleriniGetir(seciliKategori);
            var urunler = new ProductRepo().GetAllByCategory(seciliKategori);
            lstUrunler.DataSource = !cbTum.Checked ? urunler.Where(x => x.SatistaMi).ToList() : urunler;
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunleriYukle();
        }

        private void FormUrun_Load(object sender, EventArgs e)
        {
            lstUrunler.DisplayMember = "UrunAdi";
            cmbKategoriler.DisplayMember = "KategoriAdi";
            //cmbKategoriler.DataSource = new KategoriRepo().TumKategorileriGetir();
            cmbKategoriler.DataSource = new CategoryRepo().GetAll();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            try
            {
                var kategori = cmbKategoriler.SelectedItem as Kategori;
                //if (kategori != null)
                //    new UrunRepo().UrunEkle(new Urun()
                //    {
                //        UrunAdi = txtUrunAdi.Text,
                //        Fiyat = nFiyat.Value,
                //        SatistaMi = cbSatistaMi.Checked,
                //        KategoriId = kategori.Id
                //    });
                if (kategori != null)
                    new ProductRepo().Insert(new Urun
                    {
                        UrunAdi = txtUrunAdi.Text,
                        Fiyat = nFiyat.Value,
                        SatistaMi = cbSatistaMi.Checked,
                        KategoriId = kategori.Id
                    });
                UrunleriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            var seciliUrun = lstUrunler.SelectedItem as Urun;
            txtUrunAdi.Text = seciliUrun.UrunAdi;
            nFiyat.Value = seciliUrun.Fiyat;
            cbSatistaMi.Checked = seciliUrun.SatistaMi;
        }

        private void cbTum_CheckedChanged(object sender, EventArgs e)
        {
            UrunleriYukle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            var seciliUrun = lstUrunler.SelectedItem as Urun;
            try
            {
                seciliUrun = new ProductRepo().GetByID(seciliUrun.Id);
                seciliUrun.UrunAdi = txtUrunAdi.Text;
                seciliUrun.Fiyat = nFiyat.Value;
                seciliUrun.SatistaMi = cbSatistaMi.Checked;
                new ProductRepo().Update();
                UrunleriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            var seciliUrun = lstUrunler.SelectedItem as Urun;
            try
            {
                //new UrunRepo().UrunSil(seciliUrun);
                new ProductRepo().Delete(seciliUrun);
                UrunleriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}