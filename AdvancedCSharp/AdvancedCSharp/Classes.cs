using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class Classes
    {
        public static void Main()
        {
            Point a = new Point();
            a.X = 5;
            a.Y = 3;
            Point b = new Point() { X = 4, Y = 3 };
            Point c = new Point() { X = 1, Y = 5 };
            Point d= new Point() { X = 2, Y = 3 };
            Point f = new Point() { X = 4, Y = 2 };
            Point[] line = { a, b, c, d, f };
        }
    }    
}
