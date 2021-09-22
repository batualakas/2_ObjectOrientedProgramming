using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k9_StaticConst
{
    /*
     static keyword : Eğer bir sınıf static diye işaretlenirse bu sınıftan instance alınamaz. Ram üzerine bir kez çıkmasını sağlayan anahtar kelimedir. Bu sınıf içinde tanımlanan tüm metot ve ya propertler de static tanımlanmak zorundadır. Kullanılmak istendiğinde SinifAdi.PropertAdi ve ya SinifAdi.MetotAdi() şeklinde kullanım yapılır.
     ***** STATİC kullanırken 3 kez düşünün. 
     ** Garbage collector.
     * const keyword : Sabit bir değer tanımlamak için kullanılır ve değeri sonrada değiştirilemez.

*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var eulerSabiti = Matematik.EulerSabiti;
            // Helpers : 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // var sonuc = Matematik.KarelerFarkiniAl(2, 3);
            // MessageBox.Show($"{sonuc}");
            
            
        }
    }
}
