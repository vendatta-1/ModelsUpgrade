using System;
using System.Collections.Generic;

namespace Link_Entities.Models;

public partial class CityCode
{
    public long CityId { get; set; }

    public long? GovernorateCodeId { get; set; }

    public string CityNameL1 { get; set; }

    public string CityNameL2 { get; set; }

    public bool? Posted { get; set; }

    public bool? IsNotActive { get; set; }

    public string CreateUserId { get; set; }

    public string CreateUserName { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string Modifiedby { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public string Deletedby { get; set; }

    public DateTime? DeletedDate { get; set; }

    public virtual ICollection<BankAtm> BankAtms { get; set; } = new List<BankAtm>();

    public virtual ICollection<BankCode> BankCodes { get; set; } = new List<BankCode>();

    public virtual ICollection<BranchesData> BranchesData { get; set; } = new List<BranchesData>();

    public virtual ICollection<CompanyData> CompanyData { get; set; } = new List<CompanyData>();

    public virtual ICollection<ConContractorDatum> ConContractorData { get; set; } = new List<ConContractorDatum>();

    public virtual ICollection<CustomerDatum> CustomerData { get; set; } = new List<CustomerDatum>();

    public virtual ICollection<DelegateDatum> DelegateData { get; set; } = new List<DelegateDatum>();

    public virtual ICollection<EduStudentData> EduStudentData { get; set; } = new List<EduStudentData>();

    public virtual ICollection<EmployeeDatum> EmployeeData { get; set; } = new List<EmployeeDatum>();

    public virtual GovernorateCode GovernorateCode { get; set; }

    public virtual ICollection<MedPartnerDatum> MedPartnerData { get; set; } = new List<MedPartnerDatum>();

    public virtual ICollection<StoreData> StoreData { get; set; } = new List<StoreData>();

    public virtual ICollection<SupplierData> SupplierData { get; set; } = new List<SupplierData>();

    public virtual ICollection<WorkPlanHeader> WorkPlanHeaders { get; set; } = new List<WorkPlanHeader>();
}
