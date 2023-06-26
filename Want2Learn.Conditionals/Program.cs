using System;

namespace Want2Learn.Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int someNumberOne = 23;
            int someNumberTwo = 23;

            bool firstCond = true;
            bool secondCond = false;
            // >
            bool thirdCond = someNumberOne < someNumberTwo;
            // >=
            bool fourthCond = someNumberOne <= someNumberTwo;
            // == !=
            bool fifthCond = someNumberOne == someNumberTwo;
            bool sixthCond = someNumberOne != someNumberTwo;
            Console.WriteLine(thirdCond);
            Console.WriteLine(fourthCond);
            Console.WriteLine(fifthCond);
            Console.WriteLine(sixthCond);
            firstCond = !firstCond;
            secondCond = !secondCond;
            Console.WriteLine(firstCond);

            string strOne = "Hello";
            string strTwo = "hello";
            //Регистр букв стоит учитывать
            bool seventhCond = strOne == strTwo;
            Console.WriteLine(seventhCond);


            bool firstOp = firstCond || secondCond;
            Console.WriteLine(firstOp);

            bool secondOp = firstCond && secondCond;
            Console.WriteLine(secondOp);

            bool thirdOp = (someNumberOne < someNumberTwo) || (someNumberOne > 20);
            Console.WriteLine(thirdOp);

            //IF
            if (someNumberOne < someNumberTwo)
            {
                Console.WriteLine("First < Second");
                Console.WriteLine("First < Second");
                Console.WriteLine("First < Second");
                Console.WriteLine("First < Second");
            }

            if (someNumberOne <= someNumberTwo)
            {
                Console.WriteLine("First <= Second");
            }

            //IF ELSE
            if (someNumberOne < someNumberTwo)
            {
                Console.WriteLine("BYE");
            }
            else
            {
                Console.WriteLine("HELLO");
                Console.WriteLine("HELLO");
            }

            //IF ELSE IF
            if (someNumberOne < someNumberTwo)
            {
                Console.WriteLine("BYE");
            }
            else if(someNumberOne == someNumberTwo)
            {
                Console.WriteLine("QQQ");
            }

            int inputedNumber = int.Parse(Console.ReadLine());
            if (inputedNumber == 10)
            {
                Console.WriteLine("Число 10");
            }
            if (inputedNumber == 20)
            {
                Console.WriteLine("Число 20");
            }
            if (inputedNumber == 30)
            {
                Console.WriteLine("Число 30");
            }
            if (inputedNumber == 40)
            {
                Console.WriteLine("Число 40");
            }
            if (inputedNumber != 10 && inputedNumber != 20 && inputedNumber != 30 && inputedNumber != 40)
            {
                Console.WriteLine("Число не 10, 20, 30 или 40");
            }

            //SWITCH CASE
            switch (inputedNumber)
            {
                case 10:
                    Console.WriteLine("Число 10");
                    break;
                case 20:
                    Console.WriteLine("Число 20");
                    break;
                case 30:
                    Console.WriteLine("Число 30");
                    break;
                case 40:
                    Console.WriteLine("Число 40");
                    break;
                default:
                    Console.WriteLine("Число не 10, 20, 30 или 40");
                    break;
            }

            //Тернарный оператор
            string someText = inputedNumber > 10 ? "Больше 10" : "Меньше или = 10";

        }
    }
}
