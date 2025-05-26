using System;
using TaxCalculator.Domain.Exceptions;
using Xunit;

namespace TaxCalculator.Tests.Domain.Exceptions
{
    public class ExceptionTests
    {
        [Fact]
        public void InvalidTaxBandException_CanBeConstructed()
        {
            var ex = new InvalidTaxBandException("Invalid band");
            Assert.Equal("Invalid band", ex.Message);
        }

        [Fact]
        public void TaxCalculationException_CanBeConstructed()
        {
            var ex = new TaxCalculationException("Calculation error");
            Assert.Equal("Calculation error", ex.Message);
        }
    }
}
