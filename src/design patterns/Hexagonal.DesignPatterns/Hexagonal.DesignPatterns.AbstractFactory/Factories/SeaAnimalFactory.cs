using Hexagonal.DesignPatterns.AbstractFactory.Entities;
using Hexagonal.DesignPatterns.AbstractFactory.Enums;
using Hexagonal.DesignPatterns.AbstractFactory.Interfaces;

namespace Hexagonal.DesignPatterns.AbstractFactory.Factories
{
    internal class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(Animal animal)
        {
            switch (animal)
            {
                case Animal.Shark:
                    return new Shark();
                case Animal.Octoups:
                    return new Octopus();
                default:
                    return null;              
            }
        }
    }
}