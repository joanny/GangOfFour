using System;

namespace GangOfFour.AbstractFactory
{
    /// <summary>
    /// MainApp startup class for Real-World
    /// Abstract Factory Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            // Abstract
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld africaAnimals = new AnimalWorld(africa);
            africaAnimals.RunFoodChain();

            // Abstract
            ContinentFactory america = new AmericaFactory();
            AnimalWorld americanAnimals = new AnimalWorld(america);
            americanAnimals.RunFoodChain();

            Console.ReadKey();
        }
    }
}