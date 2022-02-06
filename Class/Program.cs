using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Samet";
            calisan1.Soyad = "Demirel";
            calisan1.No = 546;
            calisan1.Departman = "Yazılım";
            calisan1.CalisanBilgileri();

            Console.WriteLine("*********");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Hikmet";
            calisan2.Soyad = "Demirel";
            calisan2.No = 547;
            calisan2.Departman = "Mühendislik";
            calisan2.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0},",Ad);
            Console.WriteLine("Çalışan Soyadı: {0},",Soyad);
            Console.WriteLine("Çalışan Numarası: {0},",No);
            Console.WriteLine("Çalışan Departmanı: {0},",Departman);
        }
    }
}
