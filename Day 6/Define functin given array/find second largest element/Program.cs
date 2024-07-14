using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_second_largest_element
{1.  //1. Write a C# Sharp program to find the second largest element in an array
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = {1,5,3,9,7,8,6};

            int secondLargest = FindSecondLargest(num);

            if (secondLargest != int.MinValue)
            {
                Console.WriteLine("The second largest number is " + secondLargest);
            }
            else
            {
                Console.WriteLine("Not Find any Largest number here ");
            }
        }

        static int FindSecondLargest(int[] arr)
        {
            if (arr.Length < 2)
            {
                return int.MinValue; // Indicates that there's no second largest element
            }

            int firstLargest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in arr)
            {
                if (num > firstLargest)
                {
                    secondLargest = firstLargest;
                    firstLargest = num;
                }
                else if (num > secondLargest  &&  num != firstLargest)
                {
                    secondLargest = num;
                }
            }

            return secondLargest;
        }
    }
}
