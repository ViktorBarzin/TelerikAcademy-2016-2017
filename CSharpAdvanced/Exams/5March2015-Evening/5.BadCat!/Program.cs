using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BadCat_
{
    class Program
    {
        static void Main(string[] args)
        {
            // check what the number value is, and insert it as right as possible depending on before and after
            // while loops --> before - starts from 0, after - starts from index of y
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RestoreNumber(n));
        }

        private static int RestoreNumber(int n)
        {
            List<int> number = new List<int>(2 * n + 1);
            for (int i = 0; i < n; i++)
            {
                string instruction = Console.ReadLine();
                int x = ExtractNumbers(instruction, new[] { ' ' })[0];
                int y = ExtractNumbers(instruction, new[] { ' ' })[1];

                // First iteration insert both numbers
                if (i == 0)
                {
                    if (x != y)
                    {
                        if (instruction.Contains("before"))
                        {
                            number.Add(x);
                            number.Add(y);
                        }
                        else if (instruction.Contains("after"))
                        {
                            number.Add(y);
                            number.Add(x);
                        }
                    }
                    else
                    {
                        number.Add(x);
                    }
                }
                else if (instruction.Contains("before"))
                {
                    // If number does not contain the first number but contains the second
                    if (!number.Contains(x) && number.Contains(y))
                    {
                        //number.Insert(number.IndexOf(y), x);
                        int j = 0;
                        while (j < number.IndexOf(y) && x > number[j])
                        {
                            j++;
                        }
                        number.Insert(j, x);
                    }

                    // If numbers does contain the first number but does not contain the second
                    else if (number.Contains(x) && !number.Contains(y))
                    {
                        int j = number.IndexOf(x) + 1;
                        while (j + 1 < number.Count && x > number[j])
                        {
                            j++;
                        }
                        number.Insert(j, y);
                    }

                    // If both numbers missing rearrange?
                    else if (!number.Contains(x) && !number.Contains(y))
                    {
                        int j = 0;
                        while (j + 1 < number.Count && x > number[j])
                        {
                            j++;
                        }
                        number.Insert(j, x);

                        // number.Add(x);
                        //number.Add(y);
                        j++;
                        while (j + 1 < number.Count && y > number[j])
                        {
                            j++;
                        }
                        number.Insert(j, y);

                    }
                }

                // Instruction is after
                else
                {
                    // If number does not contain the first number but contains the second
                    if (!number.Contains(x) && number.Contains(y))
                    {
                        //number.Insert(indexToInsertAt, x);
                        int j = number.IndexOf(y) + 1;
                        while (j + 1 < number.Count && x > number[j])
                        {
                            j++;
                        }
                        number.Insert(j, x);
                    }

                    // If numbers does containt the first number but does not contain the second
                    else if (number.Contains(x) && !number.Contains(y))
                    {
                        //number.Insert(indexToInsertAt, y);
                        int j = 0;
                        // TODO : <= or <?
                        while (y > number[j] && j < number.IndexOf(x))
                        {
                            j++;
                        }
                        number.Insert(j, y);
                    }

                    // If both numbers are missing rearrange?
                    else if (!number.Contains(x) && !number.Contains(y))
                    {
                        int j = 0;
                        while (j + 1 < number.Count && y > number[j])
                        {
                            j++;
                        }
                        number.Insert(j, y);
                        j++;
                        while (j + 1 < number.Count && x > number[j])
                        {
                            j++;
                        }
                        number.Insert(j, x);
                    }
                }
            }

            return int.Parse(string.Join("", number));
        }

        private static List<int> ExtractNumbers(string sentence, char[] separators)
        {
            string[] words = sentence.Split(separators);
            List<int> numbers = new List<int>();
            foreach (var word in words)
            {
                int n;
                if (int.TryParse(word, out n))
                {
                    numbers.Add(n);
                }
            }

            return numbers;
        }
    }
}
