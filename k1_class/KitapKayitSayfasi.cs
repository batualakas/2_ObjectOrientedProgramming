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
    public partial class KitapKayitSayfasi : Form
    {
        public KitapKayitSayfasi()
        {
            InitializeComponent();
            // Kitap adı, yazar ad soyadı, fiyatı, türü,Yayınevi,Basın tarihi, sayfa Sayisi bilgilerini alarak Kitap dizisi içinde tutan bir uygulama yapınız.
            // Kitap[] içindekileri listBoxa ekleyelim
            cmbTuru.Items.Add("Distopik Kurgu");
            cmbTuru.Items.Add("Bilim Kurgu");
            cmbTuru.Items.Add("Tarih");
            cmbTuru.Items.Add("Psikoloji");
            cmbTuru.Items.Add("Kişisel Gelişim");
        }
        Kitaplar[] kitaplars = new Kitaplar[0];
        private void btnEkle_Click(object sender, EventArgs e)
        {


            Kitaplar kitap1 = new Kitaplar();
            kitap1.Fiyat = Convert.ToDouble(txtFiyat.Text);
            kitap1.KitapAdi = txtKitapAdı.Text.ToString();
            kitap1.YazarinAdiSoyadi = txtAdSoyad.Text;
            kitap1.Tur = cmbTuru.SelectedIndex.ToString();
            kitap1.YayinEvi = txtYayinevi.Text;
            kitap1.BasimTarihi = dtpTarih.Value;
            kitap1.SayfaSayisi = Convert.ToInt32(txtSayfaSayisi.Text);

            Array.Resize(ref kitaplars, kitaplars.Length + 1);
            kitaplars[kitaplars.Length - 1] = kitap1;

        }
        private void FormuTemizle()
        {


            txtAdSoyad.Clear();
            txtFiyat.Clear();
            txtKitapAdı.Clear();
            txtSayfaSayisi.Clear();
            txtYayinevi.Clear();
            cmbTuru.SelectedIndex = -1;
            dtpTarih.Value = DateTime.Now;


        }

        private void KitapKayitSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void cmbTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cascading drop down iki combo boxı bağlamak için öğreneceğiz.
        }




        private void btnTemizle_Click(object sender, EventArgs e)
        {

            FormuTemizle();



        }

        private void btbKitaplariListele_Click(object sender, EventArgs e)
        {
            foreach (var kitap in kitaplars)
            {
                lstKitaplar.Items.Add(kitap);
            }
        }

        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if (lstKitaplar.SelectedItem == null)
            if (lstKitaplar.SelectedItem != null) // selectedIndex != -1
            {
                var secilenEleman = (Kitaplar)lstKitaplar.SelectedItem;
                txtAdSoyad.Text = secilenEleman.YazarinAdiSoyadi;
                txtFiyat.Text = secilenEleman.Fiyat.ToString();
                txtKitapAdı.Text = secilenEleman.KitapAdi;
                cmbTuru.SelectedItem = secilenEleman.Tur;
                dtpTarih.Value = secilenEleman.BasimTarihi;
                txtSayfaSayisi.Text = secilenEleman.SayfaSayisi.ToString();
                txtYayinevi.Text = secilenEleman.YayinEvi;
                // Öğrenci kayıt ekranı oluşturmak.
                
            }
            else
            {
                MessageBox.Show("bir seçim yapmalısınz");
            }
            
        }
    }
}