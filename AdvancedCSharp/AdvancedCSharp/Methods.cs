using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class Methods
    {
        static void Main(string[] args)
        {
            //SayHello("Gosho");
            //SayHello("Pesho");
            //SayHello("Sybo");
            //Console.WriteLine(Divide(5, 0));
            PrintMatrix(5);
        }
        static void SayHello(string name)
        {
            Console.WriteLine(string.Format("Hello, {0}", name));
        }
        static double Divide(int a, int b)
        {
            double result = 0;
            if (b != 0)
            {
                result = (double)a / b;
            }
            return result;
        }

        static void PrintMatrix(int n)
        {
            PrintMatrix(n, n);
        }
        static void PrintMatrix(int n, int m)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", j + i);
                }
                Console.WriteLine();
            }
        }

    }
}
