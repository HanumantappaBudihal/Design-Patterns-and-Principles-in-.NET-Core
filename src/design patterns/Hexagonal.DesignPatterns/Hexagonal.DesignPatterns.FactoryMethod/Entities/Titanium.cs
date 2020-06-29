using Hexagonal.DesignPatterns.FactoryMethod.Interfaces;

namespace Hexagonal.DesignPatterns.FactoryMethod.Entities
{
    public class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 400;
        }

        public string GetCardType()
        {
            return "Titanium Card";
        }

        public int GetCreditLimit()
        {
            return 100000;
        }
    }
}
