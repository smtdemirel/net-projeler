using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);


            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);


            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());


            Console.WriteLine(DateTime.Now.AddDays(1));
            Console.WriteLine(DateTime.Now.AddMonths(3));
            Console.WriteLine(DateTime.Now.AddYears(3));

            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-12));
            Console.WriteLine(Math.Sin(60));
            Console.WriteLine(Math.Cos(60));
            Console.WriteLine(Math.Tan(90));

            Console.WriteLine(Math.Ceiling(22.4));
            Console.WriteLine(Math.Round(22.4));
            Console.WriteLine(Math.Round(22.6));
            Console.WriteLine(Math.Floor(22.6));

            Console.WriteLine(Math.Max(7,4));
            Console.WriteLine(Math.Min(7,4));

            Console.WriteLine(Math.Pow(2,3));//Üs alır
            Console.WriteLine(Math.Sqrt(8));//Karekök alır
            Console.WriteLine(Math.Log(8));//verilen sayının logaritma e tabanındaki logaritmik karşılığını verir
            Console.WriteLine(Math.Log10(8));//10 tabanında logaritmik karşılığını verir
            Console.WriteLine(Math.Exp(3));//e'üzeri verilen sayınınökarşılığını verir


        }
    }
}
