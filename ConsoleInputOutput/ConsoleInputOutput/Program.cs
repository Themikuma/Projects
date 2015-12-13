using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a = 15.5;
            //int b = 14;
            //Console.Write(a);
            //Console.Write(" + ");
            //Console.Write(b);
            //Console.Write(" = ");
            //Console.Write(a + b);
            //Console.Write("\n");
            //int age = 24;
            //string name = "Pesho";
            //Console.WriteLine("Hello my name is {0} and I'm {1} years old",name,age);
            //Console.Write("Something something dark side");
            double beer = 1.80;
            double valueAddedTax = 23;
            Console.WriteLine(@"A price of a beer with {0} VAT added is {1},
without it's {2:F10}", valueAddedTax, beer, beer - beer * (valueAddedTax/100));
        }
    }
}
