using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    interface IYuzebilir // interface'ın önüne erişim belirleyici yazılabilir.
        // Uzunluk birimlerini belirtmek için önce yeni bir enum oluşturduk. Daha sonra bu enom'u kullandığımız diğer sınıflara aktardık. martı penguen gibi.
    {
         double MaxInebilecegiDerinlik { get; set; }
          UzunlukBirimi Birimi { get; set; }

        void Yuz(); // : interface içindeki elemanlara erişim belirleyici yazılamaz For example: public void yapamayız. sadece void.
    }
}
