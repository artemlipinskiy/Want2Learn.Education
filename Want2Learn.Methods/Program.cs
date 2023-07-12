using System;

namespace Want2Learn.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeService service = new SomeService();
            //Вызов метода с возвращаемым значением
            int resultFromGetSum = service.GetSum(5, 4);
            Console.WriteLine(resultFromGetSum);
            Console.WriteLine(service.GetSum(5, 4));

            int n1 = 5;
            int n2 = 9;
            resultFromGetSum = service.GetSum(n1, n2);
            Console.WriteLine(resultFromGetSum);
            string hello = "Hello";

            //Вызов метода без возвращаемого значением
            service.PrintWord5times(hello);

            //ref параметры
            service.AddOne(ref n2);
            Console.WriteLine(n2);

            //Пример использования out
            int someNumber;
            bool isCorrect = int.TryParse(Console.ReadLine(), out someNumber);
            Console.WriteLine(isCorrect);
            Console.WriteLine(someNumber);

            Person person1 = new Person("Artem", 26);
            service.Print(person1);
            service.AddAge(person1, 2); 
            service.Print(person1);

            Person person2 = service.AddAgeWithNewPerson(person1, 2);
            
            service.Print(person1);

            service.Print(person2);

            Person person3 = service.AddAgeWithNewPerson(null, 2);

            service.Print(person3);
        }
    }
}
