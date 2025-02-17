
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial;
using ModelsUpgrade.UpdatedModels.ManageItems.ItemsSetting;
using ModelsUpgrade.UpdatedModels.Purchasing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PItemsHeader : HeaderEntity
    {


        public Guid? PitemsGroupsId { get; set; }

        public Guid? SupplierDataId { get; set; }
        public Guid? ItemsTypeId { get; set; }

        public Guid? ItemsCodeTypeId { get; set; }

        [ForeignKey(nameof(AccountsNamePurchas))]
        public Guid? AccountsNamePurchasId { get; set; }

        [ForeignKey(nameof(AccountNameSales))]
        public Guid? AccountNameSalesId { get; set; }

        [MaxLength(75)]
        public string NameL1 { get; set; }
        [MaxLength(75)]
        public string NameL2 { get; set; }

        [MaxLength(50)]
        public string InternalCode { get; set; }
        public int? StockLimit { get; set; } = 0;
        public bool? IsNotActiveTax { get; set; }

        public bool? IsNotActiveTaxDiscount { get; set; }
        public Duration Duration { get; set; }
        [MaxLength(250)]
        public string ImageUrl { get; set; }

        public virtual AccountName AccountNameSales { get; set; }

        public virtual AccountName AccountsNamePurchas { get; set; }

        public virtual ItemsType ItemsType { get; set; }

        public virtual ICollection<PAdditionAdjustment> PadditionAdjustments { get; set; } = new HashSet<PAdditionAdjustment>();

        public virtual ICollection<PInventoryOrderFooter> PinventoryOrderFooters { get; set; } = new HashSet<PInventoryOrderFooter>();

        public virtual ICollection<PItemsBalanceFooter> PitemsBalanceFooters { get; set; } = new HashSet<PItemsBalanceFooter>();

        public virtual PItemsGroup PItemsGroups { get; set; }

        public virtual ICollection<PItemsStock> PItemsStocks { get; set; } = new HashSet<PItemsStock>();

        public virtual ICollection<PPurchasesInvoiceFooter> PPurchasesInvoiceFooters { get; set; } = new HashSet<PPurchasesInvoiceFooter>();

        public virtual ICollection<PRequestReceiptFooter> PRequestReceiptFooters { get; set; } = new HashSet<PRequestReceiptFooter>();

        public virtual ICollection<PRequestReservationFooter> PRequestReservationFooters { get; set; } = new HashSet<PRequestReservationFooter>();

        public virtual ICollection<PReturnPurchasesFooter> PReturnPurchasesFooters { get; set; } = new HashSet<PReturnPurchasesFooter>();

        public virtual ICollection<PReturnReservationFooter> PReturnReservationFooters { get; set; } = new HashSet<PReturnReservationFooter>();

        public virtual SupplierData SupplierData { get; set; }
    }
}
