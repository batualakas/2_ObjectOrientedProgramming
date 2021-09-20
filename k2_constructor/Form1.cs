using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k2_constructor
{
    public partial class Form1 : Form
    {
        /*
         constructor : Yapıcı metot ( sınıfa özel bir metottur.) sınıf oluşturmakla görevlidir. birden fazla overload'u yazılabilir. 
        eğer constructor özellikle tanımlanmazsa arkada çalışan bir constructor bulunur.

        Sınıf ile aynı isimde olmak zorundadır.
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();//sınıfın instance'ı oluşturulduğunda constructor metot bu şekilde çağrılır.
            
            Ogrenci yeniOgrenci = new Ogrenci();
            // 1.yöntem;
            yeniOgrenci.Name = "Batu";
            yeniOgrenci.Surname = "Alakaş";
            // 2. yöntem 
            Ogrenci yeniOgrenci2 = new Ogrenci("Batu", "Alakas", "5598654339800");


        }
    }
}
