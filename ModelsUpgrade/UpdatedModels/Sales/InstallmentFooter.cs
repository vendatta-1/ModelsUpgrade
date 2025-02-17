using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.Sales
{
    public class InstallmentFooter : FooterEntity
    {
        public InstallmentFooter(Guid id) : base(id)
        {

        }
        protected InstallmentFooter()
        {

        }
        public Guid? InstallmentHeaderId { get; set; }
        public double? InstallmentValue { get; set; }


        public int? InstallmentNumber { get; set; }//not exist

        public bool? PostedInstallment { get; set; }
        public virtual InstallmentHeader InstallmentHeader { get; set; }
    }
}
