using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LotteryApplication
{
    class FileHandler
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Person person;
            using (StreamReader sr = new StreamReader(@"C:\Users\ruuser\Desktop\Lottery.csv"))
            {
                while (!sr.EndOfStream)
                {
                    person = CreatePerson(sr.ReadLine());
                    people.Add(person);
                }
            }
            Random randomizer = new Random();
            int a;
            List<int> used = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                a = randomizer.Next(27);
                if (!used.Contains(a))
                {
                    Console.WriteLine(people[a]);
                    used.Add(a);
                }
            }
        }

        private static Person CreatePerson(string line)
        {
            string[] splitLine = line.Split(';');
            int id = int.Parse(splitLine[0]);
            Person newPerson = new Person(id, splitLine[1], splitLine[2], splitLine[3]);
            return newPerson;
        }
    }
}
