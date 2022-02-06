using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Samet","Demirel",546,"Yazılım");
            calisan1.CalisanYazdir();
            Console.WriteLine("****************");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Hikmet";
            calisan2.Soyad = "Demirel";
            calisan2.No = 747;
            calisan2.Departman = "Mühendislik";
            calisan2.CalisanYazdir();
            Console.WriteLine("****************");
            Calisan calisan3 = new Calisan("Ahmet","Özer");
            calisan3.CalisanYazdir();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan() { }
        public Calisan(string ad,string soyad)
        {
            this.Ad=ad;
            this.Soyad=soyad;
        }
        public void CalisanYazdir()
        {
            Console.WriteLine("Çalışan Adı: {0}",Ad);
            Console.WriteLine("Çalışan Soyadıdı: {0}",Soyad);
            Console.WriteLine("Çalışan Numarası: {0}",No);
            Console.WriteLine("Çalışan Departmanı: {0}",Departman);
        }
    }
}
