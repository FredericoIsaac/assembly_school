using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_II_app_III
{
    public class Vehicle: IVehicle
    {
        public int numberWheels { get; set; }
        public string model { get; set; }
        public int vehicleId { get; set; }

        public int Characteristics(int wheels, string modelVehicle, int id)
        {
            numberWheels = wheels;
            model = modelVehicle;
            vehicleId = id;
            return vehicleId;
        }

        public void ViewCharacteristics()
        {
            Console.WriteLine($"Number of wheels: {numberWheels}\nModel: {model}");
        }
    }
}
