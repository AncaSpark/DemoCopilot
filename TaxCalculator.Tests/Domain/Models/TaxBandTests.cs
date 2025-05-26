using System;
using System.Collections.Generic;
using TaxCalculator.Domain.Models;
using Xunit;

namespace TaxCalculator.Tests.Domain.Models
{
    public class TaxBandTests
    {
        [Fact]
        public void ContainsPoint_ReturnsTrue_WhenValueWithinBand()
        {
            var band = new TaxBand { LowerLimit = 10000, UpperLimit = 20000 };
            Assert.True(band.ContainsPoint(15000));
        }

        [Fact]
        public void ContainsPoint_ReturnsFalse_WhenValueBelowBand()
        {
            var band = new TaxBand { LowerLimit = 10000, UpperLimit = 20000 };
            Assert.False(band.ContainsPoint(9000));
        }

        [Fact]
        public void ContainsPoint_ReturnsFalse_WhenValueAboveBand()
        {
            var band = new TaxBand { LowerLimit = 10000, UpperLimit = 20000 };
            Assert.False(band.ContainsPoint(25000));
        }

        [Fact]
        public void ContainsPoint_ReturnsTrue_WhenNoUpperLimitAndValueAboveLower()
        {
            var band = new TaxBand { LowerLimit = 50000, UpperLimit = null };
            Assert.True(band.ContainsPoint(100000));
        }

        [Fact]
        public void Contains_ReturnsTrue_WhenOtherBandWithinLimits()
        {
            var band = new TaxBand { LowerLimit = 10000, UpperLimit = 30000 };
            var other = new TaxBand { LowerLimit = 15000, UpperLimit = 20000 };
            Assert.True(band.Contains(other));
        }

        [Fact]
        public void Contains_ReturnsFalse_WhenOtherBandExceedsLimits()
        {
            var band = new TaxBand { LowerLimit = 10000, UpperLimit = 20000 };
            var other = new TaxBand { LowerLimit = 15000, UpperLimit = 25000 };
            Assert.False(band.Contains(other));
        }

        [Fact]
        public void Overlaps_ReturnsTrue_WhenBandsOverlap()
        {
            var band = new TaxBand { LowerLimit = 10000, UpperLimit = 20000 };
            var other = new TaxBand { LowerLimit = 15000, UpperLimit = 25000 };
            Assert.True(band.Overlaps(other));
        }

        [Fact]
        public void Overlaps_ReturnsFalse_WhenBandsDoNotOverlap()
        {
            var band = new TaxBand { LowerLimit = 10000, UpperLimit = 20000 };
            var other = new TaxBand { LowerLimit = 20000, UpperLimit = 30000 };
            Assert.False(band.Overlaps(other));
        }
    }
}
