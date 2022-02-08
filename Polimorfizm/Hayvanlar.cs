using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    public class Hayvanlar:Canlilar
    {
        public override void UyaranlaraTepkiVerir()
        {
            base.UyaranlaraTepkiVerir();
            Console.WriteLine("Hayvanlar Temasa Tepki Verir.");
        }
    }
}
