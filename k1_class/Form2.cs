using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k1_class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            // Öğrenci Sınıfı oluşturalım.
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Batu"; // set bloğu çalışır.
                                  // MessageBox.Show(ogrenci1.Ad);
            ogrenci1.Soyad = "Alakaş";
            ogrenci1.KanGrubu = "A Rh +";
            ogrenci1.OgrenciNumarasi = "201234585";
            ogrenci1.Adres = "Eryaman 3.etap";
            ogrenci1.Bolum = "İktisat";
            ogrenci1.DogumTarihi = new DateTime(1994, 11, 10);
            lblAd.Text = ogrenci1.Ad;
            lblAdres.Text = ogrenci1.Adres;
            lblBolum.Text = ogrenci1.Bolum;
            lblKanGrubu.Text = ogrenci1.KanGrubu;
            lblOgrenciNumarasi.Text = ogrenci1.OgrenciNumarasi;
            lblSoyad.Text = ogrenci1.Soyad;
            lblYas.Text = ogrenci1.Yas.ToString();
        }
    }
}
