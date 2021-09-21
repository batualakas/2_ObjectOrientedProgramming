using OBS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k4_AccessModifiers
{
    public partial class Form1 : Form
    {
        /*
         Erişim Belirleyiciler(Access Modifiers): Class veya Class elemanlarının başka bir class içinde kullanılması için erişimine izin veren anahtar kelimelerdir.

        1. Public : bir sınıfı yada sınıf elemanlarını public olarak belirtirsek bu elemanlar/sınıf hem proje içindeki diğer tüm sınıflar içinden hemde farklı bir projedeki sınıflar içinden erişime açık olur. Eğer bir proje içindeki sınıfın başka bir projeden görünür olmasını istiyosanız öncelikle sınıfın erişim belirleyicisini public yapınız, sonra kullanmak istediğiniz projeye referans olarak ekleyiniz. ardından using ile namespace tanımlaması yaparak kullanabilirsiniz.

        2. Internal: class veya class elemanları internal olarak işaretlenirse bu elemanlara/ sınıfa sadece bulunduğu proje içinden erişilebilir. Classların önüne birşey yazılmazsa defaultta internal olarak gözükür.(Hep yaptığımız yöntem buydu. Defaullta geldiği için belirtmedik)

        3. Protected : Sınıf içindeki elemanlar protected olarak işaretlendiyse miras alınan sınıf içinden görünür olurlar.  ** BUNA TEKRAR BAK ÖNEMLİ .

        4. Protected Internal : Hem protected'ın özelliklerini hem de Internal'ın özelliklerini sağlar.

        5. Private : Class'lara private yazamazsınız. Eğer class elemanlarına erişim belirleyici vermezseniz defaulltan private olarak davranır ve sadece sınıf içinden erişilebilir.
         
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // bu verileri OBS.DATA class'tan aldık. 
            Ogrenci student = new Ogrenci();
            student.Ad = textBox1.Text;
            student.Soyad = textBox3.Text;
            // Mesela elektronik ürünün alt sınıfı olan televizyon sınıfında tüm referansların gözükmesini istemiyoruz bu durumda istemediğimiz özelliklerin önüne "protected" yazacağız.

            ElektronikUrun eu = new ElektronikUrun();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
