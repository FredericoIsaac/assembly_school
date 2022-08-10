using System;
using System.Collections.Generic;

namespace Code_II_app_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            while (true)
            {
                Console.WriteLine("Do you want to insert a new vehicle? To exit press 0");
                string isInsert = Console.ReadLine();
                if (isInsert == "0")
                {
                    break;
                }

                Console.WriteLine("Number of wheels?");
                string wheels = Console.ReadLine();
                int numberWheels;
                if (!int.TryParse(wheels, out numberWheels))
                {
                    Console.WriteLine("Wrong input, please insert a correct number.\nGetting back to menu");
                    Console.Clear();
                    continue;
                }
                Console.WriteLine("Model?");
                string model = Console.ReadLine();
                Console.WriteLine("Insert the id of the vehicle");
                string id = Console.ReadLine();
                int idVehicle;

                if (!int.TryParse(id, out idVehicle))
                {
                    Console.WriteLine("Wrong input, please insert a correct number.\nGetting back to menu");
                    Console.Clear();
                    continue;
                }

                
                Vehicle newVehicle = new Vehicle { 
                    model = model,
                    numberWheels = numberWheels,
                    vehicleId = idVehicle,
                };

                vehicles.Add(newVehicle);
            }

            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.ViewCharacteristics();
            }
            
        }

    }
}
