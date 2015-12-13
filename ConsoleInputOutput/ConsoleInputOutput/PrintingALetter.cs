using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    class PrintingALetter
    {
        static void Main()
        {
            Console.Write("Enter person name: ");
            string person = Console.ReadLine();

            Console.Write("Enter company name: ");
            string company = Console.ReadLine();

            Console.WriteLine("  Dear {0} \nWe are pleased to tell you that " +
              "{1} has accepted you to take part in the \"Programming Basics\"" +
              " course. {1} wishes you a good luck!\n   Yours,\n {1} ", person, company);
            
        }

    }
}
