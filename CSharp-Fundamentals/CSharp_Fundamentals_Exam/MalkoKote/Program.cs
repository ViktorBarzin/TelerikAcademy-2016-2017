using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalkoKote
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char symbol = Console.ReadLine().ToCharArray()[0];
            int neckWidth = size / 6;
            neckWidth = 1;
            neckWidth += (size - 10) / 4;
            int width = neckWidth + 6 + neckWidth + 1;
            char[,] matrix = new char[size, width];

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    matrix[row, col] = ' ';
                }
            }

            //ears
            matrix[0, 1] = symbol;
            matrix[0, neckWidth + 2] = symbol;

            //print head 
            for (int row = 1; row < neckWidth + 1; row++)
            {
                for (int col = 1; col < neckWidth + 3; col++)
                {
                    matrix[row, col] = symbol;
                }
            }

            //print Neck
            for (int row = neckWidth + 1; row < 2 * neckWidth + 1; row++)
            {
                for (int col = 2; col < neckWidth + 2; col++)
                {
                    matrix[row, col] = symbol;
                }
            }

            //Upper Belly
            for (int row = 2 * neckWidth + 1; row < 3 * neckWidth + 2; row++)
            {
                for (int col = 1; col < neckWidth + 3; col++)
                {
                    matrix[row, col] = symbol;
                }
            }

            //lower belly
            int lowerBellyRows = 4;
            lowerBellyRows += (size - 10) / 4;
            for (int row = 3 * neckWidth + 2; row < size - 1; row++)
            {
                for (int col = 0; col < neckWidth + 4; col++)
                {
                    matrix[row, col] = symbol;
                }
            }

            //feet
            for (int col = 1; col < neckWidth + 6; col++)
            {
                matrix[size - 1, col] = symbol;
            }

            //tail`s base
            matrix[size - 2, neckWidth + 5] = symbol;
            matrix[size - 2, neckWidth + 6] = symbol;

            //tails body
            for (int row = 3 * neckWidth + 1; row < size - 2; row++)
            {
                matrix[row, neckWidth + 6] = symbol;
            }

            //tail`s end
            for (int col = neckWidth + 6; col < width; col++)
            {
                matrix[3 * neckWidth + 1, col] = symbol;
            }

            Print(matrix);
        }

        private static void Print(char[,] matrix)
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