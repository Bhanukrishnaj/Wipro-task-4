using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_functin_given_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] numbers = { 5, 2, 9, 1, 5, 6 };
                int target = 9;
                int index = LinearSearch(numbers, target);

                if (index != -1)
                {
                    Console.WriteLine($"Element found at index: {index}");
                }
                else
                {
                    Console.WriteLine("Element not found.");
                }
            }

            static int LinearSearch(int[] arr, int element)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == element)
                    {
                        return i; // Element found at index i
                    }
                }
                return -1; // Element not found
            }
        
    }
}
