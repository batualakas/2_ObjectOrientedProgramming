using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k4_AccessModifiers
{
    //SINIFIN ÖNÜNE PROTECTED YAZAMAYIZ!!
   internal class ElektronikUrun
    {
        // burda protected yazdığımız değerler diğer alt sınıflarda kapatılacak.
        protected  double GerilimDegeri { get; set; } = 100;
        protected  double Direnc { get; set; }
        public double Sicaklik { get; set; }
        public double TuketilenGuc { get; set; }

        void KwHesaplama() // tamamen örnek
        {
            var sonuc = TuketilenGuc * Direnc / GerilimDegeri;
        }

    }
}
