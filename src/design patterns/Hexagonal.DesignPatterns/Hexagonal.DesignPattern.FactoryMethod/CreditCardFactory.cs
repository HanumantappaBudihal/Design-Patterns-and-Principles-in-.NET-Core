using Hexagonal.DesignPatterns.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.DesignPatterns.FactoryMethod
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();

        public ICreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
