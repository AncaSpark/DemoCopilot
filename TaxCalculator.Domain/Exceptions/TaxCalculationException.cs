using System;

namespace TaxCalculator.Domain.Exceptions
{
    public class TaxCalculationException : Exception
    {
        public TaxCalculationException() { }
        public TaxCalculationException(string message) : base(message) { }
        public TaxCalculationException(string message, Exception inner) : base(message, inner) { }
    }
}
