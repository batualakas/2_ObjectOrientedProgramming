using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k8_Interface
{
    public partial class Form1 : Form
    {
        /*
            Interface : Kalıtımda bir sınıf sadece bir base sınıftan miras alabilir. Bu sınıfa ek özellik/yetenek kazandırılmak isteniyorsa bu durumda interface yapısı ile sorunu çözebiliyoruz.
           Interface'ler implemente edilerek kullanılır.
           Tanımlanırken IInterfaceAdi şeklinde isimlendirilirler.
           Isımlendirirken -able - ebilir
           Interface'in içindeki elemanlara erişim beirleyici tanımlanmaz.
           Interface'in içinde tanımlanan metot veya propertlerin gövdeleri tanımlanmaz.

           Kus: base
           Karga, Martı, Penguen, Tavuk sınıfı



            */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Penguen p1 = new Penguen();
            p1.MaxInebilecegiDerinlik = 10;
            p1.Birimi = UzunlukBirimi.kilometre;
            p1.GagaBoyuBirimi = UzunlukBirimi.santimetre;
            p1.GagaBoyu = 1.2;
           // listboxa, txtboxa... mesajı eklemek istediğimiz yer
           // MessageBox.Show($"{p1.MaxInebilecegiDerinlik} {p1.GagaBoyuBirimi.ToString()}");
           

            Marti m1 = new Marti();
            m1.MaxInebilecegiDerinlik = 2;
            m1.Birimi = UzunlukBirimi.metre;
            m1.KanatUzunlugu = 1;
            m1.KanatUzunluguBirimi = UzunlukBirimi.metre;

            m1.Yuz();

            // IUcabilir adında bir interface oluşturunuz.
            // Uçabilme yeteneği olan sınıflara implemente ediniz. karga tavuk martı 
            // Uc() "uc metodu" + uçabileceği max yükseklik + uçabileceği max yükseklik birimini tanımlayalım.

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Marti m2 = new Marti();
            m2.MaxUcabilecegiYukseklik = 4;
            m2.MaxUcabilecegiYukseklikBirimi = UzunlukBirimi.kilometre;
            m2.Uc();
            txt1.Text = $"{m2.MaxUcabilecegiYukseklik} {m2.MaxUcabilecegiYukseklikBirimi}";
        }
    }
}
