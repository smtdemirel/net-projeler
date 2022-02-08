using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvanlar hayvan = new Hayvanlar();
            hayvan.UyaranlaraTepkiVerir();
            Bitki bitki = new Bitki();
            bitki.UyaranlaraTepkiVerir();
        }
    }
}
