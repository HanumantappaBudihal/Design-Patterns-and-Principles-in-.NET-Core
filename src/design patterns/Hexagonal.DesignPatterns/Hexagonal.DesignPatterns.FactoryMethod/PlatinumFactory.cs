using Hexagonal.DesignPatterns.FactoryMethod.Interfaces;
using HHexagonal.DesignPatterns.FactoryMethod.Entities;

namespace Hexagonal.DesignPatterns.FactoryMethod
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard creditCard = new Platinum();
            return creditCard;
        }
    }
}
