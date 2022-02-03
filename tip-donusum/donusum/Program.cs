using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donusum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            int b = 6;
            short c = 8;
            Console.WriteLine(a+b+c);

            string sayi = "99";
            int number = 56;
            Console.WriteLine(sayi+number);
            Console.WriteLine(int.Parse(sayi)+number); 
            byte k = (byte)b;
            Console.WriteLine(k);
        }
    }
}
