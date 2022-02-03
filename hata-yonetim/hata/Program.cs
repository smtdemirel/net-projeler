using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = int.Parse(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi: "+sayi);
            }catch(Exception ex)
            {
                Console.WriteLine("Hatanız: "+ex.ToString());
            }
            Console.WriteLine("Bir sayı giriniz:");
            int number;
            bool durum = int.TryParse(Console.ReadLine(), out number);
            if (durum)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Hatalı sayı girdiniz.");
            }

        }
    }
}
