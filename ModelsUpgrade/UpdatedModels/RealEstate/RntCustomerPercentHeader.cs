using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;

namespace ModelsUpgrade.UpdatedModels.RealEstate;

public class RntCustomerPercentHeader : HeaderEntity
{



    public Guid? CustomerDataId { get; set; }
    public DateInfo DateInfo { get; set; }

    public double? TotalRevenu { get; set; }

    public double? TotalExpenses { get; set; }

    public double? NetRevenu { get; set; }





    public virtual ICollection<RntCustomerPercentData> RntCustomerPercentDs { get; set; } = new HashSet<RntCustomerPercentData>();
}
