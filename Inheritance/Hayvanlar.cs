using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Hayvanlar:Canlilar
    {
        public Hayvanlar()
        {
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar Adaptasyon Kurabilie.");
        }
    }
    public class Sürüngenler:Hayvanlar
    {
        public Sürüngenler()
        {
            base.Adaptasyon();
        }

        public void SurunerekHareketEdenler()
        {
            Console.WriteLine("Sürüngenler Sürünerek Hareket Eder.");
        }
    }

    public class Kuslar:Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar Uçar");
        }
    }
}
