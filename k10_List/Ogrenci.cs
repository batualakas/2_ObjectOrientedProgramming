using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k10_List
{
    class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public override string ToString()
        {
            return $"{this.Ad}  {this.Soyad } {this.Yas}";
        }
    }
}
