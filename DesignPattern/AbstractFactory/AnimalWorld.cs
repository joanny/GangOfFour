
namespace GangOfFour.AbstractFactory
{
    /// <summary>
    /// The 'AnimalWorld' class
    /// </summary>
    public class AnimalWorld
    {
        private Herbivore _abstractHerbivore;
        private Carnivore _abstractCarnivore;

        //constructor
        public AnimalWorld(ContinentFactory factory)
        {
            _abstractHerbivore = factory.CreateHerbivore();
            _abstractCarnivore = factory.CreateCarnivore();
        }
        public void RunFoodChain()
        {
            _abstractCarnivore.Eat(_abstractHerbivore);
        }
    }
}
