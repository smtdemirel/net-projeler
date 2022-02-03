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
            int[] sayilar = { 5, 8, 2, 5, 7, 98, 12, 344, 45, 678, 67 };
            int count = sayilar.Length;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(sayilar[i]); 
            }
            Array.Sort(sayilar);
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(sayilar);
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
