using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            x += 2;
            Console.WriteLine(x);
            x = y;
            Console.WriteLine(x);
            x++;
            y *= x;
            Console.WriteLine(y);

            bool isSucces = true;
            if(isSucces)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);
            }
            bool sonuc = false;
            if(x > y)
            {
                sonuc = true;
            }else if (x == y)
            {
                sonuc |= true;
            }



        }
    }
}
