using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.OOP
{
    abstract class Shape
    {
        public int CountAngles { get; set; }

        public abstract int GetSquare();
    }
}
