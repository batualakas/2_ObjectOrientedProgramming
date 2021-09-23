using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k10_List
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAvarage_Click(object sender, EventArgs e)
        {
            //Ortalama alan metot.
            var sayilar = new List<int> { 12, 41, 123, 512, 52, 44 };
            // extension metot
            var ortalama = sayilar.Average();
            //MessageBox.Show(ortalama.ToString());

            // lambda expression 
            // sayılar listesindeki tüm elemanlara 3 ekledikten sonra ortalamasını al.
            // sayi=> sayi +3 dediğimiz kısım listedeki her sayıya 3 ekle dediğimiz kısım.
            var ortalama2 = sayilar.Average(sayi => sayi + 3);


        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            //concat liste birleştirmek için kullanılır.
            var fizikselOGrenciler = new List<string>() { "omer", "orkun", "batu" };
            var onlineOgrenciler = new List<string>() { "Mustafa", "utku", "eray" };

            var tumOgrencilerListesi = fizikselOGrenciler.Concat(onlineOgrenciler).ToList();
            //.ToList(); listeye çevir komutu ekledik çünkü eğer kodu düz çalıştırsakydık IEnumarable geliyordu.
            foreach (var ogrenciAdi in tumOgrencilerListesi)
            {
                listBox1.Items.Add(ogrenciAdi);
            }

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            var sayilar = new List<int>() { 29, 11, 10, 9, 2, 3, 45 };
            var sayilarListesininElemanSayisi = sayilar.Count;
            var elemanSayisi = sayilar.Count();
            var ondanBuyukElemanSayisi = sayilar.Count(sayi => sayi > 10);
            //2 katı 50 den  küçük olanların sayısı = 5 çıktı
            var ornek1 = sayilar.Count(sayi => sayi * 2 < 50);
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            var sayilar = new List<int>() { 29, 11, 10, 9, 2, 3, 45 };
            var onlineOgrenciler = new List<string>() { "Mustafa", "utku", "eray" };
            var erayAdindaOgrenciVarMi = onlineOgrenciler.Contains("eray"); // büyük küçük harfe duyarlı olduğu için false değeri dönücek.
            var iceriyorMu = sayilar.Contains(11);
            var ornek2 = sayilar.Exists(sayi => sayi > 100); // false çünkü öyle bi değer yok.
            var ornek3 = sayilar.Exists(sayi => sayi > 2); // true çünkü 2'den büyük sayı var listede.
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci() { Ad = "Batu", Soyad = "Alakaş", Yas = 26 },
                new Ogrenci() { Ad = "orkun", Soyad = "İnce", Yas = 29 },
                new Ogrenci() { Ad = "eray", Yas = 29, Soyad= "Ergin" }
            };
            var sonuc1 = ogrenciler.Exists(ogrenci => ogrenci.Ad == "Bahar"); // adı bahar olan öğrenci var mi ?
            var sonuc2 = ogrenciler.Exists(ogrenci => ogrenci.Yas < 30); //yaşı 30dan küçük olan öğrenci var mi ?  
        }

        private void btnFirstOrDefault_Click(object sender, EventArgs e)
        {
            //eğer içine bir kriter yazılırsa o kriteri sağlayan ilk sonucu döndürür. eğer kriteri sağlayan bir değer bulunamazsa null sonucu döner.
            List<Ogrenci> ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci() { Ad = "Batu", Soyad = "Alakaş", Yas = 26 },
                new Ogrenci() { Ad = "Orkun", Soyad = "İnce", Yas = 29 },
                new Ogrenci() { Ad = "Eray", Yas = 29, Soyad= "Ergin" },
                new Ogrenci(){ Ad = "Ömer", Soyad="Eroğlu", Yas = 24 },
                new Ogrenci(){Ad="Leyla",Soyad="Taş",Yas = 27},
                new Ogrenci(){Ad="Mustafa",Soyad="Yılmaz",Yas = 27}
            };
            // yaşı 27 olan kişiyi getiriniz.
            var sonuc = ogrenciler.FirstOrDefault(x => x.Yas == 27);
            // yaşı 27 olan soyadı içinde taş geçen kişiyi getiriniz.
            var sonuc2 = ogrenciler.FirstOrDefault(x => x.Soyad.Contains("Taş") && x.Yas == 27);
            var sonuc3 = ogrenciler.LastOrDefault(x => x.Yas == 27);

            var sonuc4 = ogrenciler.FirstOrDefault(x => x.Ad == "Nur");
            if (sonuc4 != null) // null check
            {
                MessageBox.Show(sonuc4.Ad);
            }
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci() { Ad = "Batu", Soyad = "Alakaş", Yas = 26 },
                new Ogrenci() { Ad = "Orkun", Soyad = "İnce", Yas = 29 },
                new Ogrenci() { Ad = "Eray", Yas = 29, Soyad= "Ergin" },
                new Ogrenci(){ Ad = "Ömer", Soyad="Eroğlu", Yas = 24 },
                new Ogrenci(){Ad="Leyla",Soyad="Taş",Yas = 27},
                new Ogrenci(){Ad="Mustafa",Soyad="Yılmaz",Yas = 27}
            };
            // yaşı 27 olanları getir.
            var sonuc = ogrenciler.Where(x => x.Yas == 27).ToList();
            var sonuc1 = ogrenciler.Where(x => x.Ad.Length == 5).ToList();
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            var sayilar = new List<int>() { 29, 11, 10, 9, 2, 3, 45 };
            var minDeger = sayilar.Min();
            var maxDeger = sayilar.Max();
            List<Ogrenci> ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci() { Ad = "Batu", Soyad = "Alakaş", Yas = 26 },
                new Ogrenci() { Ad = "Orkun", Soyad = "İnce", Yas = 29 },
                new Ogrenci() { Ad = "Eray", Yas = 29, Soyad= "Ergin" },
                new Ogrenci(){ Ad = "Ömer", Soyad="Eroğlu", Yas = 24 },
                new Ogrenci(){Ad="Leyla",Soyad="Taş",Yas = 27},
                new Ogrenci(){Ad="Mustafa",Soyad="Yılmaz",Yas = 27}
            };
            var enGencOgrenci = ogrenciler.Min(x => x.Yas);
            var enYasliOgrenci = ogrenciler.Max(x => x.Yas);

            // en genç öğrencinin tüm bilgilerini getir.
            var enGencOgrenci1 = ogrenciler.FirstOrDefault(x => x.Yas == ogrenciler.Min(y => y.Yas));
            

        }

        private void btnSiralama_Click(object sender, EventArgs e)
        {
            // order by (küçükten büyüğe)
            var sayilar = new List<int>() { 29, 11, 10, 9, 2, 3, 45 };
            var siralanmisList = sayilar.OrderBy(x => x);
            // order by descending  (büyükten küçüğe)
            List<Ogrenci> ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci() { Ad = "Batu", Soyad = "Alakaş", Yas = 26 },
                new Ogrenci() { Ad = "Orkun", Soyad = "İnce", Yas = 29 },
                new Ogrenci() { Ad = "Eray", Yas = 29, Soyad= "Ergin" },
                new Ogrenci(){ Ad = "Ömer", Soyad="Eroğlu", Yas = 24 },
                new Ogrenci(){Ad="Leyla",Soyad="Taş",Yas = 27},
                new Ogrenci(){Ad="Mustafa",Soyad="Yılmaz",Yas = 27}
            };
            var adaGoreSirala = ogrenciler.OrderBy(x => x.Ad).ToList();
            var soyAdaGoreTerstenSirala = ogrenciler.OrderByDescending(x => x.Soyad).ToList();

        }
    }
}
