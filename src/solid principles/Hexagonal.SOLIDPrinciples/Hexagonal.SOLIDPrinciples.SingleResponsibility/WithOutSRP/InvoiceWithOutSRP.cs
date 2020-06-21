using System;
using System.Net.Mail;

namespace Hexagonal.SOLIDPrinciples.SingleResponsibility.WithOutSRP
{
    /// <summary>
    /// we are going to create an Invoice class with four functionalities such as 
    /// Adding and Deleting Invoices, Error Logging as well as Sending Emails. As
    /// we are putting all the above four functionalities into a single class or
    /// module, we are violating the Single Responsibility Principle. 
    /// This is because Sending Email and Error Logging is not a part of the Invoice module. 
    /// </summary>
    public class InvoiceWithOutSRP
    {
        public long InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }

        public void AddInvoice()
        {
            try
            {
                // Here we need to write the Code for adding invoice
                // Once the Invoice has been added, then send the  mail
                MailMessage mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
                this.SendInvoiceEmail(mailMessage);
            }
            catch (Exception exception)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", exception.ToString());
            }
        }

        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
            }
            catch (Exception exception)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", exception.ToString());
            }
        }

        //This method should be in this class, class name say that it Invocice but wew define the 
        //sending a mail in the same , so this class is responsible for Invoice calculation , Error Log and Sending a mail
        //SRP is not followed 
       
        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {
                // Here we need to write the Code for Email setting and sending the invoice mail
            }
            catch (Exception exception)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", exception.ToString());
            }
        }

    }
}
