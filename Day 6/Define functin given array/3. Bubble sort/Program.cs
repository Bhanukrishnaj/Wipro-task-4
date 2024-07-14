using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Bubble_sort
//3.  Write a C# program to sort the array elements using Bubble sort technique.
//(Hint:  Do not use pre-defined methods ) 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {9,5,7,2,11,15,17};

            Console.WriteLine("Normal array:");

            PrintArray(numbers);
            BubbleSort(numbers);

            Console.WriteLine("Sorted array:");
            PrintArray(numbers);
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i=0; i< n-1; i++)
            {
                for (int j=0; j< n-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int number in arr)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
