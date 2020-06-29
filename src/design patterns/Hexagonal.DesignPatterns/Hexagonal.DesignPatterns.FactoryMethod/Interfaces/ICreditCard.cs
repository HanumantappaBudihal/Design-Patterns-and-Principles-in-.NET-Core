using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.DesignPatterns.FactoryMethod.Interfaces
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
