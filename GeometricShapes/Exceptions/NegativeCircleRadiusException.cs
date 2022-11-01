using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes.Exceptions
{
    public class NegativeCircleRadiusException : Exception
    {
        public override string? StackTrace { get; }

        public NegativeCircleRadiusException() : base("Radius cannot be negative") { }

        public NegativeCircleRadiusException(string? message, string? stackTrace = null) : base(message) => StackTrace = stackTrace;
    }
}
