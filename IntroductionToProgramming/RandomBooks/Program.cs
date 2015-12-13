using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            List<int> people = new List<int>();
            for (int i = 0; i < 14; i++)
            {
                people.Add(i);
            }
            int nextNumber;
            while (people.Count > 4)
            {
                nextNumber = randomizer.Next(14);
                if (people.Contains(nextNumber))
                {
                    people.Remove(nextNumber);
                    Console.WriteLine(nextNumber);
                }
            }
        }
    }
}
