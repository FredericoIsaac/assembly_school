using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_II_app_III
{
    public interface IVehicle
    {
        public int numberWheels { get; set; }
        public string model { get; set; }
        public int vehicleId { get; set; }

        int Characteristics(int wheels, string modelVehicle, int id);
        void ViewCharacteristics();
    }
}
