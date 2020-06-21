using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.SOLIDPrinciples.LiskovSubstitution.WithLiskovSubstitution
{
    /// <summary>
    /// Let’s modify the previous example to follow the Liskov Substitution Principle.
    /// Here, first, we need a generic base class such as Fruit for both Apple and Orange.
    /// Now you can replace the Fruit class object with its subtypes either Apple
    /// and Orage and it will behave correctly.
    /// </summary>
    /// <returns></returns>
    public class Program
    {
        //Change
        static void Main(string[] args)
        {
            //With Liskov Substitution
            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
        }
    }
}
