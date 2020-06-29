using Hexagonal.DesignPatterns.Factory.Entities;
using Hexagonal.DesignPatterns.Factory.Interfaces;

namespace Hexagonal.DesignPatterns.Factory
{
    public static class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string creditCardType)
        {
            ICreditCard creditCard = null;

            switch (creditCardType)
            {
                case "MoneyBack":
                    creditCard = new MoneyBack();
                    break;
                case "Titanium":
                    creditCard = new Titanium();
                    break;
                case "Platinum":
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
