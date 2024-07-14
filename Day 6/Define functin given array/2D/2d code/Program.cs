using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize a 2D array
            int[,] arr = new int[,]
            {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };

            // Accessing elements in the 2D array
            Console.WriteLine("length: " + arr.Length);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
