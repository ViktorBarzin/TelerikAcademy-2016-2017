using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LargestAreaInMatrix
{
    using System.Security.Policy;

    internal class Program
    {
        private static int n;

        private static int m;

        private static int[,] matrix = new int[n, m];

        private static bool[,] visited = new bool[n, m];

        private static int maxCounter = 0;

        private static int currentCounter = 0;

        private static void Main(string[] args)
        {
            int[] nAndM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            n = nAndM[0];
            m = nAndM[1];
            matrix = new int[n, m];
            visited = new bool[n, m];
            for (int row = 0; row < n; row++)
            {
                int[] currentLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int i = 0; i < currentLine.Length; i++)
                {
                    matrix[row, i] = currentLine[i];
                }
            }
            LargestAreaInMatrix(matrix);
            Console.WriteLine(maxCounter);
        }

        private static void LargestAreaInMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (!visited[row,col])
                    {
                        DFS(row, col, matrix[row, col]);

                        if (currentCounter > maxCounter)
                        {
                            maxCounter = currentCounter;
                            visited = new bool[n, m];
                        }
                        currentCounter = 0;
                    }
                }
            }
        }

        static void DFS(int row, int col, int element)
        {
            if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return;
            }

            if (visited[row, col])
            {
                return;
            }

            visited[row, col] = true;

            if (matrix[row, col] == element)
            {
                currentCounter++;
            }
            else
            {
                return;
            }

            DFS(row, col - 1, element);
            DFS(row - 1, col, element);
            DFS(row, col + 1, element);
            DFS(row + 1, col, element);
        }
    }
}