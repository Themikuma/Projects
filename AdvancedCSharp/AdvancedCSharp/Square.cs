using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    public class Square
    {
        public Point UpperLeftVertex { get; }
        public int Side { get; }
        public Square(Point upperLeftVertex,int side)
        {
            this.UpperLeftVertex = upperLeftVertex;
            this.Side = side;
        }

    }
}
