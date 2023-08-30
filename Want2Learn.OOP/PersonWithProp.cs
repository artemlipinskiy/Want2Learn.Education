using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.OOP
{
    class PersonWithProp
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    return;
                }
                firstName = value;
            }
        }

        public PersonWithProp()
        {

        }
        public PersonWithProp(string firstName, string lastName, int age)
        {
            //Логика валидации
            this.firstName = firstName;
            this.lastName = lastName;
            if (age < 0)
            {
                return;
            }
            this.age = age;
        }

    }
}
