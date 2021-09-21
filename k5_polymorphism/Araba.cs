using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k5_polymorphism
{
    class Araba : Urun
    {
        // metodu yazmandan önce "override" kodunu yazıyoruz.
        // kdv oranını %18 den %45 yaptık.
        public string Modeli { get; set; }
        public int MotorHacmi { get; set; }
        public override double KdvliFiyatGetir()
        {
            double kdvOrani = 0;
            if (MotorHacmi >= 1000 && MotorHacmi < 2000)
            {
                kdvOrani = 1.45;
                
            }
            else if (MotorHacmi >= 2000 && MotorHacmi < 2500)
            {
                kdvOrani = 2.5;
                
            }
            else if(MotorHacmi >= 2500)
            {
                kdvOrani = 4;
                
            }
            else
            {
                kdvOrani=0;
                
            }
            return BirimFiyat * kdvOrani;


            ////bu benim yaptığım.
            //if (MotorHacmi >= 1000 && MotorHacmi < 2000)
            //{
            //    return BirimFiyat * 1.45;
            //}
            //if (MotorHacmi >= 2000 && MotorHacmi < 2500)
            //{
            //    return BirimFiyat * 2.5;
            //}
            //if (MotorHacmi >= 2500)
            //{
            //    return BirimFiyat * 4;
            //}
            //else
            //{
            //    System.Windows.Forms.MessageBox.Show("Geçerli Bir Motor Hacmi giriniz");
            //    return BirimFiyat;
            //}

        }

    }
}
