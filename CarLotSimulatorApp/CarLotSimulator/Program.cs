using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            CarLot ourCars = new CarLot();

            Console.WriteLine("Here we have our first car!\n");
            Car car1 = new Car();
            ourCars.CarList.Add(car1);
            CarLot.numberOfCars++;
            
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            CarLot.displayCarCount(CarLot.numberOfCars);

            Console.WriteLine("\nHere we have our second car!\n");
            Car car2 = new Car()
            {
                Year = 2003,
                Make = "Toyota",
                Model = "Corolla",
                EngineNoise = "frtrttrtz",
                HonkNoise = "HOnkk",
                IsDriveable = false
            };
            ourCars.CarList.Add(car2);
            CarLot.numberOfCars++;

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            CarLot.displayCarCount(CarLot.numberOfCars);

            Console.WriteLine("\nHere we have our third car!\n");
            Car car3 = new Car(2750, "BeedZorp X", "Throwback", "*silence*", "EEEEEEEEEE", true);
            ourCars.CarList.Add(car3);
            CarLot.numberOfCars++;

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            CarLot.displayCarCount(CarLot.numberOfCars);


            Console.WriteLine("\nOur list of cars reads as follows:\n");
            foreach(Car car in ourCars.CarList)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
