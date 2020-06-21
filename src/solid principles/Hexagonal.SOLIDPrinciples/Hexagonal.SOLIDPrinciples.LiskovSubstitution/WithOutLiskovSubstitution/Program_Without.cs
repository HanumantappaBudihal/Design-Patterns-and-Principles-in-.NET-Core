using Hexagonal.SOLIDPrinciples.LiskovSubstitution.WithLiskovSubstitution;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.SOLIDPrinciples.LiskovSubstitution.WithOutLiskovSubstitution
{
    public class Program_Without
    {
        /// <summary>
        /// Let us first understand one example without using the Liskov Substitution Principle in C#.
        /// In the following example, first, we create the Apple class with the method GetColor. 
        /// Then we create the Orange class which inherits the Apple class as well 
        /// as overrides the GetColor method of the Apple class. 
        /// The point is that an Orange cannot be replaced by an Apple,
        /// which results in printing the color of apple as Orange as shown in the below example.
        /// </summary>
        /// <param name="args"></param>
        static void Main_WithoutLiskov(string[] args)
        {
            //Without Liskov Substitution principle
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());

           //out put will be "Orange" 
           // The point is that an Orange cannot be replaced by an Apple,
           //which results in printing the color of apple as Orange as shown in the below example.
           //check implementation with Liskov substitution
        }
    }
}
