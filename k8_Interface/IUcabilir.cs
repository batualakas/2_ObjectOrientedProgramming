using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    interface IUcabilir
    {
        double MaxUcabilecegiYukseklik { get; set; }
        UzunlukBirimi MaxUcabilecegiYukseklikBirimi { get; set; }
        void Uc();
    }
}
