using System;
using System.Windows.Forms;
using Kuzey.BLL.Repository;

namespace Kuzey.UI.WFA
{
    public partial class FormSiparisler : Form
    {
        private FormSiparisOlustur frmSiparisOlustur;

        public FormSiparisler()
        {
            InitializeComponent();
        }

        private void btnSiparisOlustur_Click(object sender, EventArgs e)
        {
            if (frmSiparisOlustur == null || frmSiparisOlustur.IsDisposed)
                frmSiparisOlustur = new FormSiparisOlustur();
            frmSiparisOlustur.Show();
        }

        private void btnSiparisGenelRapor_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new SiparisRepo().SiparisRaporu();
        }

        private void btnKategoriyeGore_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new SiparisRepo().KategoriyeGoreSiparisRaporu();
        }

        private void btnToplamSiparis_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new SiparisRepo().SiparisToplamRaporu();
        }
    }
}