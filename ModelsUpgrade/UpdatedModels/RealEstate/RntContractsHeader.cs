using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Sales;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.RealEstate;
public class RntContractsHeader : HeaderEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ContractCode { get; set; }

    public Guid? CustomerDataId { get; set; }

    public int? ActivitiesId { get; set; }

    public int? RentalMonthes { get; set; }

    public int? InsuranceMonthes { get; set; }

    public int? ContractMonthes { get; set; }

    public Duration ContractDuration { get; set; }
    public DateTime? IncreasingDate { get; set; }

    public virtual RntActivity Activities { get; set; }


    public virtual CustomerData CustomerData { get; set; }

    public virtual ICollection<RntContractsData> RntContractsDs { get; set; } = new HashSet<RntContractsData>();

    public virtual ICollection<RntReceiptsHeader> RntReceiptsHes { get; set; } = new HashSet<RntReceiptsHeader>();
}
