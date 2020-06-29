using Hexagonal.DesignPatterns.AbstractFactory.Interfaces;

namespace Hexagonal.DesignPatterns.AbstractFactory.Entities
{
    internal class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow Meow Meow";
        }
    }
}
