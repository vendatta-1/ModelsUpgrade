namespace Link_Entities.Models;

public partial class SupplierGroup
{
    public long CategoryId { get; set; }

    public string CategoryNameL1 { get; set; }

    public string CategoryNameL2 { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<ConContractorDatum> ConContractorData { get; set; } = new List<ConContractorDatum>();

    public virtual ICollection<SupplierData> SupplierData { get; set; } = new List<SupplierData>();
}
