using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int n = 20;
            int[] numbers = new int[n];
            int[] bigNumbers = new int[3];
            int[] smallNumbers = new int[3];
            Console.WriteLine("Hoşgeldiniz, bu program girdiğiniz 20 adet pozitif tam sayılardan En Büyük ne En Küçük 3 tanesini bularak bunların toplamını ve ortalamasını ekrana basar.Kullanmak için ekrana çıkacak talimatlara uymanız yeterlidir.");
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Lütfen Pozitif {0}. Sayıyı Giriniz: ", (i + 1));
                int.TryParse(Console.ReadLine(), out temp);
                if (temp > 0)
                {
                    numbers[i] = temp;
                }
            }
            Console.WriteLine("Sayı Girimi bitti Yazdırılıyor...");
            Console.WriteLine();
            Console.WriteLine();
            for (int i=0; i<n; i++)
            {
                for(int j=0; j<n-1; j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                        var tempNumber = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = tempNumber;
                    }
                }
            }
            int bigSum = 0;
            double bigAverage;
            int smallSum = 0;
            double smallAverage;
            for (int i=0; i<3; i++)
            {
                bigNumbers.Append(numbers[(n-1) - i]);
                smallNumbers.Append(numbers[i]);
                bigSum += numbers[(n - 1) - i];
                smallSum += numbers[i];
            }
            bigAverage = bigSum / 3.0;
            smallAverage = smallSum / 3.0;

            Console.WriteLine("En Büyük 3 Elemanın Toplamı: {0} Ortalaması: {1}", bigSum.ToString(), Math.Round(bigAverage,2).ToString());
            Console.WriteLine("Büyük elemanlar Bitti Küçük Elemanlara Geçiliyor..");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("En Küçük 3 Elemanın Toplamı: {0} Ortalaması: {1}", smallSum.ToString(), Math.Round(smallAverage,2).ToString());
            Console.WriteLine("Küçük elemanlar Bitti Çıkılıyor..");
        }
    }
}
