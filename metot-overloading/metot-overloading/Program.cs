using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metotlar metotlar = new Metotlar();
            int sayi = 5;
            string sayi2 = "23";
            metotlar.yazdir(sayi);
            metotlar.yazdir(sayi2);
        }
    }

    public class Metotlar
    {
        public void yazdir(int sayi)
        {
            Console.WriteLine("Sayınız: "+sayi.ToString());
        }
        public void yazdir(string sayi)
        {
            Console.WriteLine("Sayınız: "+sayi);
        }
    }
}
