
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using ModelsUpgrade.UpdatedModels.HR.HRSetting;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.Production;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.Purchasing
{
    public class SupplierData : Entity
    {
        public SupplierData(Guid id) : base(id)
        {

        }
        protected SupplierData()
        {

        }
        public Guid? CompanyDataId { get; set; }

        public Guid? SupplierGroupsId { get; set; }
        [MaxLength(13)]
        public string SupplierBarCode { get; set; }
        [MaxLength(75)]
        public string SupplierName { get; set; }

        public Guid? CountryCodeId { get; set; }

        public Guid? GovernorateCodeId { get; set; }

        public Guid? CityCodeId { get; set; }


        [MaxLength(100)]
        public string AdditionalInformation { get; set; }
        [MaxLength(14)]
        public string NationalId { get; set; }

        public ObjectCompleteAddress Address { get; set; }
        public ContactInfo Contacts { get; set; }
        public Guid? SupplierManager { get; set; }

        public bool? IsCustomer { get; set; }

        public bool? IsCompany { get; set; }

        public bool? IsNotActiveTax { get; set; }

        public Guid? AccountsNameId { get; set; }
        [MaxLength(10)]
        public string TaxRegistrationNumber { get; set; }
        [MaxLength(50)]
        public string TaxesErrand { get; set; }
        [MaxLength(10)]
        public string CommercialRegisterNumber { get; set; }

        public DateOnly? StartDate { get; set; }

        public DateOnly? EndDate { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }


        public virtual AccountName AccountsName { get; set; }

        public virtual CityCode CityCode { get; set; }

        public virtual CompanyData CompanyData { get; set; }

        public virtual ICollection<ItemsHeader> ItemsHeaders { get; set; } = new HashSet<ItemsHeader>();

        public virtual ICollection<ItemsPricePurchase> ItemsPricePurchases { get; set; } = new HashSet<ItemsPricePurchase>();

        public virtual ICollection<PItemsHeader> PitemsHeaders { get; set; } = new HashSet<PItemsHeader>();

        public virtual ICollection<PPurchasesInvoiceHeader> PPurchasesInvoiceHeaders { get; set; } = new HashSet<PPurchasesInvoiceHeader>();

        public virtual ICollection<PReturnPurchasesHeader> PReturnPurchasesHeaders { get; set; } = new HashSet<PReturnPurchasesHeader>();

        public virtual ICollection<PurchasesInvoiceHeader> PurchasesInvoiceHeaders { get; set; } = new HashSet<PurchasesInvoiceHeader>();

        public virtual ICollection<PurchasesOrderHeader> PurchasesOrderHeaders { get; set; } = new HashSet<PurchasesOrderHeader>();

        public virtual ICollection<ReturnPurchasesHeader> ReturnPurchasesHeaders { get; set; } = new HashSet<ReturnPurchasesHeader>();

        public virtual SupplierGroup SupplierGroups { get; set; }

        public virtual EmployeeData SupplierManagerNavigation { get; set; }
    }
}
