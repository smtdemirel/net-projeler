using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.KacTekeriVar());
            Console.WriteLine(focus.MarkasiNedir());
            Console.WriteLine(focus.RengiNedir());
            Console.WriteLine("******************");
            Civic civic = new Civic();
            Console.WriteLine(civic.KacTekeriVar());
            Console.WriteLine(civic.MarkasiNedir());
            Console.WriteLine(civic.RengiNedir());
            Console.WriteLine("******************");
            Fiesta fiesta = new Fiesta();
            Console.WriteLine(fiesta.KacTekeriVar());
            Console.WriteLine(fiesta.MarkasiNedir());
            Console.WriteLine(fiesta.RengiNedir());
        }
    }
}
