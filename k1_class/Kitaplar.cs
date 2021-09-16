using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_class
{
    class Kitaplar
    {
        public override string ToString()
        {
            return this.KitapAdi;

        }
        string _kitapAdi;
        public string KitapAdi
        {
            get { return _kitapAdi; }
            set { _kitapAdi = value; }
        }
        string _yazarinAdiSoyadi;
        public string YazarinAdiSoyadi
        {
            get { return _yazarinAdiSoyadi; }
            set { _yazarinAdiSoyadi = value; }
        }
        double _fiyati;
        public double Fiyat
        {
            get { return _fiyati; }
            set { _fiyati = value; }
        }
        string _turu;
        public string Tur
        {
            get { return _turu; }
            set { _turu = value; }
        }
        string _yayinEvi;
        public string YayinEvi
        {
            get { return _yayinEvi; }
            set { _yayinEvi = value; }
        }
        DateTime _basimTarihi;
        public DateTime BasimTarihi
        {
            get { return _basimTarihi; }
            set { _basimTarihi = value; }
        }

        int _sayfaSayisi;
        public int SayfaSayisi
        {
            get { return _sayfaSayisi; }
            set { _sayfaSayisi = value; }
        }
        
          

    }
}
