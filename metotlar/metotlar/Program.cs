using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(3,5));
            Yaz selamlama = new Yaz();
            selamlama.yazdir();
            int a = 5;
            int b = 2;
            int normalToplam = Topla(a, b);
            Console.WriteLine("A değeri: "+a.ToString()+" B değeri: "+b.ToString()+" Sonucunuz: "+normalToplam.ToString());
            int refToplam = RefTopla(ref a, ref b);
            Console.WriteLine("A değeri: " + a.ToString() + " B değeri: " + b.ToString() + " Sonucunuz: " + refToplam.ToString());
        }
        static int Topla(int a, int b)
        {
            return a += b;
        }
        static int RefTopla(ref int a, ref int b)
        {
            return a += b;
        }
        class Yaz
        {
            public void yazdir()
            {
                Console.WriteLine("Selam Hoşgeldin.");
            }
        }
    }
}
