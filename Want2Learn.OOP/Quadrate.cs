using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.OOP
{
    class Quadrate : Shape
    {
        public int SideLength { get; set; }

        public override int GetSquare()
        {
            return SideLength * SideLength;
        }
    }
}
