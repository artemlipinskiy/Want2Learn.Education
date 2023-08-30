using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.OOP
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person()
        {

        }
        public Person(string firstName, string lastName, int age)
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

        //Методы Get
        public string GetFullName()
        {
            return $"{lastName} {firstName}";
        }
        public int GetAge()
        {
            return age;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        //Методы Set
        public void SetAge(int age)
        {
            if (age < 0)
            {
                return;
            }
            this.age = age;
        }

        public void SetFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                return;
            }
            this.firstName = firstName;
        }
        public void SetLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                return;
            }
            this.lastName = lastName;
        }
    }
}
