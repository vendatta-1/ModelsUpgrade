namespace ModelsUpgrade.Apstractions
{
    public abstract class TransactionFooterEntity : FooterEntity
    {
        public TransactionFooterEntity(Guid id) : base(id) { }
        protected TransactionFooterEntity() { }
        public double? Debit { get; set; }

        public double? Credit { get; set; }
    }
}
