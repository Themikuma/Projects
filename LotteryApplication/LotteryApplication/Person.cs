using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryApplication
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PersonalNo { get; set; }

        public Person(int id, string name, string lastName, string personalNo)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.PersonalNo = personalNo;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Id, Name, LastName,PersonalNo);
        }
    }
}
