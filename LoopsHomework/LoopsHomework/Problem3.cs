using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsHomework
{
    class Problem3
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a < min)
                {
                    min = a;
                }
            }
            Console.WriteLine(min);
        }
    }
}
