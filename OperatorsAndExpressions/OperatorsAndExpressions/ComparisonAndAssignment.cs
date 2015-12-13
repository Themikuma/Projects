using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAndExpressions
{
    class ComparisonAndAssignment
    {
        static void Main()
        {
            //Console.WriteLine(5>6);
            //Console.WriteLine(5!=5);
            //Console.WriteLine(5==5);
            //Console.WriteLine(5<=6);

            //int a = (int) 6.21;
            //int b = 7;
            //a /= b;
            //Console.WriteLine(a);
            //Console.WriteLine(typeof(Int64));

            //double a = 3.0;
            //Console.WriteLine(a is int);

            //string alabal = "aalalallalal";
            //int pet = 5;
            //Console.WriteLine(alabal + pet);
            //long osem = pet;
            //pet = (int)osem;

            //bool a = true;
            //bool b = true;
            //Console.WriteLine((!(a && b)) == (!a || !b));
            //Console.WriteLine((!(a && b)));
            //int a = 3;
            //int b = 4;
            //int c = 5;
            //Console.WriteLine((a * a + b * b) == c * c);
            int a = 5;
            int b = 8;
            int max = a - ((a - b) & ((a - b) >> 31));
            Console.WriteLine(max);

        }
    }
}
