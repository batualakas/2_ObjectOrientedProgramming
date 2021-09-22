using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k6_Abstraction
{
    class Telefon : Urun
    {
        public double EkranBoyutu { get; set; }

        public override double KdvHesapla()
        {
            return Fiyat * 1.18;
        }
    }
}
