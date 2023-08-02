using System;

namespace Want2Learn.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 5;
            int[] arrayInt = new int[size];
            arrayInt[0] = rnd.Next(0, 10);
            arrayInt[1] = rnd.Next(0, 10);
            arrayInt[2] = rnd.Next(0, 10);
            arrayInt[3] = rnd.Next(0, 10);
            arrayInt[4] = rnd.Next(0, 10);

            //for (int i = 0; i < arrayInt.Length; i++)
            //{
            //    arrayInt[i] = rnd.Next(0, 10);
            //}

            //Console.WriteLine(arrayInt[0]);
            //Console.WriteLine(arrayInt[1]);
            //Console.WriteLine(arrayInt[2]);
            //Console.WriteLine(arrayInt[3]);
            //Console.WriteLine(arrayInt[4]);

            //Так выводить нельзя
            Console.WriteLine(arrayInt);

            //Такого индекса нет
            //Console.WriteLine(arrayInt[5]);
            Console.WriteLine("Hello World!");
            ArrayService arrayService = new ArrayService();
            arrayService.Print(arrayInt, 5);
            Console.WriteLine("======");
            arrayService.Print(arrayInt);

            arrayService.AddOne(arrayInt);
            Console.WriteLine("======");
            arrayService.Print(arrayInt);

            string[] arrayStr = new string[2];
            Person[] people = new Person[3];

            arrayStr = null;

            int[,] matrixInt = new int[2, 3];
            matrixInt[0, 0] = 2;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrixInt[i, j]} ");
                }
                Console.WriteLine();
            }

            //string[][] arrayArrayStr = new string[2][];
            //arrayArrayStr = new string[2][3];

            foreach (int someNumber in arrayInt)
            {
                Console.WriteLine(someNumber);
            }
        }
    }
}
