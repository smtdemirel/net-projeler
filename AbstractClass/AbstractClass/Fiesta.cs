using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Fiesta : IOtomobil
    {
        public int KacTekeriVar()
        {
            return 4;
        }

        public Marka MarkasiNedir()
        {
            return Marka.Ford;
        }

        public Renk RengiNedir()
        {
            return Renk.Gri;
        }
    }
}
