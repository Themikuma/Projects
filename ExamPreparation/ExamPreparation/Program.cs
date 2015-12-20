using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //100 rub=3.5lv
            //1usd=1.5lv
            //1eur=1.95lv
            //option4=option4*0.5

            double r = double.Parse(Console.ReadLine()) * (3.5 / 100);
            double d = double.Parse(Console.ReadLine()) * 1.5;
            double e = double.Parse(Console.ReadLine()) * 1.95;
            double b = double.Parse(Console.ReadLine()) * 0.5;
            double m = double.Parse(Console.ReadLine());
            List<double> prices = new List<double>();
            prices.Add(r);
            prices.Add(d);
            prices.Add(e);
            prices.Add(b);
            prices.Add(m);
            Console.WriteLine(Math.Ceiling(prices.Max()).ToString("0.00"));

        }
    }
}
