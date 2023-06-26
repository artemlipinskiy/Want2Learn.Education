using System;

namespace Want2Learn.SeconProject
{
    class Program
    {
        static void Main(string[] args)
        {
            const int HOURSEINDAY = 24;
            const int MINUTESINDAY = 60;

            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int result = HOURSEINDAY * MINUTESINDAY * days + MINUTESINDAY * hours + minutes;
            Console.WriteLine("Hello World!");

            char symbol = 'q';
            int symbolCode = (int)symbol;
            symbolCode += 1;
            symbol = (char)symbolCode;
            Console.WriteLine(symbolCode);
            Console.WriteLine(symbol);
            char symbolTwo = Console.ReadKey().KeyChar;
        }
    }
}
