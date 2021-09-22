using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    class Karga :Kus, IUcabilir
    {
        public int Yas { get; set; }
        public double MaxUcabilecegiYukseklik { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public UzunlukBirimi MaxUcabilecegiYukseklikBirimi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Uc()
        {
            throw new NotImplementedException();
        }
    }
}
