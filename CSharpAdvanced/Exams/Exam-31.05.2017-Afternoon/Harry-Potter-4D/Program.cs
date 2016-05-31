namespace Harry_Potter_4D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static byte[,,,] hyperMatrix;
        static readonly List<Basilisk> Basiliks = new List<Basilisk>();
        static Basilisk character;
        static int movesCount;

        static void Main()
        {
            Initialize();
            int basiliksCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < basiliksCount; i++)
            {
                AddBasiliks();
            }


            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] splittedCommand = command.Split(' ');
                string subject = splittedCommand[0];

                if (subject == "@")
                {
                    MoveCharacter(command);
                    if (hyperMatrix[character.X, character.Y, character.Z, character.B] > 0)
                    {
                        char killer = GetKiller();
                        Console.WriteLine(" {0}: \"Step {1} was the worst you ever made.\"", killer, movesCount);
                        Console.WriteLine(" {0}: \"You will regret until the rest of your life... All 3 seconds of it!\"", killer, movesCount);
                        return;
                    }
                }
                else
                {
                    Basilisk currentBasil = MoveBasil(command);
                    if (CheckForHarry(currentBasil.X, currentBasil.Y, currentBasil.Z, currentBasil.B))
                    {
                        Console.WriteLine(" {0}: \"You thought you could escape, didn't you?\" - {1}", subject, movesCount);
                        return;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(" @: \"I am the chosen one!\" - {0}", movesCount);
        }

        public static void Initialize()
        {
            int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            hyperMatrix = new byte[dimentions[0], dimentions[1], dimentions[2], dimentions[3]];


            dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            character = new Basilisk("@", dimentions[0], dimentions[1], dimentions[2], dimentions[3], Basiliks.Count);
            //basiliks.Add(character);
            //hyperMatrix[dimentions[0], dimentions[1], dimentions[2], dimentions[3]] += 1;
        }
        public static void AddBasiliks()
        {
            string[] dimentions = Console.ReadLine().Split(' ').ToArray();

            Basiliks.Add(new Basilisk(dimentions[0],
            int.Parse(dimentions[1]),
            int.Parse(dimentions[2]),
            int.Parse(dimentions[3]),
            int.Parse(dimentions[4]),
            Basiliks.Count));
            hyperMatrix[int.Parse(dimentions[1]), int.Parse(dimentions[2]), int.Parse(dimentions[3]), int.Parse(dimentions[4])] += 1;
        }
        public static void MoveCharacter(string command)
        {
            string[] splittedCommand = command.Split(' ');
            string dimention = splittedCommand[1];
            int movement = int.Parse(splittedCommand[2]);
            movesCount++;

            if (dimention == "A")
            {
                if (character.X + movement >= hyperMatrix.GetLength(0)
                || character.X + movement < 0)
                {
                    if (character.X + movement >= hyperMatrix.GetLength(0))
                    {
                        character.X = hyperMatrix.GetLength(0) - 1;
                    }
                    else
                    {
                        character.X = 0;
                    }
                }
                else
                {
                    character.X += movement;
                }
            }
            else if (dimention == "B")
            {
                if (character.Y + movement >= hyperMatrix.GetLength(1)
                || character.Y + movement < 0)
                {
                    if (character.Y + movement >= hyperMatrix.GetLength(1))
                    {
                        character.Y = hyperMatrix.GetLength(1) - 1;
                    }
                    else
                    {
                        character.Y = 0;
                    }
                }
                else
                {
                    character.Y += movement;
                }
            }
            else if (dimention == "C")
            {
                if (character.Z + movement >= hyperMatrix.GetLength(2)
                || character.Z + movement < 0)
                {
                    if (character.Z + movement >= hyperMatrix.GetLength(2))
                    {
                        character.Z = hyperMatrix.GetLength(2) - 1;
                    }
                    else
                    {
                        character.Z = 0;
                    }
                }
                else
                {
                    character.Z += movement;
                }
            }
            else
            {
                if (character.B + movement >= hyperMatrix.GetLength(3)
                || character.B + movement < 0)
                {
                    if (character.B + movement >= hyperMatrix.GetLength(3))
                    {
                        character.B = hyperMatrix.GetLength(3) - 1;
                    }
                    else
                    {
                        character.B = 0;
                    }
                }
                else
                {
                    character.B += movement;
                }
            }
        }
        public static Basilisk MoveBasil(string command)
        {
            string[] splittedCommand = command.Split(' ');
            string subject = splittedCommand[0];
            string dimention = splittedCommand[1];
            int movement = int.Parse(splittedCommand[2]);

            int basiliksIndex = GetBasilIndex(subject);
            Basilisk currentBasil = Basiliks[basiliksIndex];

            hyperMatrix[currentBasil.X, currentBasil.Y, currentBasil.Z, currentBasil.B] -= 1;

            if (dimention == "A")
            {
                if (currentBasil.X + movement >= hyperMatrix.GetLength(0)
                || currentBasil.X + movement < 0)
                {
                    if (currentBasil.X + movement >= hyperMatrix.GetLength(0))
                    {
                        currentBasil.X = hyperMatrix.GetLength(0) - 1;
                    }
                    else
                    {
                        currentBasil.X = 0;
                    }
                }
                else
                {
                    currentBasil.X += movement;
                }
            }
            else if (dimention == "B")
            {
                if (currentBasil.Y + movement >= hyperMatrix.GetLength(1)
                || currentBasil.Y + movement < 0)
                {
                    if (currentBasil.Y + movement >= hyperMatrix.GetLength(1))
                    {
                        currentBasil.Y = hyperMatrix.GetLength(1) - 1;
                    }
                    else
                    {
                        currentBasil.Y = 0;
                    }
                }
                else
                {
                    currentBasil.Y += movement;
                }
            }
            else if (dimention == "C")
            {
                if (currentBasil.Z + movement >= hyperMatrix.GetLength(2)
                || currentBasil.Z + movement < 0)
                {
                    if (currentBasil.Z + movement >= hyperMatrix.GetLength(2))
                    {
                        currentBasil.Z = hyperMatrix.GetLength(2) - 1;
                    }
                    else
                    {
                        currentBasil.Z = 0;
                    }
                }
                else
                {
                    currentBasil.Z += movement;
                }
            }
            else
            {
                if (currentBasil.B + movement >= hyperMatrix.GetLength(3)
                || currentBasil.B + movement < 0)
                {
                    if (currentBasil.B + movement >= hyperMatrix.GetLength(3))
                    {
                        currentBasil.B = hyperMatrix.GetLength(3) - 1;
                    }
                    else
                    {
                        currentBasil.B = 0;
                    }
                }
                else
                {
                    currentBasil.B += movement;
                }
            }

            hyperMatrix[currentBasil.X, currentBasil.Y, currentBasil.Z, currentBasil.B] += 1;
            Basiliks[basiliksIndex].X = currentBasil.X;
            Basiliks[basiliksIndex].Y = currentBasil.Y;
            Basiliks[basiliksIndex].Z = currentBasil.Z;
            Basiliks[basiliksIndex].B = currentBasil.B;

            return currentBasil;
        }
        public static char GetKiller()
        {
            char kille = '-';

            List<Basilisk> theOnes = Basiliks.Where(x => x.X == character.X
            && x.Y == character.Y
            && x.Z == character.Z
            && x.B == character.B).OrderBy(x => x.Name).ToList();
            if (theOnes.Count > 0)
            {
                kille = theOnes[0].Name.ToCharArray()[0];
            }

            return kille;
        }

        public static int GetBasilIndex(string name)
        {
            int index = Basiliks.Where(x => x.Name == name).ToArray()[0].Index;
            return index;
        }

        public static bool CheckForHarry(int x, int y, int z, int b)
        {
            return character.X == x &&
                   character.Y == y &&
                   character.Z == z &&
                   character.B == b;
        }
    }


    public class Basilisk
    {

        public int X;
        public int Y;
        public int Z;
        public int B;
        public int Index;
        public string Name;

        public Basilisk(string name, int x, int y, int z, int b, int index)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.B = b;
            this.Index = index;
        }
    }
}
