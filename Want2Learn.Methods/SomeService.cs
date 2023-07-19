using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.Methods
{
    class SomeService
    {
        public int GetSum(int numberFirst, int numberSecond)
        {
            int result = numberFirst + numberSecond;
            return result;
        }

        public int GetSum(string str1, string str2)
        {
            int result = str1.Length + str2.Length;
            return result;
        }

        public int GetSum(int numberFirst, int numberSecond, int numberThird)
        {
            int result = numberFirst + numberSecond + numberThird;
            return result;
        }

        public void PrintWord5times(string word)
        {
            Console.WriteLine(word);
            Console.WriteLine(word);
            Console.WriteLine(word);
            Console.WriteLine(word);
            Console.WriteLine(word);
        }

        public void AddOne(ref int number)
        {
            number += 1;
        }

        public void AddAge(Person person, int age)
        {
            person.age += age;
            
        }

        public Person AddAgeWithNewPerson(Person person, int age)
        {
            int newAge = person.age + age;
            Person newPerson = new Person(person.name, newAge);
            return newPerson;
        }
        public void Print(Person person)
        {
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
        }

        public Person AddAgeWithNewPersonWithCheck(Person person, int age)
        {
            if (person == null)
            {
                return null;
            }
            int newAge = person.age + age;
            Person newPerson = new Person(person.name, newAge);
            return newPerson;
        }

        public static void PrintWord4times(string word)
        {
            Console.WriteLine(word);
            Console.WriteLine(word);
            Console.WriteLine(word);
            Console.WriteLine(word);
        }
    }
}
