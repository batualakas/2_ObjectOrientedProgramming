using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k3_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
           biyolojideki türlerin sınıflandırıması ve kalıtım vermesi gibi düşünebilirsiniz.
            Base Sınıf : Kalıtım veren en üstteki sınıftır.
            Derived Sınıf : Kalıtım alan sınıftır.
            tekrar tekrar  property, metot vb elemanların tanımlanmasını önlemektir.
           Bir sınıf sadece bir miraz alabilir. bunun dışında farklı bir yeteneğe sahip olmak isterse interface dediğimiz bir yapı ile bu sağlanabilir.
             
           */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // KURALLAR
            // bir sınıf sadece bir sınıftan miras alabilir.
            // sınıflar içinde o özelliği taşımayan bir eleman olmamalıdır. Mesala öğrenci sınıfında "sicil no" olmaması gerekir bunun için "sicil no" insan sınıfında değil memur sınıfında olabilir.

            // Aslında çoğu metodu Üst sınıflardan alarak ilerliyoruz. mesela ogrenci metodu boy ad soyad gibi bilgileri hep insan sınıfından alıyor.

            Ogrenci o = new Ogrenci();
            o.Ad = "Batu";
            o.Soyad = "Alakaş";
            o.Ortalama = 2.1;
            o.Sinifi = "3";
            // öğretmen sınıfı ad soyad gibi bilgileri insan sınıfından alıyor
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Ad = "Orkun ";
            ogretmen.Soyad = "İnce";
            ogretmen.Brans = "KPSS";
            ogretmen.SicilNo = "12245";
            // müdür sınıfı sicil no bilgisini ogretmen sınıfından alıyor ama öğretmen sınıfı bu metodu memur sınıfından alıyor.
            Mudur mdr = new Mudur();
            mdr.DisiplinKurulunuTopla();
            mdr.SicilNo="123151234";

            OkulPersoneli erik = new OkulPersoneli();
            erik.Ad = "Eray";
            erik.SicilNo = "123523";





                
        }
    }
}
