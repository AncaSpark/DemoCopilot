using System.Collections.Generic;
using TaxCalculator.Domain.Models;

namespace TaxCalculator.Domain.Interfaces
{
    public interface ITaxBandService
    {
        IEnumerable<TaxBand> FindContainingIntervals(TaxBand taxBand);
    }
}
