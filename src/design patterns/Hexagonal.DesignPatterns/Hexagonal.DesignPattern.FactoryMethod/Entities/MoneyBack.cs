using Hexagonal.DesignPatterns.FactoryMethod.Interfaces;

namespace Hexagonal.DesignPatterns.FactoryMethod.Entities
{
    public class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 300;
        }

        public string GetCardType()
        {
            return "Money Bank";
        }

        public int GetCreditLimit()
        {
            return 500000;
        }
    }
}
