using Hexagonal.DesignPatterns.Factory.Interfaces;

namespace Hexagonal.DesignPatterns.Factory.Entities
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
