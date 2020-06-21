namespace Hexagonal.SOLIDPrinciples.SingleResponsibility.WithSRP.Interfaces
{
    public interface IMailSender
    {
        //we should still seperate into two interface here.
        //as Business entity and Controller part
        //We will cover how to divide those classes further and why?
        //inorder to undestand the concept easily and better ,I kept the both
        //Entity and functions are in single interface

        string EMailFrom { get; set; }
        string EMailTo { get; set; }
        string EMailSubject { get; set; }
        string EMailBody { get; set; }
        void SendEmail();
    }
}
