using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstDistance = FindDistanceBetweenTwoPoints(x1,y1,x2,y2);
            double secondDistance = FindDistanceBetweenTwoPoints(x3,y3,x4,y4);

            if (firstDistance>=secondDistance)
            {
               double firstPointDistance = FindDistanceFromCenter(x1,y1);
               double secondPointDistance = FindDistanceFromCenter(x2,y2);

                if (firstPointDistance<=secondPointDistance)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                double firstPointDistance = FindDistanceFromCenter(x3, y3);
                double secondPointDistance = FindDistanceFromCenter(x4, y4);

                if (firstPointDistance <= secondPointDistance)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        private static double FindDistanceFromCenter(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(Math.Abs(x), 2) + Math.Pow(Math.Abs(y), 2));

            return distance;
        }

        private static double FindDistanceBetweenTwoPoints(double x, double y,double x1, double y1)
        {
            double distance = Math.Sqrt(Math.Abs(x - x1) * Math.Abs(x - x1) + Math.Abs(y - y1) * Math.Abs(y - y1));

            return distance;
        }
    }
}
