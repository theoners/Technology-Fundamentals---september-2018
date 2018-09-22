using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            double countOfStudents = double.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double totalPrice = priceOfLightsaber * (Math.Ceiling(countOfStudents * 1.1)) + priceOfRobe * countOfStudents +
                priceOfBelt * (countOfStudents - (Math.Floor(countOfStudents / 6)));

            if (totalPrice<=amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalPrice-amountOfMoney):F2}lv more.");
            }
        }
    }
}
