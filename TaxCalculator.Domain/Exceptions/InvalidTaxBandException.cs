using System;

namespace TaxCalculator.Domain.Exceptions
{
    public class InvalidTaxBandException : Exception
    {
        public InvalidTaxBandException() { }
        public InvalidTaxBandException(string message) : base(message) { }
        public InvalidTaxBandException(string message, Exception inner) : base(message, inner) { }
    }
}
