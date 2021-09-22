using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k9_StaticConst
{
    public static class Matematik
    {
        // public static double EulerSabiti = 0.57721; // bu sabitin değerini değiştirilebilir olsun istemiyoruz. o yüzden buna const ekleyeceğiz. Static olursa değiştirilebilir ama const olursa değiştirelemez.
        public const double EulerSabiti = 2.7182818;

        public const double PisagorSabiti = 1.4142135;

        public static double KarelerFarkiniAl(double sayi1, double sayi2)
        {
            var sayi1Karesi = Math.Pow(sayi1, 2);
            var sayi2Karesi = Math.Pow(sayi2, 2);
            var karelerFarki = sayi1Karesi - sayi2Karesi;
            return karelerFarki;
            // bu static bir metot oldu. yani içerdeki değerler değiştirilebilir fakat ram üstene 1 kez gelir yazılır ve biter.
        }
    }
}
