using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupOfPeople = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double priceForPerson = 0;
            double totalPrice=0;

            if (typeOfTheGroup=="Students")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        priceForPerson = 8.45;
                        break;
                    case "Saturday":
                        priceForPerson = 9.80;
                        break;
                    case "Sunday":
                        priceForPerson = 10.46;
                        break;
                }

                totalPrice = groupOfPeople * priceForPerson;
                if (groupOfPeople>=30)
                {
                    totalPrice = totalPrice * 0.85;
                }
            }
            else if (typeOfTheGroup== "Business")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        priceForPerson = 10.90;
                        break;
                    case "Saturday":
                        priceForPerson = 15.60;
                        break;
                    case "Sunday":
                        priceForPerson = 16;
                        break;
                }
                totalPrice = groupOfPeople * priceForPerson;
                if (groupOfPeople >= 100)
                {
                    totalPrice = (groupOfPeople-10) * priceForPerson;
                }
            }
            else if (typeOfTheGroup == "Regular")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        priceForPerson = 15;
                        break;
                    case "Saturday":
                        priceForPerson = 20;
                        break;
                    case "Sunday":
                        priceForPerson = 22.50;
                        break;
                }
                totalPrice = groupOfPeople * priceForPerson;
                if (groupOfPeople >= 10 && groupOfPeople<=20)
                {
                    totalPrice = totalPrice*0.95;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
