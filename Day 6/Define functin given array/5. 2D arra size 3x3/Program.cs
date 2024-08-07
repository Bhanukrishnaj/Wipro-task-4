﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2D_arra_size_3x3
//5.  Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix. 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a 3x3 2D array
            int[,] matrix = new int[3, 3]
            {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
