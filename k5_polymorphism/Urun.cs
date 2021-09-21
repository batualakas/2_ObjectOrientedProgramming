using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k5_polymorphism
{
    class Urun
    {
        public double BirimFiyat { get; set; }
        public int StokMiktari { get; set; }

        //Constructor'u hızlı oluşturmak için "ctor" tab tab'a basarsak hızlı oluşur.
        //"prop tab tab" ile aynı mantık.
        //"propfull tab tab" ile'de field ve propertylerin açık halde yazılması.
        

        // public'ten sonra virtual ekleyerek bu metodu altsınıflara miras olarak aktarabiliriz.
        public virtual double KdvliFiyatGetir()
        {
            
            //%18 tüm ürünlerde %18'lik bir kdv artışı ile ürünün satış fiyatını dönen bir metot yazdık
            // Farklı motor hacmine göre farklı kdv oranları getir.

            return BirimFiyat * 1.18;
            
        }
        







    }
}
