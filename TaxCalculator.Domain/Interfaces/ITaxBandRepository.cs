using System.Collections.Generic;
using System.Threading.Tasks;
using TaxCalculator.Domain.Models;

namespace TaxCalculator.Domain.Interfaces
{
    public interface ITaxBandRepository
    {
        Task<IEnumerable<TaxBand>> GetAllTaxBandsAsync();
        Task<TaxBand> GetTaxBandByIdAsync(int id);
        Task AddTaxBandAsync(TaxBand taxBand);
        Task UpdateTaxBandAsync(TaxBand taxBand);
        Task DeleteTaxBandAsync(int id);
    }
}
