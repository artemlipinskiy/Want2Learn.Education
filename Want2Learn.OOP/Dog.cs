using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.OOP
{
    class Dog : Animal, ISleepable
    {
        public override string MakeSound()
        {
            return "Gaf";
        }

        public string Sleep()
        {
            return "Gaf gaf. I am sleeping";
        }
    }
}
