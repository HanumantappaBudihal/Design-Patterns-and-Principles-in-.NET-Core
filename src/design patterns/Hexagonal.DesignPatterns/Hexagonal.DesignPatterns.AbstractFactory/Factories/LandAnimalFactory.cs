using Hexagonal.DesignPatterns.AbstractFactory.Entities;
using Hexagonal.DesignPatterns.AbstractFactory.Enums;
using Hexagonal.DesignPatterns.AbstractFactory.Interfaces;

namespace Hexagonal.DesignPatterns.AbstractFactory.Factories
{
    internal class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(Animal animal)
        {
            switch (animal)
            {
                case Animal.Dog:
                    return new Dog();
                case Animal.Cat:
                    return new Cat();
                case Animal.Lion:
                    return new Lion();
                default:
                    return null;
            }
        }
    }
}