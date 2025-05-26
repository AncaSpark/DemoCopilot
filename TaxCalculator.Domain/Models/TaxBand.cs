using System;

namespace TaxCalculator.Domain.Models
{
    public class TaxBand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal LowerLimit { get; set; }
        public decimal? UpperLimit { get; set; }
        public decimal TaxRate { get; set; }

        public bool ContainsPoint(decimal value)
        {
            return value >= LowerLimit && (UpperLimit == null || value < UpperLimit);
        }

        public bool Contains(TaxBand other)
        {
            return other.LowerLimit >= LowerLimit && (UpperLimit == null || (other.UpperLimit != null && other.UpperLimit <= UpperLimit));
        }

        public bool Overlaps(TaxBand other)
        {
            return (LowerLimit < (other.UpperLimit ?? decimal.MaxValue)) && ((UpperLimit ?? decimal.MaxValue) > other.LowerLimit);
        }
    }
}
