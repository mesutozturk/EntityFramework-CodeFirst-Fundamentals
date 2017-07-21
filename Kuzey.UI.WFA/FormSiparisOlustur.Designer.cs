namespace Kuzey.UI.WFA
{
    partial class FormSiparisOlustur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.nAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.nIndirim = new System.Windows.Forms.NumericUpDown();
            this.lblTutar = new System.Windows.Forms.Label();
            this.dtpIstenenTarih = new System.Windows.Forms.DateTimePicker();
            this.nKargoFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.btnSiparisiOnayla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKargoFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(12, 38);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(188, 381);
            this.lstUrunler.TabIndex = 0;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(188, 20);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(456, 38);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(188, 381);
            this.lstSepet.TabIndex = 2;
            // 
            // nAdet
            // 
            this.nAdet.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nAdet.Location = new System.Drawing.Point(228, 38);
            this.nAdet.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAdet.Name = "nAdet";
            this.nAdet.Size = new System.Drawing.Size(115, 31);
            this.nAdet.TabIndex = 3;
            this.nAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.Location = new System.Drawing.Point(228, 142);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(115, 73);
            this.btnSepeteEkle.TabIndex = 4;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // nIndirim
            // 
            this.nIndirim.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nIndirim.Location = new System.Drawing.Point(228, 89);
            this.nIndirim.Name = "nIndirim";
            this.nIndirim.Size = new System.Drawing.Size(115, 31);
            this.nIndirim.TabIndex = 3;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(221, 379);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(153, 40);
            this.lblTutar.TabIndex = 5;
            this.lblTutar.Text = "125.00 ₺";
            // 
            // dtpIstenenTarih
            // 
            this.dtpIstenenTarih.Location = new System.Drawing.Point(664, 38);
            this.dtpIstenenTarih.Name = "dtpIstenenTarih";
            this.dtpIstenenTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpIstenenTarih.TabIndex = 6;
            // 
            // nKargoFiyat
            // 
            this.nKargoFiyat.DecimalPlaces = 2;
            this.nKargoFiyat.Location = new System.Drawing.Point(664, 65);
            this.nKargoFiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nKargoFiyat.Name = "nKargoFiyat";
            this.nKargoFiyat.Size = new System.Drawing.Size(99, 20);
            this.nKargoFiyat.TabIndex = 7;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(664, 92);
            this.txtAdres.MaxLength = 250;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 150);
            this.txtAdres.TabIndex = 8;
            this.txtAdres.Text = "";
            // 
            // btnSiparisiOnayla
            // 
            this.btnSiparisiOnayla.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisiOnayla.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSiparisiOnayla.Location = new System.Drawing.Point(664, 249);
            this.btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            this.btnSiparisiOnayla.Size = new System.Drawing.Size(200, 57);
            this.btnSiparisiOnayla.TabIndex = 9;
            this.btnSiparisiOnayla.Text = "Siparişi Onayla";
            this.btnSiparisiOnayla.UseVisualStyleBackColor = true;
            this.btnSiparisiOnayla.Click += new System.EventHandler(this.btnSiparisiOnayla_Click);
            // 
            // FormSiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 491);
            this.Controls.Add(this.btnSiparisiOnayla);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.nKargoFiyat);
            this.Controls.Add(this.dtpIstenenTarih);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.nIndirim);
            this.Controls.Add(this.nAdet);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstUrunler);
            this.Name = "FormSiparisOlustur";
            this.Text = "FormSiparisOlustur";
            this.Load += new System.EventHandler(this.FormSiparisOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKargoFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.NumericUpDown nAdet;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.NumericUpDown nIndirim;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.DateTimePicker dtpIstenenTarih;
        private System.Windows.Forms.NumericUpDown nKargoFiyat;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Button btnSiparisiOnayla;
    }
}