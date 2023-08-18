using System;

namespace Want2Learn.Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 4, 2, 2, 3 };

            ArrayService service = new ArrayService();
            service.BubbleSort(array);

            service.Print(array);
        }
    }
}
