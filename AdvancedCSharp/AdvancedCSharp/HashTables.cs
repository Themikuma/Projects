using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class HashTables
    {
        public static void Main()
        {
            Dictionary<string, string> phonebook =    new Dictionary<string, string>();
            //phonebook["John Smith"] = "+1-555-8976";
            //phonebook["Lisa Smith"] = "+1-555-1234";
            //phonebook["Sam Doe"] = "+1-555-5030";
            //phonebook["Nakov"] = "+359-899-555-592";
            //phonebook["Nakov"] = "+359-2-981-9819";
            //phonebook.Remove("John Smith");
            //foreach (var pair in phonebook)
            //{
            //    Console.WriteLine("{0} --> {1}", pair.Key, pair.Value);
            //}
            phonebook.Add("Nakov", "+359-899-555-592");
            phonebook.Add("Nakov2", "+359-2-981-9819");
            phonebook.Add("Pesho", "wowlo");
            phonebook.Add("Jorko", "+88888888");
            foreach (var item in phonebook.Keys)
            {
                Console.WriteLine(item);
            }  
        }
    }
}
