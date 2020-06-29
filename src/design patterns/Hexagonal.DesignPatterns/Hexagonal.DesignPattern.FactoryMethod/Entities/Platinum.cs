using Hexagonal.DesignPatterns.FactoryMethod.Interfaces;

namespace HHexagonal.DesignPatterns.FactoryMethod.Entities
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
