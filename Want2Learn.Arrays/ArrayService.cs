using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.Arrays
{
    class ArrayService
    {

        public void Print(int[] array, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void AddOne(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]++;
            }
        }
    }
}
