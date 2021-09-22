using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k6_Abstraction
{
    public partial class Form1 : Form
    {
        /*
         Soyutlama(abstraction): Base sınıflar genellikle miras vermek için oluşturulurlar yani bu sınıflardan instance almak doğru bir yöntem değildir. Bu nedenle base sınıftan instance alınması engellenicek şekilde soyutlayabiliriz.
         Eğer abstract sınıfın önüne konusulursa bu sınıftan instance alınmasını engeller.
        Abstract bir metot yada property yaparsanız sınıfa da abstract eklemeniz gerekir.
         abstract olarak tanımlanan bir metodun gövdesi tanımlanmaz. Miras alınan sınıf için bu metodun gövdesi tanımlanır.
        *** Eğer metoda abstract olarak işaretlersek miras alan sınıflarda bu alanı doldurulmak zorunda kalır. Virtual-override olayında isterse kodu kullanıyorduk. Fakat abstract dersek zorunda kalırız. Ve ezeriz.
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Şu anda base sınıftan instance alabiliyoruz. Bunu yapamamamız lazım.
            //Urun u1 = new Urun();
            //u1.Fiyat = 11; bu yapabildiğimiz zamandı.

            // bunu engellemek için sınıfın oluşturulduğu yere abstract komutunu ekleyeceğiz.(başına) "abstract class Urun" artık Urun sınıfından instance alamıyoruz.
            Telefon t1 = new Telefon();
            t1.Fiyat = 5467;
            t1.EkranBoyutu = 5.6;
            var telefonSatisFiyati = t1.KdvHesapla();

            Bilgisayar b1 = new Bilgisayar();
            b1.Fiyat = 3400;
            b1.HardDiskBoyutu = 1000;
            var bilgisayarSatisFiyati = b1.KdvHesapla();






        }
    }
}
