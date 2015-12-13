using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Even");
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Odd");
            }
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //if (a >= b)
            //{
            //    Console.WriteLine(a - b);
            //}
            //else
            //{
            //    Console.WriteLine(b - a);
            //}
            string pesho = Console.ReadLine();
            string gosho = Console.ReadLine();
            if (pesho.Length > gosho.Length)
            {
                Console.WriteLine(pesho);
            }
            else
            {
                Console.WriteLine(gosho);
            }
        }
    }
}
