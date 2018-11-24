using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public Car(string model, Engine engine, Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
        }
    }
    class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

        public Engine(int speed, int power)
        {
            EngineSpeed = speed;
            EnginePower = power;
        }
    }
    class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }

        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();
            int lineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < lineCount; i++)
            {
                var line = Console.ReadLine().Split();
                string model = line[0];
                int engineSpeed = int.Parse(line[1]);
                int enginePower = int.Parse(line[2]);
                int cargoWeight = int.Parse(line[3]);
                string cargoType = line[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(model, engine, cargo);

                carList.Add(car);
            }

            string sortCargoType = Console.ReadLine();
            if (sortCargoType=="fragile")
            {
                foreach (Car car in carList)
                {
                    if (car.Cargo.Weight<1000&&car.Cargo.Type==sortCargoType)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else
            {
                foreach (Car car in carList)
                {
                    if (car.Engine.EnginePower > 250 && car.Cargo.Type == sortCargoType)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }

            
    }
}
