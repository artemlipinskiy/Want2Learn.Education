using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Want2Learn.OOP.Animals;
using Want2Learn.OOP.LINQ_Datas;

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

            var dogVar = new Dog();
            var abc = dogVar.MakeSound();

            //var newPerson = new PersonAutoProp();
            //newPerson.Age = 15;
            //newPerson.FirstName = "AA";
            //newPerson.LastName = "qw";
            var newPerson = new PersonAutoProp
            {
                LastName = "qw",
                Age = 15,
                FirstName = "AA"
            };

            newPerson = null;
            var array = new int[0];
            try
            {
                Console.WriteLine(array[0]);
                
                Console.WriteLine(newPerson.FirstName);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Выход за границы массива");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
            var someText = "bla-bla-bla";
            var path = "bla.txt";
            using(StreamWriter file = File.CreateText(path))
            {
                file.Write(someText);
            }

            StreamWriter file2 = File.CreateText(path);
            try
            {
                file2.Write(someText);
            }
            finally
            {
                if (file2 != null)
                {
                    file2.Dispose();
                }
            }
            var text = string.Empty;
            using(StreamReader sr = File.OpenText(path))
            {
                 text = sr.ReadToEnd();
            }
            Console.WriteLine(text);
            newPerson = new PersonAutoProp
            {
                LastName = "qw",
                Age = 15,
                FirstName = "AA"
            };
            var newPerson2 = new PersonAutoProp
            {
                LastName = "ewew",
                Age = 155,
                FirstName = "asas"
            };
            var persons = new List<PersonAutoProp>();
            persons.Add(newPerson);
            persons.Add(newPerson2);
            string json = JsonConvert.SerializeObject(persons, Formatting.Indented);
            Console.WriteLine(json);
            path = "persons.json";
            using (StreamWriter file = File.CreateText(path))
            {
                file.Write(json);
            }
            //var type = typeof(List<PersonAutoProp>);
            XmlSerializer formatter = new XmlSerializer(typeof(List<PersonAutoProp>));
            using (FileStream fs = new FileStream("persons.xml",FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, persons);
            }

            Fish fish = new Fish();

            var symptom1 = new Symptom
            {
                Id = 1,
                Name = "Symptom 1",
                Description = "Some description",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
            };
            var symptom2 = new Symptom
            {
                Id = 2,
                Name = "Symptom 2",
                Description = "Some description",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
            };
            var symptom3 = new Symptom
            {
                Id = 3,
                Name = "Symptom 3",
                Description = "Some description",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
            };
            var symptom4 = new Symptom
            {
                Id = 4,
                Name = "Symptom 4",
                Description = "Some description",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
            };
            var symptomsSet1 = new List<Symptom> { symptom1, symptom2 };
            var symptomsSet2 = new List<Symptom> { symptom1, symptom3 };
            var symptomsSet3 = new List<Symptom> { symptom3, symptom4 };
            var disease = new Disease
            {
                Id = 1,
                Name = "Disease 1",
                Description = "Some disease description",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                Symptoms = symptomsSet1
            }; 
            var disease2 = new Disease
            {
                Id = 2,
                Name = "Disease 2",
                Description = "Some disease description",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                Symptoms = symptomsSet2
            };
            var disease3 = new Disease
            {
                Id = 3,
                Name = "Disease 3",
                Description = "Some disease description",
                CreatedOn = DateTime.Now.AddDays(1),
                ModifiedOn = DateTime.Now,
                Symptoms = symptomsSet3
            };

            var diseases = new List<Disease> { disease, disease2, disease3 };
            var diseaseName = "Disease 2";
            var resultDisease = new Disease();
            foreach (var diseaseItem in diseases)
            {
                if (diseaseItem.Name == diseaseName)
                {
                    resultDisease = diseaseItem;
                    break;
                }
            }

            var first = diseases.FirstOrDefault(x => x.Name == diseaseName);
            first = diseases.FirstOrDefault(x => x.Name == "Disease 23");
            first = diseases.FirstOrDefault(x => x.Id == 2);
            var intList = new List<int> { 1, 2, 34, 5 };
            var one = intList.FirstOrDefault(x => x == 2);

            var filtred = diseases.Where(x => x.CreatedOn.Date == DateTime.Now.Date).Where(x => x.Description != null).ToList();

            var names = diseases.Select(x => x.Name).ToList();
            var nameDescription = diseases.Select(x => new NameDescriptionsItem 
            { 
                Name = x.Name,
                Description = x.Description
            }).ToList();
            //var test = diseases.Select(x => x.Symptoms).ToList();
            var manys = diseases.SelectMany(x => x.Symptoms).ToList();
            var maxAge = persons.Max(x => x.Age);

            persons = persons.OrderBy(x => x.Age).ToList();
            persons = persons.OrderByDescending(x => x.Age).ToList();

            var symptomIds = manys.Select(x => x.Id).Distinct().ToList();
            var anyResult = diseases.Any(x => x.Symptoms != null && x.Symptoms.Count > 3);
            var allResult = diseases.All(x => x.Symptoms != null && x.Symptoms.Count > 3);
            var manysSkip = manys.Skip(2).Take(3).ToList();

            //Generic

            var user1 = new User<int>();
            var user2 = new User<double>();

            var someCondition1 = true;

            //if (someCondition1)
            //{
            //    throw new Exception();
            //}
            //if (someCondition1)
            //{
            //    throw new Exception("Some Message");
            //}
            //if (someCondition1)
            //{
            //    throw new CustomException("Some new prop");
            //}
            if (someCondition1)
            {
                throw new CustomException("Some new prop", "NEW EXCEPTION MESSAGE");
            }
        }
    }
}
