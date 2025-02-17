namespace ModelsUpgrade.Apstractions
{
    /// <summary>
    /// Dated Info Entity is combination of  <seealso  cref="TransactionHeaderEntity"/> and <seealso cref="Shared.DateInfo"/>
    /// </summary>
    public abstract class DatedInfoEntity : TransactionHeaderEntity
    {
        public DatedInfoEntity(Guid id) : base(id) { }
        protected DatedInfoEntity() { }
        public short? Year { get; set; }
        public short? Month { get; set; }
        public DateOnly? Date { get; set; }
    }
}
