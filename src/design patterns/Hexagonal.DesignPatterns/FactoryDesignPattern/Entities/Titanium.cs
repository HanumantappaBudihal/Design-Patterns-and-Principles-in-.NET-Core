using Hexagonal.DesignPatterns.Factory.Interfaces;

namespace Hexagonal.DesignPatterns.Factory.Entities
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
