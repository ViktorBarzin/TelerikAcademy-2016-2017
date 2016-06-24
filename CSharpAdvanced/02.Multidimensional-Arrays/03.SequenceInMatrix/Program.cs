﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SequenceInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read input
            int[] nAndM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nAndM[0];
            int m = nAndM[1];
            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                int[] currentLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int i = 0; i < currentLine.Length; i++)
                {
                    matrix[row, i] = currentLine[i];
                }
            }
            Console.WriteLine(GetLongestSequenceOfEqualElements(matrix));

        }

        private static int GetLongestSequenceOfEqualElements(int[,] matrix)
        {
            int maxCounter = 0;
            int currentCounter = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int i = 0;
                    if (col + 1 < matrix.GetLength(1) && matrix[row, col] == matrix[row, col + 1])
                    {
                        // right
                        while (col + i < matrix.GetLength(1) && matrix[row, col] == matrix[row, col + i])
                        {
                            currentCounter++;
                            i++;
                        }
                    }
                    else if (col - 1 >= 0 && matrix[row, col] == matrix[row, col - 1])
                    {
                        // left
                        while (col - i >= 0 && matrix[row, col] == matrix[row, col - i])
                        {
                            currentCounter++;
                            i++;
                        }
                    }
                    else if (row + 1 < matrix.GetLength(0) && matrix[row, col] == matrix[row + 1, col])
                    {
                        // down
                        while (i + row < matrix.GetLength(0) && matrix[row, col] == matrix[row + i, col])
                        {
                            currentCounter++;
                            i++;
                        }
                    }
                    else if (row - 1 >= 0 && matrix[row, col] == matrix[row - 1, col])
                    {
                        // up
                        while (row - i >= 0 && matrix[row, col] == matrix[row - i, col])
                        {
                            currentCounter++;
                            i++;
                        }
                    }
                    else if (row + 1 < matrix.GetLength(0) && col - 1 >= 0 && matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        // down left
                        while (i + row < matrix.GetLength(0) && col - i >= 0 && matrix[row, col] == matrix[row + i, col - i])
                        {
                            currentCounter++;
                            i++;
                        }
                    }
                    else if (row - 1 >= 0 && col - 1 >= 0 && matrix[row, col] == matrix[row - 1, col - 1])
                    {
                        // up left
                        while (row - i >= 0 && col - i >= 0 && matrix[row, col] == matrix[row - i, col - i])
                        {
                            currentCounter++;
                            i++;
                        }
                    }
                    else if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1) && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        // down right
                        while (row + i < matrix.GetLength(0) && col + i < matrix.GetLength(1) && matrix[row, col] == matrix[row + i, col + i])
                        {
                            currentCounter++;
                            i++;
                        }
                    }
                    else if (row - 1 >= 0 && col + 1 < matrix.GetLength(1) && matrix[row, col] == matrix[row - 1, col + 1])
                    {
                        // up right
                        while (row - i >= 0 && col + i < matrix.GetLength(1) && matrix[row, col] == matrix[row - i, col + i])
                        {
                            currentCounter++;
                            i++;
                        }
                    }

                    if (currentCounter > maxCounter)
                    {
                        maxCounter = currentCounter;
                    }
                    currentCounter = 0;
                }
            }

            return maxCounter;
        }
    }
}
