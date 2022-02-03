using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int not;
            bool notDurum = int.TryParse(Console.ReadLine(),out not);
            if(notDurum == true)
            {
                switch (not)
                {
                    case 60: Console.WriteLine("CC");
                        break;
                    case 70: Console.WriteLine("CB");
                        break;
                    case 80: Console.WriteLine("BB");
                        break;
                    case 90: Console.WriteLine("AA");
                        break;
                    default: Console.WriteLine("Harf notu aralığında giriniz.");
                        break;
                }
            }else
                {
                    Console.WriteLine("Yanlış not girdiniz.");
                }
        }
    }
}
