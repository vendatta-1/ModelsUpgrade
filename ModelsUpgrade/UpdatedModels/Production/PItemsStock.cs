
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.Shared;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using ModelsUpgrade.UpdatedModels.Inventory.InventorySetting;

namespace ModelsUpgrade.UpdatedModels.Production
{
    public class PItemsStock : Entity
    {
        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public Guid? StoreDataId { get; set; }

        public Guid? PItemsHeaderId { get; set; }

        public Guid? PItemsBalanceFooterId { get; set; }

        public Guid? PRequestReceiptFooterId { get; set; }

        public Guid? PReturnPurchasesFooterId { get; set; }

        public Guid? PRequestReservationFooterId { get; set; }

        public Guid? PReturnReservationFooterId { get; set; }

        public Guid? PSettlementDiscountId { get; set; }

        public Guid? PAdditionAdjustmentId { get; set; }
        public double? Quantity { get; set; } = 0;
        public DateInfo DateInfo { get; set; }

        public string Description { get; set; }

        public bool? IsPosted { get; set; } = true;

        public virtual BranchesData BranchesData { get; set; }

        public virtual PAdditionAdjustment PAdditionAdjustment { get; set; }

        public virtual PItemsBalanceFooter PItemsBalanceFooter { get; set; }

        public virtual PItemsHeader PItemsHeader { get; set; }

        public virtual PRequestReceiptFooter PRequestReceiptFooter { get; set; }

        public virtual PRequestReservationFooter PRequestReservationFooter { get; set; }

        public virtual PReturnPurchasesFooter PReturnPurchasesFooter { get; set; }

        public virtual PReturnReservationFooter PReturnReservationFooter { get; set; }

        public virtual PSettlementDiscount PSettlementDiscount { get; set; }

        public virtual StoreData StoreData { get; set; }

    }
}
