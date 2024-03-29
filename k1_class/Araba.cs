﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_class
{
    class Araba
    {
        // galeri için araba sınıfı oluşturunuz.
        // arabaya ait özellikleri tutulabilmesi için fieldlar tanımlayınız.
        // buton oluşturup (araba ekle) 3 farklı araba bilgisini giriniz.
        public string _arabaMarkasi;
        public string _arabaModeli;
        public string _arabaYili;
        public string _arabaGaleridemi;
        
    }

    // OOP'nin encapsulation kuralı doğrultusunda fieldlar sınıf içinde private olarak tanımlanmalıdır.
    // Property ile fieldara değerleri kontrollü bir şekilde aktarabiliriz ve ya fieldın taşıdığı değeri kullancıyı gönderebiliriz...
    // Erişim belirleyicisi public olmalıdır.
    // field ile aynı veri tipinde tanımlanır
}
