using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_class
{
    class Ogrenci
    {
        // sınıfın içinde veri tutmak için oluşturulan değişkenlere field ismi verilir.
        //fieldlar isimlendirilirken değişken isimlendirme kuralları geçerlidir, tek fark değişken isminin önünde _(alt tire) bulunur.

        // alt tire olması program açısından bir fark yaratmaz değişken olarak görecektir,
        // sınıflar birer şablondur.
        // random sayı üretirken yine aslında random classını kullandık bu da aynı şekilde kullanılır.
        // erişebilirlik sağlamak için kodların önüne public yazmamız gerekir. 'private' dersek sınıf erişebilir olmaz. eğer bir şey yazmazsak default olarak private gelir.

        public string _ad;
        public string _soyad;
        public string _ogrenciNumarasi;
        public string _adres;
        public string _kanGrubu;
        public string _bolum;

        //PRİVATE YAPARSAK BÖYLE. her hangi birşey belirtmedik.
        //string _ad;
        //string _soyad;
        // string _ad;
        // string _soyad;
        // string _ogrenciNumarasi;
        // string _adres;
        // string _kanGrubu;
        // string _bolum;

    }
}
