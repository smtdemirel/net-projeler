using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bitkiler:Canlilar
    {
        public Bitkiler()
        {
            base.Bosaltim();
            base.Beslenme();
            base.Solunum();
        }

        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler Fotosentez Yapar.");
        }
    }
    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu Bitkiler Tohumla Çoğalır.");
        }
    }
    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
        }

        public void TohumsuzCogalanlar()
        {
            Console.WriteLine("Tohumsuz Çoğalanlar Sporla Çoğalır.");
        }
    }
}
