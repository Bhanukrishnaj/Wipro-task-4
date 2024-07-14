using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_aray
// 2.  Write a C# Sharp program to  reverse array elements without using pre-defined methods. 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,4,9,10,11,12,15,17};
            Console.WriteLine("Normal array");

            PrintArray(numbers);
            ReverseArray(numbers);

            Console.WriteLine("Reversed array");
            PrintArray(numbers);
        }

        static void ReverseArray(int[] arr)
        {
            int n = arr.Length;
            for (int i=0; i<n/2; i++)
            {
                // Swap numbers
                int temp = arr[i];
                arr[i] = arr[n - i - 1]; //n=9,i=0 -1
                arr[n - i - 1] = temp;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int number in arr)
            {
                Console.Write("{0} ",number);
            }
            Console.WriteLine();
        }
    }
}
