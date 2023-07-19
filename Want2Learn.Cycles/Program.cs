using System;

namespace Want2Learn.Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            //for/ while/ do while/ foreach
            int number = 5;
            number = number + 1;
            number += 1;
            number++;
            number--;

            SomeService service = new SomeService();
            service.PrintWord("test", 7);
            service.PrintWordWhile("test", 7);
            service.DoSomething();

            //int sum = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    sum += int.Parse(Console.ReadLine());
            //}

            Random random = new Random();
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                int currentNumber = random.Next(5, 50);
                Console.WriteLine(currentNumber);
                sum += currentNumber;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
