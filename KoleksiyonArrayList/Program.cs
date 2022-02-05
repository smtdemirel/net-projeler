using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoleksiyonArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Samet");
            liste.Add(26);

            //Liste içerisindeki elemanlara erişim
            Console.WriteLine(liste[1]);

            foreach (var i in liste)
            {
                Console.WriteLine(i);
            }

            //AddRange
            string[] renkler = { "kırmızı", "sarı", "yeşil" };
            List<int> sayilar = new List<int> { 3,45,23,132,534};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach(var i in liste)
            {
                Console.WriteLine(i);
            }
            liste.Clear();
            liste.AddRange(sayilar);
            //Sort
            liste.Sort();

            foreach(var i in liste)
            {
                Console.WriteLine(i);
            }

            //Binary Search
            Console.WriteLine(liste.BinarySearch(14));
            
            //Reverse
            liste.Reverse();
            foreach(var i in liste)
            {
                Console.WriteLine(i);
            }

            //Clear
            liste.Clear();
        }
    }
}
