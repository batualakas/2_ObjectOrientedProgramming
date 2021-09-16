
namespace k1_class
{
    partial class Form2
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
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblOgrenciNumarasi = new System.Windows.Forms.Label();
            this.lblKanGrubu = new System.Windows.Forms.Label();
            this.lblBolum = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Location = new System.Drawing.Point(57, 13);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(130, 50);
            this.btnOgrenci.TabIndex = 0;
            this.btnOgrenci.Text = "Öğrenci Ekle";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(82, 80);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(35, 13);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "label1";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(82, 113);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(35, 13);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "label2";
            // 
            // lblOgrenciNumarasi
            // 
            this.lblOgrenciNumarasi.AutoSize = true;
            this.lblOgrenciNumarasi.Location = new System.Drawing.Point(82, 161);
            this.lblOgrenciNumarasi.Name = "lblOgrenciNumarasi";
            this.lblOgrenciNumarasi.Size = new System.Drawing.Size(35, 13);
            this.lblOgrenciNumarasi.TabIndex = 3;
            this.lblOgrenciNumarasi.Text = "label3";
            // 
            // lblKanGrubu
            // 
            this.lblKanGrubu.AutoSize = true;
            this.lblKanGrubu.Location = new System.Drawing.Point(82, 185);
            this.lblKanGrubu.Name = "lblKanGrubu";
            this.lblKanGrubu.Size = new System.Drawing.Size(35, 13);
            this.lblKanGrubu.TabIndex = 4;
            this.lblKanGrubu.Text = "label4";
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Location = new System.Drawing.Point(82, 136);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(35, 13);
            this.lblBolum.TabIndex = 5;
            this.lblBolum.Text = "label5";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(85, 214);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(35, 13);
            this.lblAdres.TabIndex = 6;
            this.lblAdres.Text = "label1";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(85, 245);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(23, 13);
            this.lblYas.TabIndex = 7;
            this.lblYas.Text = "yaş";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblBolum);
            this.Controls.Add(this.lblKanGrubu);
            this.Controls.Add(this.lblOgrenciNumarasi);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnOgrenci);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblOgrenciNumarasi;
        private System.Windows.Forms.Label lblKanGrubu;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblYas;
    }
}