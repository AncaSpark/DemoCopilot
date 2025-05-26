using Microsoft.EntityFrameworkCore;
using System;

namespace TaxCalculator.Infrastructure.Data
{
    /// <summary>
    /// Database context for the application
    /// </summary>
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // This is a placeholder for DbSet properties
        // Actual implementation will be done in future tasks
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Entity configurations will be added here
        }
    }
}