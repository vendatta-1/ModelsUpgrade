using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;
using ModelsUpgrade.UpdatedModels.ManageItems;
using ModelsUpgrade.UpdatedModels.Purchasing;
using ModelsUpgrade.UpdatedModels.Sales;

namespace ModelsUpgrade.UpdatedModels.Inventory.InventoryReports
{
    public class ItemsStock : Entity
    {


        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public Guid? StoreDataId { get; set; }

        public Guid? ItemsHeaderId { get; set; }

        public Guid? ItemsBalanceFooterId { get; set; }

        public Guid? RequestReceiptFooterId { get; set; }

        public Guid? ReturnPurchasesFooterId { get; set; }

        public Guid? SalesInvoiceFooterId { get; set; }

        public Guid? ReturnSalesFooterId { get; set; }

        public Guid? SettlementDiscountId { get; set; }

        public Guid? AdditionAdjustmentId { get; set; }

        public Guid? TransformationsDetailId { get; set; }

        public double? Quantity { get; set; } = 0.0;

        public DateInfo DateInfo { get; set; }

        public string Description { get; set; } = string.Empty;

        public bool? IsPosted { get; set; } = true;

        public virtual AdditionAdjustment AdditionAdjustment { get; set; }

        public virtual BranchesData BranchesData { get; set; }

        public virtual ItemsBalanceFooter ItemsBalanceFooter { get; set; }

        public virtual ItemsHeader ItemsHeader { get; set; }

        public virtual RequestReceiptFooter RequestReceiptFooter { get; set; }

        public virtual ReturnPurchasesFooter ReturnPurchasesFooter { get; set; }

        public virtual ReturnSalesFooter ReturnSalesFooter { get; set; }

        public virtual SalesInvoiceFooter SalesInvoiceFooter { get; set; }

        public virtual SettlementDiscount SettlementDiscount { get; set; }

        public virtual StoreData StoreData { get; set; }

        public virtual TransformationsDetail TransformationsDetail { get; set; }
    }
}
