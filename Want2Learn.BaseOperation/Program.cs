using System;

namespace Want2Learn.BaseOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, uint
            // тип данных - 1. Область допустимых значений 2. Допустимые операции 3. Кол-во выделяемой памяти
            int age = 15;
            int maxValue = int.MaxValue;
            int minValue = int.MinValue;

            uint newUintValue = 14;
            uint uintMinValue = uint.MinValue;
            uint uintMaxValue = uint.MaxValue;

            // u - unsigned, s - signed
            // byte, sbyte, short, ushort, long, ulong
            int age2 = 3 + 5;
            // + - / *
            Console.WriteLine(age2);
            int age3 = 5 / 2;
            Console.WriteLine("5 / 2 = ");
            Console.WriteLine(age3);

            // %
            int age4 = 5 % 2;
            Console.WriteLine("5 % 2 = ");
            Console.WriteLine(age4);

            int age5 = 324 % 10;
            //
            Console.WriteLine(age5);

            age5 = age4 + 10;
            Console.WriteLine(age5);

            //числа с плав. точкой (дробные числа)
            //double, float, decimal
            double PI = 3.14;
            Console.WriteLine(PI);

            double numberFirst = 5;
            double numberSecond = 2;
            double result = numberFirst / numberSecond;
            Console.WriteLine(result);

            //Явное и неявное приведение типов

            //Явное
            int numberIntOne = 250;
            byte numberByteOne = (byte)numberIntOne;
            Console.WriteLine("Number byte one");
            Console.WriteLine(numberByteOne);

            numberIntOne = 258;
            numberByteOne = (byte)numberIntOne;
            Console.WriteLine(numberByteOne);


            Console.WriteLine(uintMinValue);
            Console.WriteLine(uintMaxValue);

            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
            Console.WriteLine(age);
            Console.WriteLine("Hello World!");


            maxValue = maxValue + 1;
            Console.WriteLine(maxValue);

            // maxValue = maxValue + 5
            maxValue += 5;
            Console.WriteLine(maxValue);

            Console.WriteLine();
            Console.Write("Hello \n");
            Console.Write("Hello");

            // string - текст
            string someText = "Some text";
            Console.WriteLine(someText);

            string name = "Artem";
            string ageStr = "26";
            //Конкатенация - процесс склеивания строк
            string info = "Name: " + name + " Age: " + ageStr;
            Console.WriteLine(info);

            //Интерполяция
            string info2 = $"Name: {name} Age: {ageStr}";
            Console.WriteLine(info2);

            //Считывание данных
            string dataFromConsole = Console.ReadLine();
            Console.WriteLine(dataFromConsole);

            //
            string ageFromConsoleStr = Console.ReadLine();
            int ageFromConsole = int.Parse(ageFromConsoleStr);
            ageFromConsole += 20;
            Console.WriteLine($"Age: {ageFromConsole}");
            //int ageFromConsole = int.Parse(Console.ReadLine());

            //char, object, bool

            Console.WriteLine("TEST NEW COMMIT");
        }
    }
}
