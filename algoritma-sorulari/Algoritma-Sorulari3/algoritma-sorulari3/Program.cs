using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritma_sorulari3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz, bu program kullanıcıdan bir adet sayı alarak girdiği sayı kadar kelime girmesini beklemektedir. Girdiği sayı kadar kelime girdiğinde kelimeler sonda başa doğru yazdırılacaktır. Hazırsanız başlayalım :)");
            Console.WriteLine("Girmek istedğiniz kelime sayısını giriniz: ");
            int sayi = 0;
            bool kontrol = int.TryParse(Console.ReadLine(), out sayi);
            if (kontrol== true)
            {
                String[] kelimeler = new String[sayi];
                String tempKelime = "";
                for (int i = 0; i < sayi; i++)
                {
                    Console.WriteLine((i+1).ToString()+". kelimeyi giriyorsunuz: ");
                    tempKelime = Console.ReadLine();
                    kelimeler[i] = tempKelime;
                }
                Array.Reverse(kelimeler);
                Console.WriteLine("Kelime girimi bitti tersten yazdırılıyor...");
                Console.WriteLine("Kelimelerin Sondan Başa Doğru: ");
                foreach (var item in kelimeler)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Program sona erdi, bitirmek için bir tuşa basınız...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hatalı Sayı girdiniz çıkılıyor...");
                Console.WriteLine("Program sona erdi, bitirmek için bir tuşa basınız...");
                Console.ReadLine();
            }
            
        }
    }
}
