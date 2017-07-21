using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Kuzey.BLL.Repository;
using Kuzey.Model.Entities;

namespace Kuzey.UI.WFA
{
    public partial class FormSiparisOlustur : Form
    {
        private List<SiparisDetay> sepetUrunler = new List<SiparisDetay>();

        public FormSiparisOlustur()
        {
            InitializeComponent();
        }

        private void FormSiparisOlustur_Load(object sender, EventArgs e)
        {
            lstUrunler.DisplayMember = "UrunAdi";
            lstUrunler.DataSource = new ProductRepo().GetAll().Where(x => x.SatistaMi).ToList();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            lstUrunler.DataSource = new ProductRepo().ProductSearch(txtAra.Text);
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            var seciliUrun = lstUrunler.SelectedItem as Urun;
            var varmi = false;
            foreach (var surunler in sepetUrunler)
                if (seciliUrun.Id == surunler.UrunId)
                    varmi = true;
            if (varmi)
                sepetUrunler.Where(x => x.UrunId == seciliUrun.Id).FirstOrDefault().Adet +=
                    Convert.ToInt16(nAdet.Value);
            else
                sepetUrunler.Add(new SiparisDetay
                {
                    Adet = Convert.ToInt16(nAdet.Value),
                    UrunFiyati = seciliUrun.Fiyat,
                    UrunId = seciliUrun.Id,
                    Indirim = Convert.ToDouble(nIndirim.Value / 100),
                    Urun = seciliUrun
                });
            SepetDoldur();
        }

        private void SepetDoldur()
        {
            lstSepet.Items.Clear();
            decimal sepetTutari = 0;
            foreach (var item in sepetUrunler)
            {
                lstSepet.Items.Add(item);
                sepetTutari += item.UrunFiyati * item.Adet * Convert.ToDecimal(1 - item.Indirim);
            }
            lblTutar.Text = $"{sepetTutari:c2}\nKDV: {sepetTutari * 0.18m:c2}";
        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            if (sepetUrunler.Count == 0)
            {
                MessageBox.Show("Öncelikle Sepete Ürün Eklemelisiniz!");
                return;
            }
            var yeniSiparis = new Siparis
            {
                Adres = txtAdres.Text,
                IstenenTarih = dtpIstenenTarih.Value,
                Navlun = nKargoFiyat.Value
            };
            try
            {
                //new SiparisRepo().Insert(yeniSiparis);
                //foreach (var item in sepetUrunler)
                //{
                //    new SiparisDetayRepo().Insert(new SiparisDetay()
                //    {
                //        SiparisId = yeniSiparis.Id,
                //        UrunId = item.UrunId,
                //        Adet = item.Adet,
                //        Indirim = item.Indirim,
                //        UrunFiyati = item.UrunFiyati
                //    });
                //}
                var durum = new SiparisRepo().SiparisOlustur(yeniSiparis, sepetUrunler);
                if (durum)
                {
                    MessageBox.Show("Siparişiniz Oluşmuştur.");
                    sepetUrunler = new List<SiparisDetay>();
                    SepetDoldur();
                }
                else
                {
                    MessageBox.Show("Siparişiz oluşturulurken bir hata meydana geldi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}