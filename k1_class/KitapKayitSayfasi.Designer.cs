
namespace k1_class
{
    partial class KitapKayitSayfasi
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblAdiSoyadi = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblYayınevi = new System.Windows.Forms.Label();
            this.lblBasimTarihi = new System.Windows.Forms.Label();
            this.lblSayfaSayisi = new System.Windows.Forms.Label();
            this.txtKitapAdı = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbTuru = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.btbKitaplariListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(154, 208);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(97, 34);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Kitap Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(39, 13);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(49, 13);
            this.lblKitapAdi.TabIndex = 11;
            this.lblKitapAdi.Text = "Kitap Adı";
            // 
            // lblAdiSoyadi
            // 
            this.lblAdiSoyadi.AutoSize = true;
            this.lblAdiSoyadi.Location = new System.Drawing.Point(39, 40);
            this.lblAdiSoyadi.Name = "lblAdiSoyadi";
            this.lblAdiSoyadi.Size = new System.Drawing.Size(95, 13);
            this.lblAdiSoyadi.TabIndex = 12;
            this.lblAdiSoyadi.Text = "Yazarın Adı Soyadı";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(39, 70);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(31, 13);
            this.lblFiyat.TabIndex = 13;
            this.lblFiyat.Text = "Fiyatı";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(39, 95);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(29, 13);
            this.lblTur.TabIndex = 15;
            this.lblTur.Text = "Türü";
            // 
            // lblYayınevi
            // 
            this.lblYayınevi.AutoSize = true;
            this.lblYayınevi.Location = new System.Drawing.Point(39, 120);
            this.lblYayınevi.Name = "lblYayınevi";
            this.lblYayınevi.Size = new System.Drawing.Size(47, 13);
            this.lblYayınevi.TabIndex = 16;
            this.lblYayınevi.Text = "Yayınevi";
            // 
            // lblBasimTarihi
            // 
            this.lblBasimTarihi.AutoSize = true;
            this.lblBasimTarihi.Location = new System.Drawing.Point(39, 146);
            this.lblBasimTarihi.Name = "lblBasimTarihi";
            this.lblBasimTarihi.Size = new System.Drawing.Size(64, 13);
            this.lblBasimTarihi.TabIndex = 17;
            this.lblBasimTarihi.Text = "Basım Tarihi";
            // 
            // lblSayfaSayisi
            // 
            this.lblSayfaSayisi.AutoSize = true;
            this.lblSayfaSayisi.Location = new System.Drawing.Point(39, 173);
            this.lblSayfaSayisi.Name = "lblSayfaSayisi";
            this.lblSayfaSayisi.Size = new System.Drawing.Size(64, 13);
            this.lblSayfaSayisi.TabIndex = 18;
            this.lblSayfaSayisi.Text = "Sayfa Sayısı";
            // 
            // txtKitapAdı
            // 
            this.txtKitapAdı.Location = new System.Drawing.Point(154, 7);
            this.txtKitapAdı.Name = "txtKitapAdı";
            this.txtKitapAdı.Size = new System.Drawing.Size(200, 20);
            this.txtKitapAdı.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(154, 34);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(200, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(154, 64);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(200, 20);
            this.txtFiyat.TabIndex = 2;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(154, 114);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(200, 20);
            this.txtYayinevi.TabIndex = 4;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(154, 170);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(200, 20);
            this.txtSayfaSayisi.TabIndex = 6;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(154, 140);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 5;
            // 
            // cmbTuru
            // 
            this.cmbTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTuru.FormattingEnabled = true;
            this.cmbTuru.Location = new System.Drawing.Point(154, 90);
            this.cmbTuru.Name = "cmbTuru";
            this.cmbTuru.Size = new System.Drawing.Size(200, 21);
            this.cmbTuru.TabIndex = 3;
            this.cmbTuru.SelectedIndexChanged += new System.EventHandler(this.cmbTuru_SelectedIndexChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(257, 208);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(97, 34);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.Location = new System.Drawing.Point(408, 17);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(367, 173);
            this.lstKitaplar.TabIndex = 20;
            this.lstKitaplar.SelectedIndexChanged += new System.EventHandler(this.lstKitaplar_SelectedIndexChanged);
            // 
            // btbKitaplariListele
            // 
            this.btbKitaplariListele.Location = new System.Drawing.Point(643, 196);
            this.btbKitaplariListele.Name = "btbKitaplariListele";
            this.btbKitaplariListele.Size = new System.Drawing.Size(132, 23);
            this.btbKitaplariListele.TabIndex = 21;
            this.btbKitaplariListele.Text = "Kitapları Listele";
            this.btbKitaplariListele.UseVisualStyleBackColor = true;
            this.btbKitaplariListele.Click += new System.EventHandler(this.btbKitaplariListele_Click);
            // 
            // KitapKayitSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbKitaplariListele);
            this.Controls.Add(this.lstKitaplar);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.cmbTuru);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtYayinevi);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtKitapAdı);
            this.Controls.Add(this.lblSayfaSayisi);
            this.Controls.Add(this.lblBasimTarihi);
            this.Controls.Add(this.lblYayınevi);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblAdiSoyadi);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.btnEkle);
            this.Name = "KitapKayitSayfasi";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.KitapKayitSayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblAdiSoyadi;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblYayınevi;
        private System.Windows.Forms.Label lblBasimTarihi;
        private System.Windows.Forms.Label lblSayfaSayisi;
        private System.Windows.Forms.TextBox txtKitapAdı;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbTuru;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.Button btbKitaplariListele;
    }
}