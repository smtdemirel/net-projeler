using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz, bu program girdiğiniz cümle içerisindeki sesli harfleri tespit edip bunları sıralı bir şekilde ekrana yazdırır. Sıraladıktan sonra ekrana basar ve eleman sayılarını ve ortalamalarını bulur. Kullanmak için ekrana çıkacak talimatlara uymanız yeterlidir.");
            Console.WriteLine("Lütfen Bir Cümle giriniz: ");
            string sentence = Console.ReadLine();
            int count = sentence.Length;
            char[] vowels = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            char[] sentenceArray = sentence.ToCharArray();
            ArrayList sentenceVowels = new ArrayList();
            for (int i = 0; i < count; i++)
            {
                for(int j = 0; j < vowels.Length; j++)
                {
                    if (sentenceArray[i] == vowels[j])
                    {
                        sentenceVowels.Add(vowels[j]);
                        break;
                    }
                }
            }
            Console.WriteLine("Sesli Harfler Sıralanıyor...");
            sentenceVowels.Sort();
            foreach(char c in sentenceVowels)
            {
                Console.WriteLine(c);
            }
        }
    }
}
