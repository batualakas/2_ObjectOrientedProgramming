using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    class Marti : Kus, IYuzebilir, IUcabilir
    {
        
        public double YuzmeDerinligi { get; set; }
        #region İnterface'den aldık.

        
        public double MaxInebilecegiDerinlik { get; set; }
        public UzunlukBirimi Birimi { get ; set ; }
        public double MaxUcabilecegiYukseklik { get ; set ; }
        public UzunlukBirimi MaxUcabilecegiYukseklikBirimi { get ; set; }

        public void Uc()
        {
            
        }

        public void Yuz()
        {

        }
        #endregion
    }
}
