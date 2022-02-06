using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalList = new ArrayList();
            ArrayList asalOlmayanList = new ArrayList();
            int temp;
            bool control = false;
            Console.WriteLine("Hoşgeldiniz, bu program girdiğiniz 20 adet pozitif tam sayılardan Asal olan ve Asal Olmayanları tespit edip sıralar. Sıraladıktan sonra ekrana basar ve eleman sayılarını ve ortalamalarını bulur. Kullanmak için ekrana çıkacak talimatlara uymanız yeterlidir.");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Lütfen Pozitif {0}. Sayıyı Giriniz: ", (i + 1));
                int.TryParse(Console.ReadLine(), out temp);
                if (temp > 0)
                {
                    for(int j = 2; j <= temp/2; j++)
                    {
                        if(temp%j == 0)
                        {
                            control = true;
                        }
                    }
                }
                if (control == true)
                {
                    if(temp == 2)
                    {
                        asalList.Add(temp);
                    }
                    else
                    {
                        asalOlmayanList.Add(temp);
                    }
                }
                else
                {
                    if (temp == 1)
                    {
                        asalOlmayanList.Add(temp);
                    }
                    else
                    {
                        asalList.Add(temp);
                    }
                }
                control = false;
            }
            Console.WriteLine("Sayı Girimi bitti Yazdırılıyor...");
            Console.WriteLine();
            Console.WriteLine();
            asalList.Sort();
            asalOlmayanList.Sort();
            Console.WriteLine("Asal Sayılar: ");
            foreach (int i in asalList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Asal Sayılar Bitti...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Asal Olmayan Sayılar: ");
            foreach (int i in asalOlmayanList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Asal Olmayan Sayılar Bitti...");
            Console.WriteLine();
            Console.WriteLine();
            int asalElemanSayisi = asalList.Count;
            double asalElemanSayisiToplam = 0;
            foreach (int i in asalList)
            {
                asalElemanSayisiToplam += i;
            }
            var asalOrtalama = asalElemanSayisiToplam/asalElemanSayisi;
            Console.WriteLine("Asal Olan Listenin Eleman Sayısı: {0} Ortalaması: {1}", asalElemanSayisi.ToString(),Math.Round(asalOrtalama,2).ToString());
            Console.WriteLine();
            Console.WriteLine();
            int asalOlmayanElemanSayisi = asalOlmayanList.Count;
            double asalOlmayanElemanSayisiToplam = 0;
            foreach(int i in asalOlmayanList)
            {
                asalOlmayanElemanSayisiToplam += i;
            }
            var asalOlmayanOrtalama = asalOlmayanElemanSayisiToplam/asalOlmayanElemanSayisi;
            Console.WriteLine("Asal Olmayan Listenin Eleman Sayısı: {0} Ortalaması: {1}", asalOlmayanElemanSayisi.ToString(), Math.Round(asalOlmayanOrtalama,2).ToString());
        }
    }
}
