using Hexagonal.DesignPatterns.Factory.Interfaces;

namespace Hexagonal.DesignPatterns.Factory.Entities
{
    public class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 450;
        }

        public string GetCardType()
        {
            return "Platinum Card";
        }

        public int GetCreditLimit()
        {
            return 450000;
        }
    }
}
