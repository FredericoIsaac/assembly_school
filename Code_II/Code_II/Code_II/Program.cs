using System;

namespace Code_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car = new Car();
            car.startGas = 0;
            while (true)
            {
                Console.WriteLine("What is the amount of gasoline to refuel?");
                string gasString = Console.ReadLine();
                int gas;
                if (int.TryParse(gasString, out gas))
                {
                    car.Refuel(gas);
                    break;
                }
                else
                {
                    Console.WriteLine("Please insert a valid value");
                }
            }
            car.Drive();
        }
    }
}
