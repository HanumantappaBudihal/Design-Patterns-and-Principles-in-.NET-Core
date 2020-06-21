using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.SOLIDPrinciples.SingleResponsibility.WithSRP.Interfaces
{
    public interface IInvoice
    {
        //we should still seperate into two interface here.
        //as Business entity and Controller part
        //We will cover how to divide those classes further and why?
        //To undestand the concept easily and better ,I kept the both class member in a same class
        //Entity and functions are in single interface

        long InvoiceAmount { get; set; }
        DateTime InvoiceDate { get; set; }
        void AddInvoice();
        void DeleteInvoice();
    }
}
