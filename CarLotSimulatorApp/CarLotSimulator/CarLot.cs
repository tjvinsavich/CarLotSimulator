using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
            CarList = new List<Car>();
        }

        public List<Car> CarList { get; set; }

        public static int numberOfCars = 0;

        public static void displayCarCount (int numberOfCars)
        {
            Console.WriteLine($"\nWe now have {numberOfCars} car(s) in our lot!");
        }

    }
}
