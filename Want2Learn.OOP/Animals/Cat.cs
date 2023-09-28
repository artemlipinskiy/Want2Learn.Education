using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.OOP.Animals
{
    sealed class Cat : Animal, ISleepable
    {
        public override string MakeSound()
        {
            return "Meow";
        }

        public string Sleep()
        {
            return $"I am {Name} and i am sleeping";
        }
    }
}
