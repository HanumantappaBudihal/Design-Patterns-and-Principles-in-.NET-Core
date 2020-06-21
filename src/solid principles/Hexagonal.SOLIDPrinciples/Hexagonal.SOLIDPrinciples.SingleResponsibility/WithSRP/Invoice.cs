using Hexagonal.SOLIDPrinciples.SingleResponsibility.WithSRP.Interfaces;
using System;

namespace Hexagonal.SOLIDPrinciples.SingleResponsibility.WithSRP
{ 
    public class Invoice : IInvoice
    {
        //we should still seperate into two interface here.
        //as Business entity and Controller part
        //We will conver how to divide those classes further and why?
        //inorder to undestand the concept easily and better ,I kept the both
        //Entity and functions are in single interface

        private long _invoiceAmount;
        public long InvoiceAmount
        {
            get { return _invoiceAmount; }
            set { _invoiceAmount = value; }
        }

        private DateTime _invoiceDate;
        public DateTime InvoiceDate
        {
            get { return InvoiceDate; }
            set { InvoiceDate = value; }
        }

        private ILogger _fileLogger;
        private MailSender _emailSender;

        public Invoice()
        {
            _fileLogger = new Logger();
            _emailSender = new MailSender();
        }

        public void AddInvoice()
        {
            try
            {
                _fileLogger.Information("Add method Start");
                // Here we need to write the Code for adding invoice
                // Once the Invoice has been added, then send the  mail

                _emailSender.EMailFrom = "emailfrom@xyz.com";
                _emailSender.EMailTo = "emailto@xyz.com";
                _emailSender.EMailSubject = "Single Responsibility Princile";
                _emailSender.EMailBody = "A class should have only one reason to change";
                _emailSender.SendEmail();
            }
            catch (Exception exception)
            {
                _fileLogger.Error("Error Occurred while Generating Invoice", exception);
            }
        }

        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
                _fileLogger.Information("Delete Invoice Start at @" + DateTime.Now);
            }
            catch (Exception exception)
            {
                _fileLogger.Error("Error Occurred while Deleting Invoice", exception);
            }

        }
    }
}
