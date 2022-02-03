using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempSayi = int.Parse(Console.ReadLine());
            int sonuc = 0;
            while(tempSayi != -1)
            {
                sonuc += tempSayi;
                tempSayi = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sonucunuz: "+sonuc);
            List<string> renk = new List<string>();
            renk.Add("Kırmızı");
            renk.Add("Mavi");
            renk.Add("Turuncu");
            renk.Add("Beyaz");
            renk.Add("Gri");
            foreach (var item in renk)
            {
                Console.WriteLine(item);
            }
        }
    }
}
