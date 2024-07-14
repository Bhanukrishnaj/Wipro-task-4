using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_dimentional_matrix
//4. Write a C# program to read 2D Array elements from user. Consider 3 X 3 matrix. 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3,3];

   
          Console.WriteLine("Enter the number of the 3x3 matrix:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" Number [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Printing the 3x3 matrix
            Console.WriteLine("\nThe 3x3 matrix is:");
            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
