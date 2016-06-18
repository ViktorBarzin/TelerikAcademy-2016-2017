using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LoverOfThree
{
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main(string[] args)
        {
            int[] rc = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowsCount = rc[0];
            int colsCount = rc[1];
            int n = int.Parse(Console.ReadLine());
            bool[,] visited = new bool[rowsCount, colsCount];

            int currentCellValue = 0;
            int sum = 0;

            int row = rowsCount - 1;
            int col = 0;
            for (int i = 0; i < n; i++)
            {
                string[] instruction = Console.ReadLine().Split(' ').ToArray();
                string direction = instruction[0];
                int count = int.Parse(instruction[1]);

                int deltaRow = direction.Contains("U") ? -1 : 1;
                int deltaCol = direction.Contains("L") ? -1 : 1;

                for (int j = 1; j < count; j++)
                {
                   if (IsInside(visited, row + deltaRow, col + deltaCol))
                    {
                        row += deltaRow;
                        col += deltaCol;
                        if (direction.Contains("U") && direction.Contains("R"))
                        {
                            currentCellValue += 6;
                        }
                        else if (direction.Contains("D") && direction.Contains("L"))
                        {
                            currentCellValue -= 6;
                        }
                    }
                    if (!visited[row,col])
                    {
                        sum += currentCellValue;
                        visited[row, col] = true;
                    }
                }
            }

            Console.WriteLine(sum);

        }

        private static bool IsInside(bool[,] matrix, int row, int col)
        {
            return matrix.GetLength(0) > row
                && row >= 0
                && matrix.GetLength(1) > col
                && col >= 0;
        }
    }
}
