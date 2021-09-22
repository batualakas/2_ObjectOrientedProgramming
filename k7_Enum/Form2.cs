using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k7_Enum
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Ekmek e1 = new Ekmek();
            //e1.Gramaj = 100;
            //e1.Tur = EkmekTuru.BeyazEkmek;
            //e1.Fiyat = 1.50;
            // Combobox'ın içini EkmekTuru enum'ının içindeki değerlerle dolduralım.
            // enum içindeki verileri direk alması için elle tek tek yazmak yerine combobox'a direk böyle yüklemek daha kolay çünkü yeni bir ekmekTuru değeri girmek istediğimizde tekrar combobox'a eklememiz gerekir.
            string[] ekmekTurleri = Enum.GetNames(typeof(EkmekTuru));
            cmbEkmekTuru.Items.AddRange(ekmekTurleri);


        }

        private void cmbEkmekTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ekmek e2 = new Ekmek();
            e2.Gramaj = Convert.ToDouble(txtGramaj.Text);
            e2.Fiyat = Convert.ToDouble(txtFiyat);
            var secilenTur = cmbEkmekTuru.SelectedItem.ToString();
            // 1. yöntem
            //switch (secilenTur)
            //{
            //    case "Beyaz Ekmek":
            //        e2.Tur = EkmekTuru.BeyazEkmek;

            //        break;
            //        switch (secilenTur)
            //        {
            //            case "Baget Ekmek":
            //                e2.Tur = EkmekTuru.BagetEkmek;

            //                break;
            //        }
            // Bu yöntemle tek tek enumları yazmamız gerekir. ( imkansız-iyi bi yöntem değil)


            // 2.yöntem
            var secilenEkmekTuruEnumi = (EkmekTuru)Enum.Parse(typeof(EkmekTuru),secilenTur);
            e2.Tur = secilenEkmekTuruEnumi;

        }
    }
}
