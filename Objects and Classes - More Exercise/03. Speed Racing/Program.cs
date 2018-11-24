using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionFor1km { get; set; }
        public double DistanceTraveled { get; set; } = 0;

        public  void Travel(double km)
        {
            if (km*FuelConsumptionFor1km>FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                DistanceTraveled += km;
                FuelAmount -= km * FuelConsumptionFor1km;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int lineCount = int.Parse(Console.ReadLine());
            Dictionary<string, Car> carList = new Dictionary<string, Car>();

            for (int i = 0; i < lineCount; i++)
            {
                var line = Console.ReadLine().Split();
                string model = line[0];
                double fuel = double.Parse(line[1]);
                double consumption = double.Parse(line[2]);

                Car car = new Car()
                {
                    Model = model,
                    FuelAmount = fuel,
                    FuelConsumptionFor1km = consumption
                };

                carList.Add(model, car);
            }

            while (true)
            {
                var line = Console.ReadLine().Split();
                if (line[0]=="End")
                {
                    break;
                }
                string model = line[1];
                double km = double.Parse(line[2]);

                carList[model].Travel(km);
            }
            foreach (var car in carList.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
            }
        }

       
    }
}
