
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.Sales
{
    public class DelegateData : NamedEntity
    {
        public DelegateData(Guid id) : base(id)
        {

        }
        protected DelegateData()
        {

        }
        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public Guid? DelegateBarCode { get; set; }

        public Guid? CountryCodeId { get; set; }

        public Guid? GovernorateCodeId { get; set; }

        public Guid? CityCodeId { get; set; }
        [MaxLength(200)]
        public string DelegateAddress { get; set; }
        [MaxLength(14)]
        public string DelegateNationalId { get; set; }
        public ContactInfo Contacts { get; set; }
        public Guid? AccountsNameId { get; set; }

        public double? SalesValue { get; set; }

        public Duration DelegateDuration { get; set; }



        public virtual AccountName AccountsName { get; set; }

        public virtual CityCode CityCode { get; set; }
        public virtual CompanyData CompanyData { get; set; }

        public virtual ICollection<CustomerData> CustomerData { get; set; } = new HashSet<CustomerData>();


    }
}
