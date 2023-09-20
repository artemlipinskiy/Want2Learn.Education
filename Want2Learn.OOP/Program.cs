using System;
using System.Collections.Generic;

namespace Want2Learn.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Person person1 = new Person("", "" , 15);

            //Console.WriteLine(person1.GetAge());
            //person1.SetAge(21);
            //person1.SetFirstName("sadas");
            //person1.SetLastName("qwerty");
            //Console.WriteLine(person1.GetFullName());

            //PersonWithProp personWithProp = new PersonWithProp();

            //personWithProp.FirstName = "asdasd";
            //Console.WriteLine(personWithProp.FirstName);

            //PersonAutoProp personAutoProp = new PersonAutoProp();
            //personAutoProp.FirstName = "awaw";
            //personAutoProp.Age = 12;

            //Console.WriteLine(personAutoProp.FirstName);

            //// List<ТИП ДАННЫХ>
            //List<int> intList = new List<int>();

            //intList.Add(4);
            //intList.Add(5);
            //intList.Add(12);
            //intList.Add(13);

            //for (int i = 0; i < intList.Count; i++)
            //{
            //    Console.Write($"{intList[i]} ");
            //}
            //Console.WriteLine();

            //intList.RemoveAt(2);

            //for (int i = 0; i < intList.Count; i++)
            //{
            //    Console.Write($"{intList[i]} ");
            //}


            //foreach (int intItem in intList)
            //{
            //    Console.Write($"{intItem} ");
            //}

            Animal animal = new Animal();
            animal.Name = "Some Name";
            Console.WriteLine(animal.MakeSound());
            Console.WriteLine(animal.Eat());

            Cat cat = new Cat();
            cat.Name = "Noxy";
            Console.WriteLine(cat.MakeSound());
            Console.WriteLine(cat.Eat());

            Dog dog = new Dog();
            dog.Name = "ABC";
            Console.WriteLine(dog.MakeSound());
            Console.WriteLine(dog.Eat());

            Quadrate quadrate = new Quadrate();
            quadrate.SideLength = 5;
            Console.WriteLine(quadrate.GetSquare());

            //Так нельзя
            //Shape shape = new Shape();

            Shape shape = new Quadrate();
            Console.WriteLine(shape.GetSquare());

            Animal animal1 = new Dog();
            animal.Name = "qwe";
            Animal animal2 = new Cat();
            animal2.Name = "asd";
            List<Animal> animals = new List<Animal>();
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(cat);
            animals.Add(dog);

            foreach (var animalItem in animals)
            {
                Console.WriteLine(animalItem.MakeSound());
                Console.WriteLine(animalItem.Eat());
            }
            string sas = "sas";
           
            Console.WriteLine(animals);
            Console.WriteLine(animal);

            Nullable<int> age = null;
            Console.WriteLine(age.HasValue);
            
            //age = age.Value + 5;
            //Console.WriteLine(age);

            int? age2 = null;
            DateTime? dateTime = null;

            Console.WriteLine(cat.Sleep());
            Console.WriteLine(dog.Sleep());
            List<ISleepable> sleepables = new List<ISleepable>();
            sleepables.Add(dog);
            sleepables.Add(cat);
            foreach (var sleepable in sleepables)
            {
                Console.WriteLine(sleepable.Sleep());
            }

            Dictionary<string, string> defentionsDictionary = new Dictionary<string, string>();
            defentionsDictionary.Add("Word", "Это набор символов");
            defentionsDictionary.Add("Отрицательное число", "Это число со знаком минус (0)");
            bool hasKeyword = defentionsDictionary.ContainsKey("word");
            Console.WriteLine(hasKeyword);
            hasKeyword = defentionsDictionary.ContainsKey("Word");
            Console.WriteLine(hasKeyword);
            foreach (KeyValuePair<string, string> dictionaryItem in defentionsDictionary)
            {
                Console.WriteLine(dictionaryItem.Key);
                Console.WriteLine(dictionaryItem.Value);
            }
            Console.WriteLine(defentionsDictionary["Word"]);


        }
    }
}
