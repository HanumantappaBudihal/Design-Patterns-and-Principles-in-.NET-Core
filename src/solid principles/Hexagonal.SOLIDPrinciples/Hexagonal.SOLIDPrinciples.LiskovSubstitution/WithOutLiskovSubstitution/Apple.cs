using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.SOLIDPrinciples.LiskovSubstitution.WithOutLiskovSubstitution
{
    public class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
}
