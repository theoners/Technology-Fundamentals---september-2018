using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Car> carsCatologue = new List<Car>();
            List<Truck> trucksCatologue = new List<Truck>();

            while (true)
            {
                var input = Console.ReadLine().Split('/');
                if (input[0]=="end")
                {
                    break;
                }
                string brand = input[1];
                string model = input[2];
                double weightOrHorsePower = double.Parse(input[3]);

                if (input[0] == "Car")
                {
                    var car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = weightOrHorsePower
                    };

                    carsCatologue.Add(car);
                }
                else
                {
                    var truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weightOrHorsePower
                    };

                    trucksCatologue.Add(truck);
                }
            }

            if (carsCatologue.Count>0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in carsCatologue.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (trucksCatologue.Count>0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in trucksCatologue.OrderBy(x=>x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
           
            
        }
    }
}
