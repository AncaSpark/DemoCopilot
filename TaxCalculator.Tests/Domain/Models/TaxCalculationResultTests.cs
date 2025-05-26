using System;
using TaxCalculator.Domain.Models;
using Xunit;

namespace TaxCalculator.Tests.Domain.Models
{
    public class TaxCalculationResultTests
    {
        [Fact]
        public void GrossMonthlySalary_IsCorrect()
        {
            var result = new TaxCalculationResult { GrossAnnualSalary = 120000 };
            Assert.Equal(10000, result.GrossMonthlySalary);
        }

        [Fact]
        public void NetAnnualSalary_IsCorrect()
        {
            var result = new TaxCalculationResult { GrossAnnualSalary = 50000, AnnualTaxPaid = 10000 };
            Assert.Equal(40000, result.NetAnnualSalary);
        }

        [Fact]
        public void NetMonthlySalary_IsCorrect()
        {
            var result = new TaxCalculationResult { GrossAnnualSalary = 60000, AnnualTaxPaid = 12000 };
            Assert.Equal(4000, result.NetMonthlySalary);
        }

        [Fact]
        public void MonthlyTaxPaid_IsCorrect()
        {
            var result = new TaxCalculationResult { AnnualTaxPaid = 6000 };
            Assert.Equal(500, result.MonthlyTaxPaid);
        }
    }
}
