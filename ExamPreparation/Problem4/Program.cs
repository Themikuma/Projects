using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] coords = line.Split(' ');
            double aX = double.Parse(coords[0]);
            double aY = double.Parse(coords[1]);
            line = Console.ReadLine();
            coords = line.Split(' ');
            double bX = double.Parse(coords[0]);
            double bY = double.Parse(coords[1]);
            line = Console.ReadLine();
            coords = line.Split(' ');
            double cX = double.Parse(coords[0]);
            double cY = double.Parse(coords[1]);
            line = Console.ReadLine();
            coords = line.Split(' ');
            double dX = double.Parse(coords[0]);
            double dY = double.Parse(coords[1]);
            double r = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            if (aX * cX >= 0 || aY * cY >= 0)
            {
                Console.WriteLine(0);
                return;
            }
            int pointsCount = 1;
            double r2 = r * r;
            for (double x = h; x < cX && x <= r; x += h)
            {
                for (double y = 0; y < cY && x * x + y * y <= r2; y += h)
                {
                    pointsCount++;
                }
            }

            for (double x = 0; x > dX && x >= -r; x -= h)
            {
                for (double y = h; y < dY && x * x + y * y <= r2; y += h)
                {
                    pointsCount++;
                }
            }
            for (double x = -h; x > aX && x >= -r; x -= h)
            {
                for (double y = 0; y > aY && x * x + y * y <= r2; y -= h)
                {
                    pointsCount++;
                }
            }

            for (double x = 0; x < bX && x <= r; x += h)
            {
                for (double y = -h; y > bY && x * x + y * y <= r2; y -= h)
                {
                    pointsCount++;
                }
            }
            Console.WriteLine(pointsCount);
        }
    }
}
