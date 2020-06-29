using Hexagonal.DesignPatterns.FactoryMethod.Entities;
using Hexagonal.DesignPatterns.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.DesignPatterns.FactoryMethod
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard creditCard = new MoneyBack();
            return creditCard;
        }
    }
}
