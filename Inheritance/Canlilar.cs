﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlilar Beslenir.");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlilar Solunum Yapar.");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canlilar boşaltım Yapar.");
        }
    }
}
