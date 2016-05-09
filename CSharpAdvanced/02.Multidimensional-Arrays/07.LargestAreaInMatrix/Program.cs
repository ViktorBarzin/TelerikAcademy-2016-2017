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
        private static void Main(string[] args)
        {

        }

        private static int LargestAreaInMatrix(int[,] matrix)
        {
            int maxCounter = 1;
            int currentCounter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                }
            }
            return maxCounter;
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

        private static List<int> GetListOfNEighhbours(int[,] matrix, int row, int col)
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
                neighbours.Add(matrix[row+1, col + 1]);
            }
            else if (row - 1 >= 0 && col + 1 < matrix.GetLength(1))
            {
                // up right
                neighbours.Add(matrix[row-1, col + 1]);
            }
            return neighbours;
        }
    }
}