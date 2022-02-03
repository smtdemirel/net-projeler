using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritma_sorulari4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz, bu program girdiğiniz cümlenin toplam kelime ve harf sayısını hesaplamaktadır, hazırsanız başlayalım :)");
            Console.WriteLine("Lütfen Bir Cümle Giriniz: ");
            String cumle = Console.ReadLine();
            String[] kelimeler = cumle.Split(' ');
            int kelimeSayisi = kelimeler.Length;
            int harfSayisi = cumle.Length;
            Console.WriteLine("Girdiğiniz Cümlenin Kelime Sayısı: "+kelimeSayisi.ToString());
            Console.WriteLine("Girdiğiniz Cümlenin Harf Sayısı: "+harfSayisi.ToString());
            Console.WriteLine("Program sona erdi, bitirmek için bir tuşa basınız...");
            Console.ReadLine();


        }
    }
}
