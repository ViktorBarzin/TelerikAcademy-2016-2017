using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DancingMoves
{
    using System.Numerics;

    class Program
    {
        // TODO : 40/100 fix
        static void Main()
        {
            double[] field = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            string command = Console.ReadLine();
            double result = 0;
            int numberOfTurns = 0;

            int currentPosition = 0;
            while (command != "stop")
            {
                double sum = 0;
                string[] splittedCommand = command.Split(' ');
                double times = double.Parse(splittedCommand[0]);
                string direction = splittedCommand[1];
                int step = int.Parse(splittedCommand[2]);
                
                if (direction == "right")
                {
                    for (int i = 0; i < times; i++)
                    {
                        //Check if next step is inside
                        if (IsInsideForRightMovement(field, currentPosition, step))
                        {
                            sum += field[currentPosition + step];
                            currentPosition = (currentPosition + step) % field.Length;
                        }
                        else
                        {
                            int newPosition = (currentPosition + step) % field.Length;
                            sum += field[newPosition];
                            currentPosition = newPosition;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < times; i++)
                    {
                        //Check if next step is inside
                        if (IsInsideForLeftMovement(currentPosition, step))
                        {
                            currentPosition -= step;
                            // Update sym before adding
                            sum += field[currentPosition];
                        }

                        else
                        {
                            currentPosition = field.Length - ((Math.Abs(currentPosition - step)) % field.Length);
                            sum += field[currentPosition];
                        }
                    }
                }
                // Update
                command = Console.ReadLine();
                numberOfTurns++;
                result += sum;
            }

            Console.WriteLine("{0:F1}", result / numberOfTurns);
        }

        private static bool IsInsideForRightMovement(double[] array, double currentIndex, double stepToMake)
        {
            return currentIndex + stepToMake < array.Length;
        }

        private static bool IsInsideForLeftMovement(double currentIndex, double stepToMake)
        {
            return currentIndex - stepToMake >= 0;
        }
    }
}
