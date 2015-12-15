using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class Lists
    {
        public static void Main()
        {
            //List<int> pesho = new List<int>();
            //pesho.Add(5);
            //pesho.Add(0);
            //pesho.Add(6);
            //pesho.Add(2);
            //pesho.Add(8);
            //pesho.Add(16);
            //pesho.Remove(6);
            //var kolio = pesho.FindAll(t => t % 4 == 0);
            //foreach (var item in kolio)
            //{
            //    Console.WriteLine(item);
            //}
            List<string> names = new List<string>();
            names.Add("gosho");
            names.Add("Tosho");
            names.Add("Pesho");
            names.Add("Nikolai");
            names.Add("Pesho");
            Console.WriteLine(names.LastIndexOf("Pesho"));
        }
    }
}
