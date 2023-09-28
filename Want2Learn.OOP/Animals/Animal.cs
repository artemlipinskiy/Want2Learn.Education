using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.OOP
{
    class Animal
    {
        public string Name { get; set; }

        public virtual string MakeSound()
        {
            return $"My name is {Name}";
        }

        public string Eat()
        {
            return "I am eating";
        }

        public override string ToString()
        {
            return $"{Name}" + MakeSound();
        }
    }
}
