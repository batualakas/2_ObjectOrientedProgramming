using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k1_class
{
    public partial class Form1 : Form
    {
        /*
         Object Oriented Programming
        C#, java, C++, Pyhton
         Object(nesne)
         nesne oluşturmak için > projeye sağ tıklayıp class seçiyoruz,
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Öğrenci sınıfından bir kopya oluşturarak bir öğrencinin detay bilgisini girelim


            // sınıfta bir kopya üretilmesi işlemine instance almak denir.
            
            Ogrenci ogr = new Ogrenci(); // sınıflarda oluşturulan değişkenlere nesne denir.
            //ogr._ad = "Bahar";
            //ogr._soyad = "Taşbaş";
            //ogr._bolum = "Elektrik Elektronik Mühendisliği";
            //ogr._kanGrubu = "0 Rh +";
            //ogr._ogrenciNumarasi = "201453078";
            //ogr._adres = "Ankara Eryaman 3.etap falan filan ";
            //lblAd.Text = ogr._ad;
            //lblSoyad.Text = ogr._soyad;
            //lblBolumu.Text = ogr._bolum;
            //lblKanGrubu.Text = ogr._kanGrubu;
            //lblNumarasi.Text = ogr._ogrenciNumarasi;
            //lblAdres.Text = ogr._adres;

            //Ogrenci ogr1 = new Ogrenci();
            //ogr1._ad = "Batu";
            //ogr1._soyad = "Alakaş";
            //ogr1._bolum = "No bölüm";
            //ogr1._kanGrubu = "A Rh+";
            //ogr1._ogrenciNumarasi = "20131231";
            //ogr1._adres = "Ankara Eryaman 3. etap wow";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Araba araba1 = new Araba();
            araba1._arabaGaleridemi = "hayır";
            araba1._arabaMarkasi = "Mercedes";
            araba1._arabaModeli = "CLA 200";
            araba1._arabaYili = "2016";
            lbl1markasi.Text = araba1._arabaMarkasi;
            lbl1Modeli.Text = araba1._arabaModeli;
            lbl1Stok.Text = araba1._arabaGaleridemi.ToString();
            lbl1Yili.Text = araba1._arabaYili;
            Araba araba2 = new Araba();
            araba2._arabaYili = "2021";
            araba2._arabaGaleridemi = "evet";
            araba2._arabaMarkasi = "BMW";
            araba2._arabaModeli = "320d";
            lbl2markasi.Text = araba2._arabaMarkasi;
            lbl2Modeli.Text = araba2._arabaModeli;
            lbl2Stok.Text = araba2._arabaGaleridemi.ToString();
            lbl2Yili.Text = araba2._arabaYili;
            Araba araba3 = new Araba();
            araba3._arabaYili = "2018";
            araba3._arabaModeli = "A5";
            araba3._arabaMarkasi = "Audi";
            araba3._arabaGaleridemi = "Hayır";
            lbl3markasi.Text = araba3._arabaMarkasi;
            lbl3Modeli.Text = araba3._arabaModeli;
            lbl3Stok.Text = araba3._arabaGaleridemi.ToString();
            lbl3Yili.Text = araba3._arabaYili;
        }
    }
}
