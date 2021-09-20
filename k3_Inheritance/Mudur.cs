using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k3_Inheritance
{
    class Mudur : Ogretmen
        // Müdür sınıfı Öğretmen Sınıfının Altında olabilir çünkü aynı özellikler ikisinde de var.
    {
        //public String Brans { get; set; }
        //public string DiplomaNo { get; set; }
        //public string MezunOlduguOkul { get; set; }
        //public DateTime IseBaslamaTarihi { get; set; }
        // Bu özellikler zaten Öğretmen sınıfında mevcut olduğu için tekrarlamamıza gerek yok.
        public void DisiplinKurulunuTopla()
        {
            //
        }
    }

}
