namespace Link_Entities.Models;

public partial class ReservationDebit
{
    public Guid ReservationId { get; set; }

    public long ReservationUd { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? CostCenterId { get; set; }

    public Guid? ReservationFrom { get; set; }

    public Guid? ReservationTo { get; set; }

    public DateOnly? ReservationDate { get; set; }

    public double? ReservationValue { get; set; }

    public string Description { get; set; }

    public long? ReservationStatusId { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual CompanyData CompanyData { get; set; }

    public virtual CostCenter CostCenter { get; set; }

    public virtual ReservationStatus ReservationStatus { get; set; }
}
