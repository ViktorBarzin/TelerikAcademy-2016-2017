using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShiftMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int colsCount = int.Parse(Console.ReadLine());

            int coeff = Math.Max(rowsCount, colsCount);
            Console.ReadLine();
            int[] codes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool[,] visited = new bool[rowsCount,colsCount];

            int row = rowsCount - 1;
            int col = 0;
            double sum = 1;

            for(int i = 0; i < codes.Length; ++i)
            {
                int nextRow = codes[i] / coeff;
                int nextCol = codes[i] % coeff;

                int deltaRow = nextRow > row ? 1 : -1;
                int deltaCol = nextCol > col ? 1 : -1;

                while(col + deltaCol != nextCol)
                {
                    if (!visited[row,col])
                    {
                        // 2^col * (rowsCount - 1 - row)
                        sum += Math.Pow(2, col + rowsCount - 1 - row); // formula
                        visited[row, col] = true;
                    }
                    col += deltaCol;
                }

                while(row + deltaRow != nextRow)
                {
                    if (!visited[row,col])
                    {
                        sum += Math.Pow(2, col + rowsCount - 1 - row); // formula
                        visited[row, col] = true;
                    }

                    row += deltaRow;
                }
            }

            Console.WriteLine(sum);
        }

        private static bool IsInside(int[,] matrix, int row, int col)
        {
            return row < matrix.GetLength(0) && col < matrix.GetLength(1);
        }
    }
}
