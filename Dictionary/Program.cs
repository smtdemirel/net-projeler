using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Samet");
            dic.Add(2, "Hikmet");

            //Elemanlara Erişim
            foreach (int key in dic.Keys)
            {
                Console.WriteLine(key);
            }

            //Count
            Console.WriteLine(dic.Count);

            //Contains
            Console.WriteLine(dic.ContainsValue("Samet"));
            Console.WriteLine(dic.ContainsKey(2));

            //Remove
            dic.Remove(2);
        }
    }
}
