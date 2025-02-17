
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using ModelsUpgrade.UpdatedModels.EInvoicing;
using ModelsUpgrade.UpdatedModels.HotelSetting;
using ModelsUpgrade.UpdatedModels.Medical;
using ModelsUpgrade.UpdatedModels.POSCasher;
using ModelsUpgrade.UpdatedModels.RealEstate;
using System.ComponentModel.DataAnnotations;
namespace ModelsUpgrade.UpdatedModels.Sales
{
    public class CustomerData : Entity
    {
        public CustomerData(Guid id) : base(id)
        {

        }
        protected CustomerData()
        {

        }
        public Guid? CompanyDataId { get; set; }

        public Guid? CustomerCategoriesId { get; set; }

        public Guid? CustomerBarCode { get; set; }
        [MaxLength(50)]
        public string CustomerName { get; set; }

        [MaxLength(100)]
        public string AdditionalInformation { get; set; }
        [MaxLength(14)]
        public string NationalId { get; set; }

        public ObjectCompleteAddress Address { get; set; }
        public ContactInfo Contacts { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public virtual AccountName AccountsNameSales { get; set; }

        public virtual CityCode CityCode { get; set; }

        public virtual CompanyData CompanyData { get; set; }

        public virtual CustomerCategories CustomerCategories { get; set; }

        public virtual CustomerModes CustomerModes { get; set; }

        public virtual ICollection<HotelPayment> HotelPayments { get; set; } = new HashSet<HotelPayment>();

        public virtual ICollection<HotelReservationMaster> HotelReservationMasters { get; set; } = new HashSet<HotelReservationMaster>();

        public virtual ICollection<InstallmentHeader> InstallmentHeaders { get; set; } = new HashSet<InstallmentHeader>();

        public virtual ICollection<MedCustomerDetail> MedCustomerDetails { get; set; } = new HashSet<MedCustomerDetail>();

        public virtual ICollection<MedCustomerMedicalService> MedCustomerMedicalServices { get; set; } = new HashSet<MedCustomerMedicalService>();

        public virtual ICollection<MedCustomerSurgicalService> MedCustomerSurgicalServices { get; set; } = new HashSet<MedCustomerSurgicalService>();

        public virtual ICollection<PosSale> Possales { get; set; } = new HashSet<PosSale>();

        public virtual DelegateData RepresentativeData { get; set; }

        public virtual ICollection<ReturnSalesHeader> ReturnSalesHeaders { get; set; } = new HashSet<ReturnSalesHeader>();

        public virtual ICollection<RntContractsHeader> RntContractsHes { get; set; } = new HashSet<RntContractsHeader>();

        public virtual ICollection<RntCustomerPercentHeader> RntCustomerPercentHs { get; set; } = new HashSet<RntCustomerPercentHeader>();

        public virtual ICollection<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; } = new HashSet<SalesInvoiceHeader>();

    }
}
