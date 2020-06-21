using Hexagonal.SOLIDPrinciples.SingleResponsibility.WithSRP.Interfaces;
using System;

namespace Hexagonal.SOLIDPrinciples.SingleResponsibility.WithSRP
{
    public class Logger : ILogger
    {
        //we should still seperate into two interface here.
        //as Business entiry and Controller part
        //We will cover how to divide those classes further and why?
        //inorder to undestand the concept easily and better ,I kept the both
        //Enitity and functions are in single interface
        public Logger()
        {
            // here we need to write the Code for initialization 
            // that is Creating the Log file with necesssary details
        }

        public void Debug(string information)
        {
            // here we need to write the Code for info information into the ErrorLog text file
        }

        public void Error(string message, Exception exception)
        {
            // here we need to write the Code for info information into the ErrorLog text file
        }

        public void Information(string information)
        {
            // here we need to write the Code for info information into the ErrorLog text file
        }
    }
}
