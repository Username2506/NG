using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine("Refuel car with benzine and start movement");
            car.setFuel(1000);
            car.setStrategy(new BenzineStrategy());
            car.startMovement();

            Console.WriteLine("\nRun out of benzine, start using gas");
            car.setFuel(1000);
            car.setStrategy(new GasStrategy());
            car.startMovement();

            Console.WriteLine("\nWe finally arrived");
        }
    }
}
