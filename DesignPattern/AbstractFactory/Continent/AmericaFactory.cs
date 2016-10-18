
namespace GangOfFour.AbstractFactory
{
    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Antilope();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}