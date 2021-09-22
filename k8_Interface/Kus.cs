using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    abstract class Kus // base sınıfımız
    {
        public string TuyRengi { get; set; }
        public double GagaBoyu { get; set; }
        public UzunlukBirimi GagaBoyuBirimi { get; set; }
        public double KanatUzunlugu { get; set; }
        public UzunlukBirimi KanatUzunluguBirimi { get; set; }
        public bool AyagiPerdeliMi { get; set; }

        //void Uc()
        //{

        //}
          // Bu iki metota da uymayan hayvanlar var. Bu yüzden bu metotları buraya tanımlayamayız. Bunun için new item'lardan İnterface ekleyeceğiz.
        //void Yuz()
        //{

        //}
    }
    //class Tavuk : Kus
    //{

    //}
}
