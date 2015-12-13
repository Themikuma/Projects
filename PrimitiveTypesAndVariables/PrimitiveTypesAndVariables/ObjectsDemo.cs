using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypesAndVariables
{
    class ObjectsDemo
    {
        static void Main(string[] args)
        {
            object pesho = "Az se kazvam Nikolaaai";
            object age = 24;
            string ivan = "Ivaaaan";
            pesho = ivan.Replace("aaa", "a");
            Console.WriteLine(ivan);
            object date = DateTime.Now;
            object cofirm = true;
            object golden = 1.618;
            Console.WriteLine(@"Pesho's real name is {0}, 
                he is {1} old today is {2} this is {3}
                and here is a real number {4}", pesho, age, date, cofirm, golden);
        }
    }
}
