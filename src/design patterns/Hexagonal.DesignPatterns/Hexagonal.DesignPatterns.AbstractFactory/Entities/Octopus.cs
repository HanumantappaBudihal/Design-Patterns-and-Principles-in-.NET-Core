using Hexagonal.DesignPatterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.DesignPatterns.AbstractFactory.Entities
{
    internal class Octopus : IAnimal
    {
        public string Speak()
        {
            return "SQUAWCK";
        }
    }
}
