using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k5_polymorphism
{
    class Ekmek : Urun
    {
        public double EkmekBirimFiyati { get; set; }
        public int EkmekGramaj { get; set; }
        public string EkmekTuru { get; set; }

        public override double KdvliFiyatGetir()
        {
            double kdvOrani = 0;
            if (EkmekGramaj>=100 && EkmekGramaj<150 && EkmekTuru == "Beyaz Ekmek")
            {
                kdvOrani = 1.01;
            }
            else if(EkmekGramaj>=150 && EkmekGramaj<200 && EkmekTuru == "Beyaz Ekmek")
            {
                kdvOrani = 1.02;
            }
            else
            {
                kdvOrani=0;
                System.Windows.Forms.MessageBox.Show("Geçerli Bir Ürün Giriniz");
            }
            return EkmekBirimFiyati * kdvOrani;
        }
            
            
        
            
        
}
}
