namespace Kuzey.UI.WFA
{
    partial class Form1
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
            this.lstKategoriler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUrunleriGoster = new System.Windows.Forms.Button();
            this.btnSiparisler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.FormattingEnabled = true;
            this.lstKategoriler.Location = new System.Drawing.Point(13, 13);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(187, 316);
            this.lstKategoriler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Adı";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(298, 41);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(130, 20);
            this.txtKategoriAdi.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(298, 68);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(130, 113);
            this.txtAciklama.TabIndex = 3;
            this.txtAciklama.Text = "";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(298, 188);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(52, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(376, 188);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(52, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama";
            // 
            // btnUrunleriGoster
            // 
            this.btnUrunleriGoster.Location = new System.Drawing.Point(228, 265);
            this.btnUrunleriGoster.Name = "btnUrunleriGoster";
            this.btnUrunleriGoster.Size = new System.Drawing.Size(95, 64);
            this.btnUrunleriGoster.TabIndex = 6;
            this.btnUrunleriGoster.Text = "Ürünleri Göster";
            this.btnUrunleriGoster.UseVisualStyleBackColor = true;
            this.btnUrunleriGoster.Click += new System.EventHandler(this.btnUrunleriGoster_Click);
            // 
            // btnSiparisler
            // 
            this.btnSiparisler.Location = new System.Drawing.Point(330, 265);
            this.btnSiparisler.Name = "btnSiparisler";
            this.btnSiparisler.Size = new System.Drawing.Size(98, 64);
            this.btnSiparisler.TabIndex = 7;
            this.btnSiparisler.Text = "Siparisler";
            this.btnSiparisler.UseVisualStyleBackColor = true;
            this.btnSiparisler.Click += new System.EventHandler(this.btnSiparisler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 341);
            this.Controls.Add(this.btnSiparisler);
            this.Controls.Add(this.btnUrunleriGoster);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstKategoriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKategoriler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUrunleriGoster;
        private System.Windows.Forms.Button btnSiparisler;
    }
}

