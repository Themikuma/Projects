using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    public class NestedIfs
    {
        static void Main()
        {
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //if (a % 3 == 0)
            //{
            //    Console.WriteLine("3");
            //}
            //else if (a % 5 == 0)
            //{
            //    Console.WriteLine("5");
            //}
            //else if (a % 7 == 0)
            //{
            //    Console.WriteLine("7");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            //int a;
            //bool input = int.TryParse(Console.ReadLine(), out a);
            //if (!input)
            //{
            //    Console.WriteLine("That's not an integer");
            //    return;
            //}
            //int c = a % 10;
            //switch (c)
            //{
            //    case 1: Console.WriteLine("One"); break;
            //    case 2: Console.WriteLine("Two"); break;
            //    case 3: Console.WriteLine("Three"); break;
            //    case 4: Console.WriteLine("Four"); break;
            //    case 5: Console.WriteLine("Five"); break;
            //    case 6: Console.WriteLine("Six"); break;
            //    case 7: Console.WriteLine("Seven"); break;
            //    case 8: Console.WriteLine("Eight"); break;
            //    case 9: Console.WriteLine("Nine"); break;
            //    default: Console.WriteLine("Zero"); break;
            //}
            //int dayOfTheWeek = int.Parse(Console.ReadLine());
            //if (dayOfTheWeek > 7)
            //{
            //    Console.WriteLine("Error!");
            //    return;
            //}
            //DateTime date = new DateTime(2015, 11, dayOfTheWeek + 1);
            //Console.WriteLine(date.DayOfWeek.ToString());
            int a = int.Parse(Console.ReadLine());
            switch (a % 7)
            {
                case 0:
                case 5: 
                    Console.WriteLine("Izrud"); break;

                default:break;
            }
            //if (a % 7 == 0 || a.ToString().Contains('7'))
            //{
            //    Console.WriteLine("izrud");
            //}
        }
    }
}
