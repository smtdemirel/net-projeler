using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                else if (i == 4)
                {
                    Console.WriteLine("i = 4");
                }
                else if (i == 5) {
                    break;
                }
                else
                {
                    Console.WriteLine("i değeri: "+ i);
                }

            }
        }
    }
}
