using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.Cycles
{
    class SomeService
    {
        public void PrintWord(string word, int count)
        {
            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"current iteration: {i}");
                Console.WriteLine(word);
            }
        }

        public void PrintWordWhile(string word, int count)
        {
            int i = 7;
            while (i < count)
            {
                Console.WriteLine($"current iteration: {i}");
                Console.WriteLine(word);
                i++;
            }
        }

        public void PrintWordDoWhile(string word, int count)
        {
            int i = 7;
            do
            {
                Console.WriteLine($"current iteration: {i}");
                Console.WriteLine(word);
                i++;
            } while (i < count);
        }

        public void DoSomething()
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine($"current iteration: {i}");
                if (i == 10)
                {
                    break;
                }
            }
        }
    }
}
