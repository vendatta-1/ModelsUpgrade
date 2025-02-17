using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.Contractors.ContractorsValueObjs
{
    [Owned]
    public record ContractMasterPricing
    {
        public double? TotalValue { get; set; }

        public double? TotalTax { get; set; }

        public double? TotalDiscount { get; set; }

        public double? Payments { get; set; }

        public double? NetTotal { get; set; }
    }
}
