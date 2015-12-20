using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder closingLine = new StringBuilder();
            closingLine.Append('*', n);
            Console.WriteLine(closingLine);
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < n / 2 - i; j++)
                {
                    Console.Write("-");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("@");
                }
                for (int j = 0; j < n / 2 - i; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("*");
            }

            for (int i = n / 2 - 1; i > 0; i--)
            {
                Console.Write("*");
                for (int j = 0; j < n / 2 - i; j++)
                {
                    Console.Write("-");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("@");
                }
                for (int j = 0; j < n / 2 - i; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("*");
            }
            Console.WriteLine(closingLine);
        }
    }
}
