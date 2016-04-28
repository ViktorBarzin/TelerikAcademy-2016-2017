using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeds
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());

            // Insert cr speeds
            List<int> carSpeeds = new List<int>();
            for (int i = 0; i < c; i++)
            {
                carSpeeds.Add(int.Parse(Console.ReadLine()));
            }

            List<CarGroups> AllGroups = new List<CarGroups>();

            //Dictionary<int,int> StartIndexLenGroups = new Dictionary<int, int>();
            //Dictionary<int,int> IndexSpeeds = new Dictionary<int, int>();
            //bool isLast = false;
            // separate and search logic
            for (int i = 0; i < carSpeeds.Count; i++)
            {
                // is last works properly but not with expected result :(

                //if (isLast)
                //{
                //    break;
                    
                //}
                //if (i + 1 == carSpeeds.Count)
                //{
                //    i--;
                //    isLast = true;
                //}
                for (int j = i+1; j < carSpeeds.Count; j++)
                {
                    if (carSpeeds[i] < carSpeeds[j])
                    {
                        continue;
                    }
                    //if (isLast)
                    //{
                    //    i++;
                    //}

                    //StartIndexLenGroups.Add(i,j-i);
                    //IndexSpeeds.Add(i,GetSumOfSpeeds(i,j,carSpeeds));

                    CarGroups newgroup = new CarGroups(i,j-i,GetSumOfSpeeds(i,j,carSpeeds));
                    AllGroups.Add(newgroup);
                    //new group starts here
                    //if (isLast)
                    //{
                    //    StartIndexLenGroups[i]++;
                    //    break;
                    //}
                    i = j - 1;
                    
                    break;
                }
            }

            // print groups
            //foreach (var group in AllGroups)
            //{
            //    Console.WriteLine(string.Format("{0}:{1},{2}", group.startIndex, group.len, group.speedSum));
            //    Console.WriteLine();
            //}
            int specialSum = 0;
            bool isSorted = true;
            for (int i = 0; i < carSpeeds.Count-1; i++)
            {
                if (carSpeeds[i] > carSpeeds[i+1])
                {
                    isSorted = false;
                    break;
                }
                specialSum += carSpeeds[i];
            }

            if (isSorted && carSpeeds.Count > 2)
            {
                Console.WriteLine(specialSum);
                return;
                
            }

            List<CarGroups> sortedGroupsByLen = AllGroups.OrderByDescending(x => x.len).ToList();
            if (sortedGroupsByLen.Count == 0)
            {
                Console.WriteLine(carSpeeds[AllGroups.OrderByDescending(x => x.speedSum).Take(1).FirstOrDefault().startIndex]);
                return;
            }
            int maxLen = sortedGroupsByLen[0].len;

            List<CarGroups> topGroups = sortedGroupsByLen.Where(x => x.len == maxLen).ToList();

            if (topGroups.Count == 1)
            {
                Console.WriteLine(topGroups[0].speedSum);
            }
            else
            {
                int winnerIndex = 0;
                for (int i = 0; i < topGroups.Count; i++)
                {
                    if (topGroups[i].speedSum > topGroups[winnerIndex].speedSum)
                    {
                        winnerIndex = i;
                    }
                }
                Console.WriteLine(topGroups[winnerIndex].speedSum);
            }
        }

        private static int GetSumOfSpeeds(int a, int b,List<int> speeds)
        {
            int sum = 0;
            for (int i = a; i < b; i++)
            {
                sum += speeds[i];
            }
            return sum;
        }
    }

    internal class CarGroups
    {
        public int startIndex;

        public int len;

        public int speedSum;

        public CarGroups(int startIndex, int len, int speedSum)
        {
            this.startIndex = startIndex;
            this.len = len;
            this.speedSum = speedSum;
        }
    }
}
