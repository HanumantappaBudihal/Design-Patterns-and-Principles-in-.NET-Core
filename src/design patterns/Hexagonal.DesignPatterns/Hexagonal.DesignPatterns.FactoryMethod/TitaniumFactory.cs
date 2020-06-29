using Hexagonal.DesignPatterns.FactoryMethod.Entities;
using Hexagonal.DesignPatterns.FactoryMethod.Interfaces;

namespace Hexagonal.DesignPatterns.FactoryMethod
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard creditCard = new Titanium();
            return creditCard;
        }
    }
}
