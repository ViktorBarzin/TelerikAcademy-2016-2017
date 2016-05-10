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

        private static bool HasEqualNeighbour(int origin, int[,] matrix, int row, int col)
        {
            if (col + 1 < matrix.GetLength(1) && matrix[row, col] == matrix[row, col + 1])
            {
                // right
                return true;
            }
            else if (col - 1 >= 0 && matrix[row, col] == matrix[row, col - 1])
            {
                // left
                return true;
            }
            else if (row + 1 < matrix.GetLength(0) && matrix[row, col] == matrix[row + 1, col])
            {
                // down
                return true;
            }
            else if (row - 1 >= 0 && matrix[row, col] == matrix[row - 1, col])
            {
                // up
                return true;
            }
            else if (row + 1 < matrix.GetLength(0) && col - 1 >= 0
                     && matrix[row, col] == matrix[row + 1, col - 1])
            {
                // down left
                return true;
            }
            else if (row - 1 >= 0 && col - 1 >= 0 && matrix[row, col] == matrix[row - 1, col - 1])
            {
                // up left
                return true;
            }
            else if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1)
                     && matrix[row, col] == matrix[row + 1, col + 1])
            {
                // down right
                return true;
            }
            else if (row - 1 >= 0 && col + 1 < matrix.GetLength(1)
                     && matrix[row, col] == matrix[row - 1, col + 1])
            {
                // up right
                return true;
            }

            return false;
        }

        private static List<int> GetListOfNeighhbours(int[,] matrix, int row, int col)
        {
            List<int> neighbours = new List<int>();
            if (col + 1 < matrix.GetLength(1))
            {
                // right
                neighbours.Add(matrix[row, col + 1]);
            }
            else if (col - 1 >= 0)
            {
                // left
                neighbours.Add(matrix[row, col - 1]);
            }
            else if (row + 1 < matrix.GetLength(0))
            {
                // down
                neighbours.Add(matrix[row + 1, col]);
            }
            else if (row - 1 >= 0)
            {
                // up
                neighbours.Add(matrix[row - 1, col]);
            }
            else if (row + 1 < matrix.GetLength(0) && col - 1 >= 0)
            {
                // down left
                neighbours.Add(matrix[row + 1, col - 1]);
            }
            else if (row - 1 >= 0 && col - 1 >= 0)
            {
                // up left
                neighbours.Add(matrix[row - 1, col - 1]);
            }
            else if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1))
            {
                // down right
                neighbours.Add(matrix[row + 1, col + 1]);
            }
            else if (row - 1 >= 0 && col + 1 < matrix.GetLength(1))
            {
                // up right
                neighbours.Add(matrix[row - 1, col + 1]);
            }
            return neighbours;
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