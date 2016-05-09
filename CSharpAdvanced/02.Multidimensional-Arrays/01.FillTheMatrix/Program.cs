using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillTheMatrix
{
    using System.Data;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string inputChar = Console.ReadLine();
            Fill(n, inputChar[0]);
        }

        private static void Fill(int n, char c)
        {
            int[,] matrix = new int[n, n];
            switch (c)
            {
                case 'a':
                    int counterA = 1;
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            matrix[col, row] = counterA++;
                        }
                    }
                    Print(matrix);
                    break;
                case 'b':
                    int counterB = 1;
                    bool isOdd = true;
                    for (int row = 0; row < n; row++)
                    {
                        if (isOdd)
                        {
                            for (int col = 0; col < n; col++)
                            {
                                matrix[col, row] = counterB++;
                            }
                        }
                        else
                        {
                            for (int col = matrix.GetLength(0) - 1; col >= 0; col--)
                            {
                                matrix[col, row] = counterB++;
                            }
                        }

                        isOdd = !isOdd;
                    }
                    Print(matrix);
                    break;
                case 'c':
                    int counter = 1;

                    // Print lower left side

                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        for (int col = 0; col < matrix.GetLength(0) - row; col++)
                        {
                            matrix[row + col, col] = counter++;
                        }
                    }

                    // Print upper right side

                    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                    {
                        for (int col = 1; col < matrix.GetLength(1) - row; col++)
                        {
                            matrix[col - 1, col + row] = counter++;
                        }
                    }

                    Print(matrix);
                    break;
                case 'd':
                    int counterD = 1;

                    // Add left side to down

                    for (int bottomRow = 0; bottomRow < 1; bottomRow++)
                    {
                        for (int bottomCol = 0; bottomCol < matrix.GetLength(1); bottomCol++)
                        {
                            matrix[bottomCol, bottomRow] = counterD++;
                        }
                    }

                    // Add bottom side to right

                    for (int bottomRow = 0; bottomRow < 1; bottomRow++)
                    {
                        for (int bottomCol = 0; bottomCol < matrix.GetLength(1) - 1; bottomCol++)
                        {
                            matrix[matrix.GetLength(0) - 1, bottomCol + 1] = counterD++;
                        }
                    }

                    // Add right side to up


                    // TODO : add d point
                    //Add top side to left

                    Print(matrix);
                    break;
                default:
                    break;
            }
        }

        private static void Print(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col + 1 != matrix.GetLength(0))
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    else
                    {
                        Console.Write(matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
