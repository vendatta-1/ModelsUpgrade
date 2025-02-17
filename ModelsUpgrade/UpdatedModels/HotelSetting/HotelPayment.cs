using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.Sales;

namespace ModelsUpgrade.UpdatedModels.HotelSetting;

public class HotelPayment : Entity
{


    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? CustomerDataId { get; set; }

    public Guid? HotelReservationMasterId { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public double? Debit { get; set; } = 0.0;

    public double? Credit { get; set; } = 0.0;

    public bool? IsPosted { get; set; } = true;
    public virtual CompanyData CompanyData { get; set; }
    public virtual BranchesData BranchesData { get; set; }
    public virtual CustomerData CustomerData { get; set; }

    public virtual HotelReservationMaster HotelReservationMaster { get; set; }
}
