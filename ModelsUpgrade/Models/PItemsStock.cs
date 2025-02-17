namespace Link_Entities.Models;

public partial class PItemsStock
{
    public Guid PitemsStockId { get; set; }

    public Guid? CompanyDataId { get; set; }

    public Guid? BranchesDataId { get; set; }

    public Guid? StoreDataId { get; set; }

    public Guid? PitemsHeaderId { get; set; }

    public Guid? PitemsBalanceFooterId { get; set; }

    public Guid? PrequestReceiptFooterId { get; set; }

    public Guid? PreturnPurchasesFooterId { get; set; }

    public Guid? PrequestReservationFooterId { get; set; }

    public Guid? PreturnReservationFooterId { get; set; }

    public Guid? PsettlementDiscountId { get; set; }

    public Guid? PadditionAdjustmentId { get; set; }

    public double? Quantity { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public DateOnly? Date { get; set; }

    public string Description { get; set; }


    public bool? IsPosted { get; set; }

    public virtual BranchesData BranchesData { get; set; }

    public virtual PAdditionAdjustment PadditionAdjustment { get; set; }

    public virtual PItemsBalanceFooter PitemsBalanceFooter { get; set; }

    public virtual PItemsHeader PitemsHeader { get; set; }

    public virtual PRequestReceiptFooter PrequestReceiptFooter { get; set; }

    public virtual PRequestReservationFooter PrequestReservationFooter { get; set; }

    public virtual PReturnPurchasesFooter PreturnPurchasesFooter { get; set; }

    public virtual PReturnReservationFooter PreturnReservationFooter { get; set; }

    public virtual PsettlementDiscount PsettlementDiscount { get; set; }

    public virtual StoreData StoreData { get; set; }
}
