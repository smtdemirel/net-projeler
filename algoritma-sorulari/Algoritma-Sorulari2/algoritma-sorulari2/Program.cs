using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritma_sorulari2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz, bu program n tane sayi alarak ikinci defa isteyeceğimiz M sayısına eşit veya ona bölünebilen sayıları hesaplamaktadır. Kullanmak için ekrana çıkacak talimatlara uymanız yeterlidir.");
            Console.WriteLine("Bölünmesini Kontrol Etmek istediğiniz Sayilari Giriyorsunuz...");
            List<int> list = new List<int>();
            int bolunecek;
            int tempN;
            bool boluncekKontrol = int.TryParse(Console.ReadLine(), out tempN);
            Console.WriteLine("M Sayisini Giriyorsunuz:");
            bool tempNKontrol = int.TryParse(Console.ReadLine(), out bolunecek);
            if(boluncekKontrol == true && tempNKontrol == true)
            {
                while (tempNKontrol == true && tempN != -1)
                {
                    if (bolunecek % tempN == 0 || tempN == bolunecek)
                    {
                        list.Add(tempN);
                    }
                    Console.WriteLine("Bölünmesini Kontrol Etmek istediğiniz Sayilari Giriyorsunuz...");
                    Console.WriteLine("Bitirmek için -1 veya int olmayan bir sayı giriniz.");
                    tempNKontrol = int.TryParse(Console.ReadLine(), out tempN);
                }
                Console.WriteLine("Döngü bitti M Sayisına Eşit veya Tam Bölünebilen Sayılar: ");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Program sona erdi bitirmek için bir tuşa basınız...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hatalı Sayı veya sayılar girdiniz program sona erdi.");
                Console.WriteLine("Program sona erdi bitirmek için bir tuşa basınız...");
                Console.ReadLine();
            }
        }
    }
}
