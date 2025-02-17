
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.BasicInformation.BasicSettings;
using ModelsUpgrade.UpdatedModels.Inventory;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.ProgramSetting
{
    public class ApplicationSetting : Entity
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SettingNumber { get; set; }

        public Guid? CompanyDataId { get; set; }

        public Guid? CountryCodeId { get; set; }

        public Guid? InventoryValuationId { get; set; }

        public bool? AccountNumberActivate { get; set; }

        public string AccountNumberValue { get; set; }

        public bool? BarCodeItems { get; set; }
        [MaxLength(50)]
        public string BarCodeStartValue { get; set; }

        public virtual CompanyData CompanyData { get; set; }

        public virtual CountryCode CountryCode { get; set; }

        public virtual InventoryValuation InventoryValuation { get; set; }
    }
}
