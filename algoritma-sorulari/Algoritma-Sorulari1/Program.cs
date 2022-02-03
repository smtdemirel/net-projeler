using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Sorulari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Hoşgeldiniz, bu program girdiğiniz pozitif tam sayılardan çift olanları hesaplayıp ekrana yazdırmaktadır. Kullanmak için ekrana çıkacak talimatlara uymanız yeterlidir.");
            Console.WriteLine("Lütfen pozitif tam sayılar giriniz: ");
            int sayi;
            bool kontrol = int.TryParse(Console.ReadLine(), out sayi);
            while (kontrol == true && sayi != -1)
            {
                if (sayi % 2 == 0)
                {
                    list.Add(sayi);
                    Console.WriteLine("Bitirmek için string veya -1 giriniz:");
                    Console.WriteLine("Lütfen pozitif tam sayılar giriniz: ");
                    kontrol = int.TryParse(Console.ReadLine(), out sayi);
                }
                else
                {
                    Console.WriteLine("Bitirmek için string veya -1 giriniz:");
                    Console.WriteLine("Lütfen pozitif tam sayılar giriniz: ");
                    kontrol = int.TryParse(Console.ReadLine(), out sayi);
                }
            }
            Console.WriteLine("Girdiğiniz Çift Sayılar: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Program sona erdi, bitirmek için bir tuşa basınız...");
            Console.ReadLine();
        }
    }
}
