using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_II
{
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int total_gas);
    }
}
