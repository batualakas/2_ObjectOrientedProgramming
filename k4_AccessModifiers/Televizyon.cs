using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k4_AccessModifiers
{
    class Televizyon : ElektronikUrun
    {

        
        public double GerilimiDusur()
        {
            // GerilimDegeri; base sınıfta protected olarak tanımlanmış olan "GerilimDegeri" property'sini burada kullanabiliriz.
            GerilimDegeri = 10;
            return GerilimDegeri / 10;
        }



    }
}
