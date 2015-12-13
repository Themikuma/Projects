using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class OptimizedPrimes
    {
        static void Main()
        {
            int count = 2;
            int position = int.Parse(Console.ReadLine());
            int[] primes = new int[position];
            primes[0] = 2;
            primes[1] = 3;
            int current = 5;
            bool isPrime = true;
            while (count < position)
            {
                int border = (int)Math.Sqrt(current);
                for (int i = 0; primes[i] <= border; i++)
                {
                    if (current % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes[count] = current;
                    count++;
                }
                isPrime = true;
                current += 2;
            }
            Console.WriteLine(primes[position - 1]);
        }
    }
}


























