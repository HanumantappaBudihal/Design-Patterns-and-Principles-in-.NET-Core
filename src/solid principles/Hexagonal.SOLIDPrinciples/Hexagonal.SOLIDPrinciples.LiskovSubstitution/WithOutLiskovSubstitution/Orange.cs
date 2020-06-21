using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.SOLIDPrinciples.LiskovSubstitution.WithOutLiskovSubstitution
{
    public class Orange : Apple
    {        
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
