using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.SOLIDPrinciples.LiskovSubstitution.WithLiskovSubstitution
{
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
}
