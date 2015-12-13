using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class GiveBooks
    {
        static void Main(string[] args)
        {
            List<int> people = new List<int>();
            for (int i = 1; i <= 17; i++)
            {
                people.Add(i);
            }
            Random rng = new Random();
            int randomNumber;
            while (people.Count > 7)
            {
                randomNumber = rng.Next(1,17);
                if (people.Contains(randomNumber))
                {
                    Console.WriteLine(randomNumber);
                    people.Remove(randomNumber);
                }
            }
        }
    }
}
