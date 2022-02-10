using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace OOP.ConsoleE
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type the animal");

                String animalType = Console.ReadLine().ToLower();

                Animal animal = null;

                switch (animalType)
                {
                    case "dog":
                        animal = new Dog();
                        break;

                    case "cat":
                        animal = new Cat();
                        break;

                    case "lion":
                        animal = new Lion();
                        break;

                    case "elephant":
                        animal = new Elephant();
                        break;

                    case "cow":
                        animal = new Cow();
                        break;

                    case "pig":
                        animal = new Pig();
                        break;

                    default:
                        Console.WriteLine("Animal not found");
                        break;
                }

                if (animal != null)
                {
                    animal.AnimalSound();
                }
            }

            

            Console.ReadKey();

        }
    }
}
