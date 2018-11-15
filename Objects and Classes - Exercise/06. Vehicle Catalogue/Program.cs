using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        public class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double HorsePower { get; set; }

        }
        static void Main(string[] args)
        {
            List<Vehicle> vehiclesCatalogue = new List<Vehicle>();

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                var type = input[0];
                var model = input[1];
                var color = input[2];
                var horsePower = double.Parse(input[3]);

                var vehicle = new Vehicle()
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    HorsePower = horsePower
                };

                vehiclesCatalogue.Add(vehicle);
            }

            while (true)
            {
                var model = Console.ReadLine();
                if (model == "Close the Catalogue")
                {
                    break;
                }

                foreach (var vehicle in vehiclesCatalogue.Where(x=>x.Model==model))
                {
                    if (vehicle.Type == "car")
                    {
                        Console.WriteLine("Type: Car");
                    }
                    else
                    {
                        Console.WriteLine("Type: Truck");
                    }

                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                }
            }
            if (vehiclesCatalogue.Where(x=>x.Type=="car").Count()==0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
                
            }
            else
            {
                double carsAvarageHorsePower = vehiclesCatalogue.Where(x => x.Type == "car").Average(x => x.HorsePower);
                Console.WriteLine($"Cars have average horsepower of: {carsAvarageHorsePower:F2}.");
            }
            if (vehiclesCatalogue.Where(x => x.Type == "truck").Count()== 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
                
            }
            else
            {
                double trucksAvarageHorsePower = vehiclesCatalogue.Where(x => x.Type == "truck").Average(x => x.HorsePower);
                Console.WriteLine($"Trucks have average horsepower of: {trucksAvarageHorsePower:F2}.");
            }
        }
    }
}
