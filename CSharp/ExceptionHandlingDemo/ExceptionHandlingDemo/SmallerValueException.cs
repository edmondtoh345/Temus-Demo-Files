using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    internal class SmallerValueException : Exception
    {
        public SmallerValueException() { }
        public SmallerValueException(string message) : base(message) { }
    }
}
