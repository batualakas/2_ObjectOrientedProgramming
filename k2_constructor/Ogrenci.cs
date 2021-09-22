using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_constructor
{
    class Ogrenci
    {
        #region Constructors
        public Ogrenci()
        {

        }
        
        public Ogrenci(string name, string surname, string tckn)
        {
            this.Name = name;
            this.Surname = surname;
            this.TCKN = tckn;
        }

        #endregion

        #region Properties
        //private string _name;
        //public string Name { get { return _name; } set { _name = value; } } // _name 

        public string Name { get; set; }
        public string Surname { get; set; }
        public string TCKN { get; set; }
        

        #endregion

    }
}
