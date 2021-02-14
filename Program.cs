using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} 
                //{tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"

                string currModel = input[0];
                int currSpeed = int.Parse(input[1]);
                int currPower = int.Parse(input[2]);
                int currWeight = int.Parse(input[3]);
                string currType = input[4];

                Tire[] currTires = new Tire[4]
                {
                    new Tire (double.Parse(input[5]), int.Parse(input[6])),
                    new Tire (double.Parse(input[7]), int.Parse(input[8])),
                    new Tire (double.Parse(input[9]), int.Parse(input[10])),
                     new Tire (double.Parse(input[11]), int.Parse(input[12])),
                };

                Engine currEngine = new Engine(currSpeed, currPower);
                Cargo currCargo = new Cargo(currWeight, currType);

                //  public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
                Car currCar = new Car(currModel, currEngine, currCargo, currTires);
                cars.Add(currCar);
            }

            string inputSecond = Console.ReadLine();

            PrintCar(inputSecond, cars);

        }

        public static void PrintCar(string inputSecond, List<Car> cars)
        {
            foreach (var car in cars)
            {
                if (inputSecond == "fragile" && car.Tires.Any(x => x.TirePressure < 1)&& car.Cargo.Type== "fragile")
                {
                    Console.WriteLine($"{car.Model}");
                }
                else if (inputSecond == "flamable" && car.Cargo.Type== "flamable" && car.Engine.Power>250)
                {
                    Console.WriteLine($"{car.Model}");
                }


            }

        }


    }
}
