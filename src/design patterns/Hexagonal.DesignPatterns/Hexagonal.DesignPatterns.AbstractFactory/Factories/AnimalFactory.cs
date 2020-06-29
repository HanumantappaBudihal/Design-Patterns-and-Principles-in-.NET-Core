using Hexagonal.DesignPatterns.AbstractFactory.Enums;
using Hexagonal.DesignPatterns.AbstractFactory.Interfaces;

namespace Hexagonal.DesignPatterns.AbstractFactory.Factories
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(Animal animal);

        public static AnimalFactory CreateAnimalFactory(AnimalType animalType)
        {
            switch (animalType)
            {
                case AnimalType.Land:
                    return new LandAnimalFactory();
                case AnimalType.Sea:
                    return new SeaAnimalFactory();
                default:
                    return null;
            }
        }
    }
}
