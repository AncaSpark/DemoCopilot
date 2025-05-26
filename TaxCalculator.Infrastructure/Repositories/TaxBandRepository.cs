using TaxCalculator.Infrastructure.Data;

namespace TaxCalculator.Infrastructure.Repositories
{
    /// <summary>
    /// Repository for tax band operations
    /// </summary>
    public class TaxBandRepository
    {
        private readonly AppDbContext _context;
        
        public TaxBandRepository(AppDbContext context)
        {
            _context = context;
        }
        
        // This is just a placeholder repository
        // Actual implementation will be done in future tasks
    }
}