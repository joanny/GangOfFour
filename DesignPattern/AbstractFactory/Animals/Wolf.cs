using System;

namespace GangOfFour.AbstractFactory
{
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Antilope
            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
