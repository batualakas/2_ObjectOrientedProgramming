using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k10_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<int> sayilar = new List<int>();
        List<Motosiklet> motosikletler = new List<Motosiklet>();
        private void btnList_Click(object sender, EventArgs e)
        {
            //List: Dizilerin gelişmiş hali

            ArrayList iller = new ArrayList();
            iller.Add("Ankara");
            iller.Add(34);
            // T: herhangi bir veri tippi (generic)


            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);

            //bolumler adında bir liste oluşturunuz ve içine birkaç veri giriniz.

            List<string> bolumler = new List<string>();
            //1.nesne oluşturma yöntemi

            Motosiklet m1 = new Motosiklet();
            m1.MotorHacmi = 1.2;
            m1.TekerlikSayisi = 2;
            m1.Rengi = Color.Black;
            motosikletler.Add(m1);

            // 2. yöntem
            Motosiklet m2 = new Motosiklet()
            {
                MotorHacmi = 0.6,
                TekerlikSayisi = 3,
                Rengi = Color.Red


            };
            motosikletler.Add(m2);


            List<Ogrenci> ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci() { Ad = "Batu", Soyad = "Alakaş", Yas = 26 }
                


            };
            foreach (var ogrenci in ogrenciler)
            {
                lstBox.Items.Add(ogrenci);
            }







        }
    }
}
