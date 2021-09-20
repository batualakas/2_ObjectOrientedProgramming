using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k3_Inheritance
{
    // İKİ NOKTA ÜST ÜSTE İNSAN YAPARSAK ARTIK BU SINIF İNSAN SINIFININ ALT SINIFI OLUR VE ÜSTTE GİRDİĞİMİZ VERİLERİ TEKRAR GİRMEMİZE GEREK KALMAZ.
    class Ogrenci : Insan
    {
        //public string Ad { get; set; }
        //public string Soyad { get; set; }
        //public double Boy { get; set; }
        //public double Kilo { get; set; } BUNLARI ZATEN TANIMLADIK O YÜZDEN TEKRAR YAZMAMIZA GEREK YOK
        public string Sinifi { get; set; }
        public string OgrenciNo { get; set; }
        public double Ortalama { get; set; }
    }

}
