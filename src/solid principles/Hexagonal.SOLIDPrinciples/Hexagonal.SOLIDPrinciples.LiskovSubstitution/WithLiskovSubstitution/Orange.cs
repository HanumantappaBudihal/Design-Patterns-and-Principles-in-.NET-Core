using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.SOLIDPrinciples.LiskovSubstitution.WithLiskovSubstitution
{
    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
