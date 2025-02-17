using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Sales
{
    public class InstallmentHeader : HeaderEntity
    {
        public InstallmentHeader(Guid id) : base(id)
        {

        }
        protected InstallmentHeader()
        {

        }
        public Guid? CustomerDataId { get; set; }
        public DateInfo DateInfo { get; set; }

        public double? TotalValue { get; set; }

        public double? FirstBatch { get; set; }
        [Column(TypeName = "decimal(18,0)")]

        public decimal? InterestRate { get; set; }

        public double? NetValue { get; set; }

        public int? NumberInstallments { get; set; }

        public double? ValueInstallment { get; set; }

        public int? InstallmentPeriod { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal? DelayInterestRate { get; set; }
        [MaxLength(150)]
        public string Declaration { get; set; }
        [MaxLength(250)]
        public string FileUrl { get; set; }
        public virtual CustomerData CustomerData { get; set; }
        public virtual ICollection<InstallmentFooter> InstallmentFooters { get; set; } = new HashSet<InstallmentFooter>();
    }
}
