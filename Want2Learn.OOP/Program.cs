using System;
using System.Collections.Generic;

namespace Want2Learn.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person1 = new Person("", "" , 15);

            Console.WriteLine(person1.GetAge());
            person1.SetAge(21);
            person1.SetFirstName("sadas");
            person1.SetLastName("qwerty");
            Console.WriteLine(person1.GetFullName());

            PersonWithProp personWithProp = new PersonWithProp();

            personWithProp.FirstName = "asdasd";
            Console.WriteLine(personWithProp.FirstName);

            PersonAutoProp personAutoProp = new PersonAutoProp();
            personAutoProp.FirstName = "awaw";
            personAutoProp.Age = 12;

            Console.WriteLine(personAutoProp.FirstName);

            // List<ТИП ДАННЫХ>
            List<int> intList = new List<int>();

            intList.Add(4);
            intList.Add(5);
            intList.Add(12);
            intList.Add(13);

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]} ");
            }
            Console.WriteLine();

            intList.RemoveAt(2);

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]} ");
            }


            foreach (int intItem in intList)
            {
                Console.Write($"{intItem} ");
            }
        }
    }
}
