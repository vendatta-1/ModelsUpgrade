
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.HR.HRSetting;
using ModelsUpgrade.UpdatedModels.POSCasher;
using ModelsUpgrade.UpdatedModels.Production;
using ModelsUpgrade.UpdatedModels.Purchasing;
using ModelsUpgrade.UpdatedModels.Sales;

namespace ModelsUpgrade.UpdatedModels.Accounts.SettingAccounts
{
    public class PaymentMode : NamedEntity
    {
        public PaymentMode(Guid id) : base(id) { }
        protected PaymentMode() { }



        public string CodeTax { get; set; }
        public virtual ICollection<EmployeeData> EmployeeData { get; set; } = new HashSet<EmployeeData>();

        public virtual ICollection<PosPaymentDaily> PospaymentDailies { get; set; } = new HashSet<PosPaymentDaily>();

        public virtual ICollection<PReturnPurchasesHeader> PreturnPurchasesHeaders { get; set; } = new HashSet<PReturnPurchasesHeader>();

        public virtual ICollection<PurchasesInvoiceHeader> PurchasesInvoiceHeaders { get; set; } = new HashSet<PurchasesInvoiceHeader>();

        public virtual ICollection<ReturnPurchasesHeader> ReturnPurchasesHeaders { get; set; } = new HashSet<ReturnPurchasesHeader>();

        public virtual ICollection<ReturnSalesHeader> ReturnSalesHeaders { get; set; } = new HashSet<ReturnSalesHeader>();

        public virtual ICollection<SalesInvoiceHeader> SalesInvoiceHeaders { get; set; } = new HashSet<SalesInvoiceHeader>();

        public virtual ICollection<SalesInvoicePayment> SalesInvoicePayments { get; set; } = new HashSet<SalesInvoicePayment>();



    }
}
