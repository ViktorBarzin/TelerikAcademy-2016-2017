using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _5.HelpDoge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];

            int[] fxy = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int foodX = fxy[0];
            int foodY = fxy[1];

            bool[,] isEnemy = new bool[n+1, m+1];
            int enemiesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < enemiesCount; i++)
            {
                int[] exy = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int enemyX = exy[0];
                int enemyY = exy[1];

                isEnemy[enemyX, enemyY] = true;
            }

            BigInteger[,] dp = new BigInteger[n, m];
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                dp[i, 0] = 1;
            }

            for (int j = 0; j < dp.GetLength(1); j++)
            {
                dp[0, j] = 1;
            }

            for (int i = 1; i < dp.GetLength(0); i++)
            {
                for (int j = 1; j < dp.GetLength(1); j++)
                {
                    dp[i, j] = isEnemy[i, j] ? 0 : dp[i - 1, j] + dp[i, j - 1];
                }
            }

            Console.WriteLine(dp[foodX, foodY]);

        }
    }
}