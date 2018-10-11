using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string line = Console.ReadLine();
            int[] field = new int[fieldSize];

            for (int i = 0; i < ladybugs.Length; i++)
            {
                if (ladybugs[i] >= 0 && ladybugs[i] <= fieldSize - 1)
                {
                    field[ladybugs[i]] = 1;
                }
            }

            while (line!="end")
            {
                

                string[] command = line.Split();

                int ladybugPosition = int.Parse(command[0]);
                string ladybugFlyDirection = command[1];
                int flyIndex = int.Parse(command[2]);


                if (ladybugPosition>=0 && ladybugPosition<=fieldSize-1)
                {
                    if (field[ladybugPosition]==1 && flyIndex != 0)
                    {
                        field[ladybugPosition] = 0;
                        if (ladybugFlyDirection=="right")
                        {
                            int ladybugNewPosition = ladybugPosition + flyIndex;
                            while (ladybugNewPosition>=0 && ladybugNewPosition<=fieldSize-1)
                            {
                                
                                    if (field[ladybugNewPosition] == 0)
                                    {
                                        field[ladybugNewPosition] = 1;
                                        break;
                                    }
                                    else
                                    {
                                        ladybugNewPosition += flyIndex;
                                    }
                                
                            }
                        }
                        else if (ladybugFlyDirection == "left")
                        {
                            int ladybugNewPosition = ladybugPosition - flyIndex;
                            while (ladybugNewPosition >= 0 && ladybugNewPosition <= fieldSize - 1)
                            {
                                if (ladybugNewPosition <= fieldSize - 1)
                                {
                                    if (field[ladybugNewPosition] == 0)
                                    {
                                        field[ladybugNewPosition] = 1;
                                    }
                                    else
                                    {
                                        ladybugNewPosition -= flyIndex;
                                    }
                                }
                            }
                        }
                    }
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",field));
        }
    }
}
