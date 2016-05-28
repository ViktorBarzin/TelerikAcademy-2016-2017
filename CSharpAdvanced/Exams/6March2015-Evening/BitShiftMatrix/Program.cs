using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BitShiftMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            long rowsCount = long.Parse(Console.ReadLine());
            long colsCount = long.Parse(Console.ReadLine());

            long coeff = Math.Max(rowsCount, colsCount);
            Console.ReadLine();
            long[] codes = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            bool[,] visited = new bool[rowsCount, colsCount];

            long row = rowsCount - 1;
            long col = 0;
            BigInteger sum = 0;
            BigInteger currentCellValue = 1;

            for (int i = 0; i < codes.Length; ++i)
            {
                long nextRow = codes[i] / coeff;
                long nextCol = codes[i] % coeff;

                int deltaCol = nextCol > col ? 1 : -1;

                while (col != nextCol)
                {
                    if (!visited[row, col])
                    {
                        sum += currentCellValue;
                        visited[row, col] = true;
                    }
                    if (deltaCol > 0)
                    {
                        currentCellValue *= 2;
                    }
                    else
                    {
                        currentCellValue /= 2;
                    }
                    col += deltaCol;
                }

                int deltaRow = nextRow > row ? 1 : -1;

                while (row != nextRow)
                {
                    if (!visited[row, col])
                    {
                        sum += currentCellValue;
                        visited[row, col] = true;
                    }

                    if (deltaRow < 0)
                    {
                        currentCellValue *= 2;
                    }
                    else
                    {
                        currentCellValue /= 2;
                    }

                    row += deltaRow;
                }
            }

            if (!visited[row, col])
            {
                sum += currentCellValue;
            }

            Console.WriteLine(sum);
        }
    }
}
