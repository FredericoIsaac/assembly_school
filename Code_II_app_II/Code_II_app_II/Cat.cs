using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_II_app_II
{
    internal class Cat: IAnimal
    {
        public void Talk()
        {
            Console.WriteLine("Miauuu");
        }
    }
}
