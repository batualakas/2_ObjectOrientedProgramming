using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_class
{
    class Ogrenciler
    {
        
        string _ogrenciAdi;
        public string OgrenciAdi
        {
            get { return _ogrenciAdi; }
            set { _ogrenciAdi = value; }
        }
        int _ogrenciNo;
        public int OgrenciNo
        {
            get { return _ogrenciNo; }
            set { _ogrenciNo = value; }
        }
        string _fakulte;
        public string Fakulte
        {
            get { return _fakulte; }
            set { _fakulte = value; }

        }
        string _bolum;
        public string Bolum
        {
            get { return _bolum; }
            set { _bolum = value; }
        }
        string _sinif;
        public string Sinif
        {
            get { return _sinif; }
            set { _sinif = value; }
        }
        public override string ToString()
        {
            return this.OgrenciAdi;
        }

    }
}





