using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Data
{
    // sınıfın başına public kodunu ekleyerek sınıfı dışarı açtık.
    // daha sonradan bu sınıfı hangi projeye eklemek istediğimizi seçmek için projenin referanslarından OBS datayı ekledik.
    // "Ogrenciler" yazdıktan sonra "ctrl+." ile bu referansı seçiyoruz.
   public class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tckn { get; set; }
    }

}
