using Hexagonal.SOLIDPrinciples.SingleResponsibility.WithSRP.Interfaces;

namespace Hexagonal.SOLIDPrinciples.SingleResponsibility.WithSRP
{
    internal class MailSender : IMailSender
    {
        //we should still seperate into two interface here.
        //as Business entity and Controller part
        //We will cover how to divide those classes further and why?
        //inorder to undestand the concept easily and better ,I kept the both
        //Entity and functions are in single interface

        private string _emailFrom;
        public string EMailFrom
        {
            get { return _emailFrom; }
            set { _emailFrom = value; }
        }

        private string _emailTo;
        public string EMailTo
        {
            get { return _emailTo; }
            set { _emailTo = value; }
        }

        private string _emailSubject;
        public string EMailSubject
        {
            get { return _emailSubject; }
            set { _emailSubject = value; }
        }

        private string _emailBody;
        public string EMailBody
        {
            get { return _emailBody; }
            set { _emailBody = value; }
        }

        public void SendEmail()
        {
            // Here we need to write the Code for sending the mail
        }
    }
}
