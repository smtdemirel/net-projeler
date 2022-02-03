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
            Console.WriteLine("Dizinin eleman sayısını giriniz.");
            int count = int.Parse(Console.ReadLine());  
            string[] renkler = new string[count];
            renkler.Append("Mavi");
            renkler[1] = "Kırmızı";
            renkler.Append("Sarı");

            foreach (var item in renkler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
