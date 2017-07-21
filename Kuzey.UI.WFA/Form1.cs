using System;
using System.Windows.Forms;
using Kuzey.BLL;
using Kuzey.BLL.Repository;
using Kuzey.Model.Entities;

namespace Kuzey.UI.WFA
{
    public partial class Form1 : Form
    {
        private FormSiparisler siparisForm;

        private FormUrun urunlerForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstKategoriler.DisplayMember = "KategoriAdi";
            lstKategoriler.DataSource = new KategoriRepo().TumKategorileriGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                //new KategoriRepo().KategoriEkle(new Kategori()
                //{
                //    KategoriAdi = txtKategoriAdi.Text,
                //    Aciklama = txtAciklama.Text
                //});
                new CategoryRepo().Insert(new Kategori
                {
                    KategoriAdi = txtKategoriAdi.Text,
                    Aciklama = txtAciklama.Text
                });
                lstKategoriler.DataSource = new KategoriRepo().TumKategorileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedItem == null) return;
            var silinecek = lstKategoriler.SelectedItem as Kategori;

            try
            {
                new KategoriRepo().KategoriSil(silinecek);
                lstKategoriler.DataSource = new KategoriRepo().TumKategorileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUrunleriGoster_Click(object sender, EventArgs e)
        {
            if (urunlerForm == null || urunlerForm.IsDisposed)
                urunlerForm = new FormUrun();
            urunlerForm.Show();
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            if (siparisForm == null || siparisForm.IsDisposed)
                siparisForm = new FormSiparisler();
            siparisForm.Show();
        }
    }
}