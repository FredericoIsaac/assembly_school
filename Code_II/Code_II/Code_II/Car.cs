using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_II
{
    internal class Car: IVehicle
    {
        public int startGas { get; set; }
        public bool Refuel(int gas)
        {
            startGas += gas;
            return true;
        }


        public void Drive()
        {
            if (startGas > 0)
            {
                Console.WriteLine("The car is Driving");
            }
        }
    }
}
