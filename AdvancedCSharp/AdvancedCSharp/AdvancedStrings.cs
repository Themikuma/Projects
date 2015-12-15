using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class AdvancedStrings
    {
        public static void Main()
        {
            string firstName = "Steve";
            string lastName = "Jobs";
            int age = 56;
            Console.WriteLine(firstName + " " + lastName +
              " (age: " + age + ")"); // Steve Jobs (age: 56)
            string allLangs = "C#, Java; HTML, CSS; PHP, SQL";
            string[] langs = allLangs.Split(new char[] { ',', ';', ' ' },
              StringSplitOptions.RemoveEmptyEntries);
            foreach (var lang in langs)
                Console.WriteLine(lang);
            Console.WriteLine("Langs = " + string.Join(", ", langs));
            Console.WriteLine("  \n\n Software  University  ".Trim());
        }
    }
}
