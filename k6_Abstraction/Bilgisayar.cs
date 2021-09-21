using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k6_Abstraction
{
    class Bilgisayar : Urun
    {
        public int Ram { get; set; }
        public int HardDiskBoyutu { get; set; }
        public override double KdvHesapla()
        {   
            return Fiyat * 1.12;
        }
    }
}
