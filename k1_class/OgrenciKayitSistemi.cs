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
    public partial class OgrenciKayitSistemi : Form
    {
        public OgrenciKayitSistemi()
        {
            // hocam aslında iki combobox'ı birbirine bağlamaya çalıştım ama beceremedim :( 
            // sanırım daha gelmedik google'dan biraz baktım ama çok anlayamadım.
            // niyetim eğer mühendislik seçerse bilgisayar-makine gelmesiydi gibi..
            InitializeComponent();
            cmbFakulte.Items.Add("Mühendislik Fakültesi");
            cmbFakulte.Items.Add("İktisadi ve İdari Bilimler Fakültesi");
            cmbBolum.Items.Add("Bilgisayar Mühendisliği");
            cmbBolum.Items.Add("Makine Mühendisliği");
            cmbBolum.Items.Add("İktisat");
            cmbBolum.Items.Add("İşletme");
            cmbSinif.Items.Add("Hazırlık");
            cmbSinif.Items.Add("1");
            cmbSinif.Items.Add("2");
            cmbSinif.Items.Add("3");
            cmbSinif.Items.Add("4");
        }
        // bir hatada tekrar öğrenci bilgilerini listeden comboboxlara getirmeye çalışırken alıyorum. sınıf bilgisini getirsede bolum ve fakülte bilgilerini getirmiyor. sanırım toString yüzünden ama emin değilim 

        private void OgrenciKayitSistemi_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        Ogrenciler[] ogrenci = new Ogrenciler[0];
        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci1 = new Ogrenciler();
            ogrenci1.OgrenciAdi = txtAdSoyad.Text;
            ogrenci1.OgrenciNo = Convert.ToInt32(txtOgrenciNo.Text);
            ogrenci1.Fakulte = cmbFakulte.SelectedIndex.ToString();
            ogrenci1.Bolum = cmbBolum.SelectedIndex.ToString();
            ogrenci1.Sinif = cmbSinif.SelectedIndex.ToString();
            Array.Resize(ref ogrenci, ogrenci.Length + 1);
            ogrenci[ogrenci.Length - 1] = ogrenci1;
           
        }

        private void lstOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilenOgrenci = (Ogrenciler)lstOgrenciler.SelectedItem;
            txtAdSoyad.Text = secilenOgrenci.OgrenciAdi;
            txtOgrenciNo.Text = secilenOgrenci.OgrenciNo.ToString();
            cmbSinif.SelectedItem = secilenOgrenci.Sinif;
            cmbBolum.SelectedItem = secilenOgrenci.Bolum;
            cmbFakulte.SelectedItem = secilenOgrenci.Fakulte;

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            foreach (var yeniOgrenci in ogrenci)
            {
                lstOgrenciler.Items.Add(yeniOgrenci);
            }
        }
        private void Temizle()
        {
            txtAdSoyad.Clear();
            txtOgrenciNo.Clear();
            cmbBolum.SelectedIndex = -1;
            cmbFakulte.SelectedIndex = -1;
            cmbSinif.SelectedIndex = -1;

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
