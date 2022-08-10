using System;

namespace Code_II_app_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal[] animals = { new Dog(), new Cat(), new Dunky(), new Cow(), new Duck() };
            while (true)
            {
                Console.WriteLine("Let's see what is the sound of the animal?");
                Console.WriteLine("Choose one by the number:");
                Console.WriteLine("1 - Dog\n2 - Cat\n3 - Dunky\n4 - Cow\n5 - Duck");
                string choosedAnimal = Console.ReadLine();
                int animal;
                if (int.TryParse(choosedAnimal, out animal) && animal > 0 && animal <= 5)
                {
                    animals[animal - 1].Talk();
                    break;
                }
                else
                {
                    Console.WriteLine("Please insert a corret value (1 to 5)");
                }
            }

        }
    }
}
