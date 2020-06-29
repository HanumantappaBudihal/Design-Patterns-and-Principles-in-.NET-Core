using Hexagonal.DesignPatterns.Factory.Interfaces;
using System;

namespace Hexagonal.DesignPatterns.Factory
{
    /// <summary>
    /// This project is created to demonstrate the Factory design pattern (Creational Design pattern)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Factory Design , This factory desing pattern implementation");
            ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

            if(cardDetails !=null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }

            Console.ReadLine();
        }
    }
}
