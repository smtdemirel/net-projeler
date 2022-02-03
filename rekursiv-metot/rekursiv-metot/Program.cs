using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekursiv_metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UsAl(2, 4)); 
        }
        static public int UsAl(int sayi, int us)
        {
            if (us >= 2) { 
            return UsAl(sayi, us - 1) * sayi;
            }
            else
            {
                return sayi;
            }
        }
    }
}
