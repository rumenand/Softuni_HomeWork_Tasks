﻿using System;
using System.Linq;

namespace _6._Bomb_the_Basement
{
    class Program
    {
        static void Main()
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            int[] bombParam = Console.ReadLine().Split().Select(int.Parse).ToArray();
            BoomAction(matrix, bombParam);
            GravityFall(matrix);
            PrintMatrix(matrix);
        }

        static void BoomAction(int[,] matrix, int [] bomb)
        {
            for (int i=0; i<matrix.GetLength(0); i++)
            {
                for (int j=0; j<matrix.GetLength(1); j++)
                {
                    double distamceToBomb = Math.Sqrt(Math.Pow((bomb[0] - i), 2) + Math.Pow((bomb[1] - j), 2));
                    if (distamceToBomb <= bomb[2]) matrix[i, j] = 1;
                }
            }
        }

        static void GravityFall(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            if (rows < 2) return;
            else
            {
                bool moved = true;
                while (moved)
                {
                    moved = false;
                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            if (matrix[i, j] == 1 && matrix[i - 1, j] == 0)
                            {
                                matrix[i, j] = 0;
                                matrix[i - 1, j] = 1;
                                moved = true;
                            }
                        }
                    }
                }
            }
        }

        static void PrintMatrix(int [,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
