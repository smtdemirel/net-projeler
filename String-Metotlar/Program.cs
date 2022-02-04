using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp, Hoşgeldiniz!";
            string degisken2 = "Dersimiz Csharp";

            //Lenght
            Console.WriteLine(degisken.Length);

            //ToLower ToUpper
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken2.ToLower());

            //Concat
            Console.WriteLine(string.Concat(degisken,"Merhaba"));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken,degisken2,false));
            Console.WriteLine(string.Compare(degisken,degisken2,true));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith(degisken2));
            Console.WriteLine(degisken.StartsWith(degisken2));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("Cs"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Selam "));

            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadRight(30));

            //Remove
            Console.WriteLine(degisken.Remove(0,5));

            //Replace
            Console.WriteLine(degisken.Replace('a','b'));
            Console.WriteLine(degisken.Replace("Csharp",".Net"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);





        }

    }
}
