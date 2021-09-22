using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k7_Enum
{
    public partial class Form1 : Form
    {
        /*
         Enum: Program içinde kullanmak için sabit değerler tanımlamak isterseniz Enum'ları kullanabilirsiniz. Yazılım geliştirirken belli standartları koruyabilmek ve kolaylık sağlamak için tanımlanır.
        class açtığımız yerde Class yazan yere enum olarak tanımlıyoruz
         string, int değer alabiliriz.
         
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cinsiyet.Erkek
            //Cinsiyet.Kadin
            var yazi = Cinsiyet.Kadin.ToString();
            var sayisalKisim = (int)Cinsiyet.Kadin; // 0 değerini alır çünkü enum kısmında kadın =0 demiştik.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ad = txtAd.Text;
            var soyad = txtSoyad.Text;
            //var cinsiyet = txtCinsiyet.Text;
            //yeniKullanici.Cinsiyet = txtCinsiyet.Text; // "asdasdasd" yazabilir ama yanlış bizim seçeneklerimiz şuan kadın-erkek 
            //var cinsiyet = cmbCinsiyet.SelectedItem.ToString(); 
            Kullanici k1 = new Kullanici();
            k1.Ad = ad;
            k1.Soyad = soyad;
            //k1.Cinsiyet = "asdadqwe";

            if (rdbKadin.Checked)
            {
                k1.Gender = Cinsiyet.Kadin;
            }
            else if (rdbErkek.Checked)
            {
                k1.Gender = Cinsiyet.Erkek;
            }
            else
            {
                MessageBox.Show("Cinsiyet Seçimi Yapınız");
            }

            k1.Gender = Cinsiyet.Erkek;
            k1.Gender = Cinsiyet.Kadin; // artık k1'den cinsiyet almak için iki seçeneğimiz var kadın ya da erkek.
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
