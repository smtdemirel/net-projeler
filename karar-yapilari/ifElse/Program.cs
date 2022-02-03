using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String stringTarih = DateTime.Now.Hour.ToString();
            int intTarih = DateTime.Now.Hour;

            if(intTarih>12)
            {
                Console.WriteLine("Vakit öğlenden sonra");
            }
            else
            {
                Console.WriteLine("Vakit öğleden önce");
            }
        }
    }
}
