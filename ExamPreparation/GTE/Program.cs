using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTE
{
    class Program
    {
        static void Main(string[] args)
        {
            long escapes = long.Parse(Console.ReadLine());
            long slappedThieves = 0;
            long escapedThieves = 0;
            long beerDrunk = 0;
            for (long i = 0; i < escapes; i++)
            {
                long thieves = long.Parse(Console.ReadLine());
                long beers = long.Parse(Console.ReadLine());
                beerDrunk += beers;
                if (thieves > 5)
                {
                    escapedThieves += thieves - 5;
                    slappedThieves += 5;
                }
                else
                {
                    slappedThieves += thieves;
                }
            }
            Console.WriteLine("{0} thieves slapped.", slappedThieves);
            Console.WriteLine("{0} thieves escaped.", escapedThieves);
            Console.WriteLine("{0} packs, {1} bottles.", beerDrunk / 6, beerDrunk % 6);
        }
    }
}
