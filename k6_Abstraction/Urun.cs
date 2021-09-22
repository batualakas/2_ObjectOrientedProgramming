using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k6_Abstraction
{
    abstract class Urun
    {
        public double Fiyat { get; set; }
        public abstract double KdvHesapla();

        
    }
}
