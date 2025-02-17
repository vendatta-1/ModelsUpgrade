using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;

namespace ModelsUpgrade.UpdatedModels.HotelSetting;

public class HotelService : NamedEntity
{


    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }


    public double? ServicesValue { get; set; } = 0.0;

    public virtual CompanyData CompanyData { get; set; }
    public virtual BranchesData BranchesData { get; set; }
    public virtual ICollection<HotelReservationDetail> HotelReservationDetails { get; set; } = new List<HotelReservationDetail>();
}
