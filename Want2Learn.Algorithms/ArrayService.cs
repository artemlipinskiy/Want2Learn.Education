using System;
using System.Collections.Generic;
using System.Text;

namespace Want2Learn.Algorithms
{
    class ArrayService
    {
        public void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    Console.WriteLine($"i = {i}, j = {j}");
                    Print(array);
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        Console.WriteLine($"swap: index {j} and {j + 1}");
                        Console.WriteLine("После:");
                        Print(array);
                        Console.WriteLine();
                    }
                }
            }
        }

        public void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                Print(arr);
                int pivotIndex = Partition(arr, low, high);
                QuickSort(arr, low, pivotIndex - 1);
                Print(arr);
                QuickSort(arr, pivotIndex + 1, high);
                Print(arr);
            }
        }

        public int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        public void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid;

                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; // Возвращаем -1, если элемент не найден
        }
    }
}
