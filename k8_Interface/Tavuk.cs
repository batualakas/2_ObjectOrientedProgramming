using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    class Tavuk : Kus, IUcabilir
    {
        public int AylikYumurtaSayisi { get; set; }
        public double YumurtlamaSuresi { get; set; }
        public double MaxUcabilecegiYukseklik { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public UzunlukBirimi MaxUcabilecegiYukseklikBirimi { get  ; set ; }

        public void Uc()
        {
           ;
        }
    }
}
