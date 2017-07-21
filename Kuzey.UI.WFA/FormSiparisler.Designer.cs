namespace Kuzey.UI.WFA
{
    partial class FormSiparisler
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
            this.btnSiparisOlustur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSiparisGenelRapor = new System.Windows.Forms.Button();
            this.btnKategoriyeGore = new System.Windows.Forms.Button();
            this.btnToplamSiparis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiparisOlustur
            // 
            this.btnSiparisOlustur.Location = new System.Drawing.Point(784, 12);
            this.btnSiparisOlustur.Name = "btnSiparisOlustur";
            this.btnSiparisOlustur.Size = new System.Drawing.Size(122, 82);
            this.btnSiparisOlustur.TabIndex = 0;
            this.btnSiparisOlustur.Text = "Sipariş Oluştur";
            this.btnSiparisOlustur.UseVisualStyleBackColor = true;
            this.btnSiparisOlustur.Click += new System.EventHandler(this.btnSiparisOlustur_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(766, 391);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSiparisGenelRapor
            // 
            this.btnSiparisGenelRapor.Location = new System.Drawing.Point(784, 145);
            this.btnSiparisGenelRapor.Name = "btnSiparisGenelRapor";
            this.btnSiparisGenelRapor.Size = new System.Drawing.Size(122, 82);
            this.btnSiparisGenelRapor.TabIndex = 0;
            this.btnSiparisGenelRapor.Text = "Sipariş Genel Rapor";
            this.btnSiparisGenelRapor.UseVisualStyleBackColor = true;
            this.btnSiparisGenelRapor.Click += new System.EventHandler(this.btnSiparisGenelRapor_Click);
            // 
            // btnKategoriyeGore
            // 
            this.btnKategoriyeGore.Location = new System.Drawing.Point(784, 233);
            this.btnKategoriyeGore.Name = "btnKategoriyeGore";
            this.btnKategoriyeGore.Size = new System.Drawing.Size(122, 82);
            this.btnKategoriyeGore.TabIndex = 0;
            this.btnKategoriyeGore.Text = "Kategoriye Göre Sipariş Raporu";
            this.btnKategoriyeGore.UseVisualStyleBackColor = true;
            this.btnKategoriyeGore.Click += new System.EventHandler(this.btnKategoriyeGore_Click);
            // 
            // btnToplamSiparis
            // 
            this.btnToplamSiparis.Location = new System.Drawing.Point(784, 321);
            this.btnToplamSiparis.Name = "btnToplamSiparis";
            this.btnToplamSiparis.Size = new System.Drawing.Size(122, 82);
            this.btnToplamSiparis.TabIndex = 0;
            this.btnToplamSiparis.Text = "Toplam Sipariş Raporu";
            this.btnToplamSiparis.UseVisualStyleBackColor = true;
            this.btnToplamSiparis.Click += new System.EventHandler(this.btnToplamSiparis_Click);
            // 
            // FormSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 415);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnToplamSiparis);
            this.Controls.Add(this.btnKategoriyeGore);
            this.Controls.Add(this.btnSiparisGenelRapor);
            this.Controls.Add(this.btnSiparisOlustur);
            this.Name = "FormSiparisler";
            this.Text = "FormSiparisler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiparisOlustur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSiparisGenelRapor;
        private System.Windows.Forms.Button btnKategoriyeGore;
        private System.Windows.Forms.Button btnToplamSiparis;
    }
}