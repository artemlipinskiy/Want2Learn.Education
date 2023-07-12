using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.Methods
{
    class Person
    {
        public string name;
        public int age;

        public Person()
        {
            this.name = "Default";
            this.age = 1;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
