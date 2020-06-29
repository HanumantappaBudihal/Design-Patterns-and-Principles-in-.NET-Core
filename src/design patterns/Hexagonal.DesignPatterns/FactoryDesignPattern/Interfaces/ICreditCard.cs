using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.DesignPatterns.Factory.Interfaces
{
    public interface ICreditCard
    {
        /// <summary>
        /// Get the credit card type
        /// </summary>
        /// <returns></returns>
        string GetCardType();

        /// <summary>
        /// Get the credit card limit
        /// </summary>
        /// <returns></returns>
        int GetCreditLimit();

        /// <summary>
        /// Get the annualCharge for the card 
        /// </summary>
        /// <returns></returns>
        int GetAnnualCharge();
    }
}
