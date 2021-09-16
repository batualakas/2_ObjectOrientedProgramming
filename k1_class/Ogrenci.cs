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


        // public string _ad;
        //public string _soyad;
        //public string _ogrenciNumarasi;
        //public string _adres;
        //public string _kanGrubu;
        //public string _bolum;
        // OOP'nin encapsulation kuralı doğrultusunda fieldlar sınıf içinde private olarak tanımlanmalıdır.
        // Property ile fieldara değerleri kontrollü bir şekilde aktarabiliriz ve ya fieldın taşıdığı değeri kullancıyı gönderebiliriz...
        // Erişim belirleyicisi public olmalıdır.
        // field ile aynı veri tipinde tanımlanır
        // Pascal Case Notasyonu kullanılır.

        // proprtylerde get bloğu olmak zorundadır.

        private string _ad;
        public string Ad
        {
            get
            {
                return _ad;
            }
            set
            {
                // dışarıdan alınan verinin kontrol edilerek fielda atanması işlemi burada yapılır, value 
                _ad = value;
         
            }
        }
        private string _soyad;
        public string Soyad
        {
            get
            {
                return _soyad;
            }
            set
            {
                _soyad = value;
            }
        }

        private string _ogrenciNumarasi;
        public string OgrenciNumarasi
        {
            get
            {
                return _ogrenciNumarasi;
            }
            set
            {
                _ogrenciNumarasi = value;
            }
        }
        private string _adres;
        public string Adres
        {
            get
            {
                return _adres;
            }
            set
            {
                _adres = value;
            }
        }

        private string _kanGrubu;
        public string KanGrubu
        {
            get { return _kanGrubu; }
            set { _kanGrubu = value; }
        }
        private string _bolum;
        public string Bolum
        {
            get
            {
                return _bolum;
            }
            set
            {
                _bolum = value;
            }
        }
        private int _yas; 
        public int Yas
        {
            get
            {
                var simdikiZaman = DateTime.Now;
                var fark = simdikiZaman - _dogumTarihi;
                var yas = fark.Days / 365;
                return yas;
            }
            set
            {
                _yas = value;
            }
        }
        private DateTime _dogumTarihi;
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }

    }
}
