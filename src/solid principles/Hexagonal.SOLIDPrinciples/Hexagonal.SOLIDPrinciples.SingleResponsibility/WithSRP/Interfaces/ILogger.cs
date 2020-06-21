using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.SOLIDPrinciples.SingleResponsibility.WithSRP.Interfaces
{
    public interface ILogger
    {
        void Information(string information);
        void Debug(string information);
        void Error(string message, Exception exception);
    }
}
