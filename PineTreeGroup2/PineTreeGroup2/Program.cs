using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineTreeGroup2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            string pesho = "gosho";
            for (int i = 0; i < n+1 ; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n - j; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i <= j; i++)
                {
                    Console.Write("*");
                }
                Console.Write("|");
                for (int i = 0; i <= j; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
