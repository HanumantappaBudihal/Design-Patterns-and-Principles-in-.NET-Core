using Hexagonal.DesignPatterns.Factory.Entities;
using Hexagonal.DesignPatterns.Factory.enums;
using Hexagonal.DesignPatterns.Factory.Interfaces;

namespace Hexagonal.DesignPatterns.Factory
{
    public static class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(CreditCardType creditCardType)
        {
            ICreditCard creditCard = null;

            switch (creditCardType)
            {
                case CreditCardType.MoneyBank:
                    creditCard = new MoneyBack();
                    break;
                case CreditCardType.Titanium:
                    creditCard = new Titanium();
                    break;
                case CreditCardType.Platinum:
                    creditCard = new Platinum();
                    break;
                default:
                    creditCard = null;
                    break;
            }
            return creditCard;
        }
    }
}
