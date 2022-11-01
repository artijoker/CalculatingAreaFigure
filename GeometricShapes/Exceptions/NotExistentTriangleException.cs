using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes.Exceptions
{
    public class NotExistentTriangleException : Exception
    {
        public override string? StackTrace { get; }

        public NotExistentTriangleException() : base("Not existent triangle") { }

        public NotExistentTriangleException(string? message, string? stackTrace = null) : base(message) => StackTrace = stackTrace;
    }
}
