using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts;
using ModelsUpgrade.UpdatedModels.Sales.SalesValueObjs;

namespace ModelsUpgrade.UpdatedModels.Sales
{
    public class SalesInvoicePayment : Entity
    {
        public Guid? SalesInvoiceHeaderId { get; set; }

        public Guid? PaymentModesId { get; set; }

        public Guid? BankCodeId { get; set; }

        public SalesTransactionInfo TransactionInfo { get; set; }

        public virtual BankCode BankCode { get; set; }

        public virtual PaymentMode PaymentModes { get; set; }

        public virtual SalesInvoiceHeader SalesInvoiceHeader { get; set; }
    }
}
