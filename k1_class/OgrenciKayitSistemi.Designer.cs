
namespace k1_class
{
    partial class OgrenciKayitSistemi
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.lblBolum = new System.Windows.Forms.Label();
            this.lblFakulte = new System.Windows.Forms.Label();
            this.lblSinif = new System.Windows.Forms.Label();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.lstOgrenciler = new System.Windows.Forms.ListBox();
            this.cmbFakulte = new System.Windows.Forms.ComboBox();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(152, 13);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(144, 20);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAdSoyad.Location = new System.Drawing.Point(54, 16);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOgrenciNo.Location = new System.Drawing.Point(54, 42);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(61, 13);
            this.lblOgrenciNo.TabIndex = 2;
            this.lblOgrenciNo.Text = "Öğrenci No";
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBolum.Location = new System.Drawing.Point(54, 94);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(36, 13);
            this.lblBolum.TabIndex = 3;
            this.lblBolum.Text = "Bölüm";
            // 
            // lblFakulte
            // 
            this.lblFakulte.AutoSize = true;
            this.lblFakulte.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFakulte.Location = new System.Drawing.Point(54, 72);
            this.lblFakulte.Name = "lblFakulte";
            this.lblFakulte.Size = new System.Drawing.Size(42, 13);
            this.lblFakulte.TabIndex = 4;
            this.lblFakulte.Text = "Fakülte";
            // 
            // lblSinif
            // 
            this.lblSinif.AutoSize = true;
            this.lblSinif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSinif.Location = new System.Drawing.Point(54, 117);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(27, 13);
            this.lblSinif.TabIndex = 5;
            this.lblSinif.Text = "Sınıf";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(152, 39);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(143, 20);
            this.txtOgrenciNo.TabIndex = 9;
            this.txtOgrenciNo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lstOgrenciler
            // 
            this.lstOgrenciler.FormattingEnabled = true;
            this.lstOgrenciler.Location = new System.Drawing.Point(381, 13);
            this.lstOgrenciler.Name = "lstOgrenciler";
            this.lstOgrenciler.Size = new System.Drawing.Size(179, 186);
            this.lstOgrenciler.TabIndex = 10;
            this.lstOgrenciler.SelectedIndexChanged += new System.EventHandler(this.lstOgrenciler_SelectedIndexChanged);
            // 
            // cmbFakulte
            // 
            this.cmbFakulte.FormattingEnabled = true;
            this.cmbFakulte.Location = new System.Drawing.Point(151, 64);
            this.cmbFakulte.Name = "cmbFakulte";
            this.cmbFakulte.Size = new System.Drawing.Size(144, 21);
            this.cmbFakulte.TabIndex = 11;
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(152, 94);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(143, 21);
            this.cmbBolum.TabIndex = 12;
            // 
            // cmbSinif
            // 
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.Location = new System.Drawing.Point(151, 123);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(144, 21);
            this.cmbSinif.TabIndex = 13;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(153, 150);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(143, 23);
            this.btnOgrenciEkle.TabIndex = 14;
            this.btnOgrenciEkle.Text = "Öğrenciyi Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(434, 205);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(126, 23);
            this.btnListele.TabIndex = 15;
            this.btnListele.Text = "Öğrencileri Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(153, 179);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(143, 23);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // OgrenciKayitSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.cmbSinif);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.cmbFakulte);
            this.Controls.Add(this.lstOgrenciler);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.lblSinif);
            this.Controls.Add(this.lblFakulte);
            this.Controls.Add(this.lblBolum);
            this.Controls.Add(this.lblOgrenciNo);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtAdSoyad);
            this.Name = "OgrenciKayitSistemi";
            this.Text = "OgrenciKayitSistemi";
            this.Load += new System.EventHandler(this.OgrenciKayitSistemi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.Label lblFakulte;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.ListBox lstOgrenciler;
        private System.Windows.Forms.ComboBox cmbFakulte;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.ComboBox cmbSinif;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnTemizle;
    }
}