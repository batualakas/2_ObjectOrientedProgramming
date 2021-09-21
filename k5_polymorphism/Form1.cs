using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k5_polymorphism
{
    public partial class Form1 : Form
    {
        /* Çok biçimlilik (polymorphism): Base sınıfta yazılan bir metot yada property'nin derived(Miras alan sınıf-'Alt Sınıf') sınıflarda base'de tanımlandığından farklı bir şekilde kullanılabilmesine denir.
        Virtual anahtar kelimesi ile tanımlanan eleman miras alınan sınıf içinde override anahtar kelimesi ile ezilebilir ve farklı bir biçimde kullanılabilir. 


        */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba a1 = new Araba();
            a1.Modeli = "Audi";
            a1.BirimFiyat = 10000;
            a1.MotorHacmi = 0;
            var arabaninFiyati = a1.KdvliFiyatGetir();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ekmek halkEkmek = new Ekmek();
            halkEkmek.EkmekBirimFiyati = 1.2;
            halkEkmek.EkmekTuru = "Beyaz Ekmek";
            halkEkmek.EkmekGramaj = 180;
            var halkEkmekFiyati = halkEkmek.KdvliFiyatGetir();

            txtBirimFiyat.Text = Convert.ToDouble(halkEkmek.EkmekBirimFiyati).ToString();
            txtEkmekTuru.Text = halkEkmek.EkmekTuru;
            txtGramaj.Text = Convert.ToDouble(halkEkmek.EkmekGramaj).ToString();
            txtFiyat.Text = Convert.ToDouble(halkEkmekFiyati).ToString();
            
        }
    }
}
