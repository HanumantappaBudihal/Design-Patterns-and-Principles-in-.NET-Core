using Hexagonal.DesignPatterns.AbstractFactory.Interfaces;

namespace Hexagonal.DesignPatterns.AbstractFactory.Entities
{
    internal class Shark : IAnimal
    {
        public string Speak()
        {
            return "Cannot Speak";
        }
    }
}
