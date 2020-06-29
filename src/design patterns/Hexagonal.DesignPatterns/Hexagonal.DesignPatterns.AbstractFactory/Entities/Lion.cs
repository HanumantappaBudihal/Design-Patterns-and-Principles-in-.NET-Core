using Hexagonal.DesignPatterns.AbstractFactory.Interfaces;
using System;

namespace Hexagonal.DesignPatterns.AbstractFactory.Entities
{
    internal class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
}
