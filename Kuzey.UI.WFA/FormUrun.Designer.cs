namespace Kuzey.UI.WFA
{
    partial class FormUrun
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
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSatistaMi = new System.Windows.Forms.CheckBox();
            this.nFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cbTum = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(12, 40);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(186, 329);
            this.lstUrunler.TabIndex = 1;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(13, 13);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(153, 21);
            this.cmbKategoriler.TabIndex = 0;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(289, 65);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(140, 20);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat";
            // 
            // cbSatistaMi
            // 
            this.cbSatistaMi.AutoSize = true;
            this.cbSatistaMi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSatistaMi.Location = new System.Drawing.Point(223, 118);
            this.cbSatistaMi.Name = "cbSatistaMi";
            this.cbSatistaMi.Size = new System.Drawing.Size(78, 17);
            this.cbSatistaMi.TabIndex = 5;
            this.cbSatistaMi.Text = "Satışta Mı?";
            this.cbSatistaMi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSatistaMi.UseVisualStyleBackColor = true;
            // 
            // nFiyat
            // 
            this.nFiyat.DecimalPlaces = 2;
            this.nFiyat.Location = new System.Drawing.Point(289, 92);
            this.nFiyat.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nFiyat.Name = "nFiyat";
            this.nFiyat.Size = new System.Drawing.Size(140, 20);
            this.nFiyat.TabIndex = 4;
            this.nFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(223, 175);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(68, 55);
            this.btnYeni.TabIndex = 6;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(297, 175);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(68, 55);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(371, 175);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(68, 55);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cbTum
            // 
            this.cbTum.AutoSize = true;
            this.cbTum.Location = new System.Drawing.Point(172, 17);
            this.cbTum.Name = "cbTum";
            this.cbTum.Size = new System.Drawing.Size(47, 17);
            this.cbTum.TabIndex = 2;
            this.cbTum.Text = "Tüm";
            this.cbTum.UseVisualStyleBackColor = true;
            this.cbTum.CheckedChanged += new System.EventHandler(this.cbTum_CheckedChanged);
            // 
            // FormUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 387);
            this.Controls.Add(this.cbTum);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.nFiyat);
            this.Controls.Add(this.cbSatistaMi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.lstUrunler);
            this.Name = "FormUrun";
            this.Text = "FormUrun";
            this.Load += new System.EventHandler(this.FormUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbSatistaMi;
        private System.Windows.Forms.NumericUpDown nFiyat;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.CheckBox cbTum;
    }
}