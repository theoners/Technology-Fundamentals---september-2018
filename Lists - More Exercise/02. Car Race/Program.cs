using System;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] raceRoad = Console.ReadLine().Split().Select(int.Parse).ToArray();

            double leftRacerTime = 0;
            double rightRacerTime = 0;

            for (int i = 0; i < raceRoad.Length/2; i++)
            {
                if (raceRoad[i]!=0)
                {
                    leftRacerTime += raceRoad[i];
                }
                else
                {
                    leftRacerTime *= 0.8;
                }
            }

            for (int i = raceRoad.Length - 1; i > raceRoad.Length/2; i--)
            {
                if (raceRoad[i]!= 0)
                {
                    rightRacerTime += raceRoad[i];
                }
                else
                {
                    rightRacerTime *= 0.8;
                }
            }

            if (rightRacerTime>leftRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacerTime}");
            }
            else if (rightRacerTime < leftRacerTime)
            {
                Console.WriteLine($"The winner is right with total time: {rightRacerTime}");
            }
                
        }
    }
}
