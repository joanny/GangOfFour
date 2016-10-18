
namespace GangOfFour.AbstractFactory
{
    /// <summary>
    /// The 'ContinentFactory' class
    /// </summary>
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
