
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.BasicInformation;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial
{
    public class ReservationDebit : Entity
    {
        public ReservationDebit(Guid id) : base(id) { }
        protected ReservationDebit()
        {

        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ReservationUd { get; set; }

        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public Guid? CostCenterId { get; set; }
        [ForeignKey(nameof(ReservationFrom))]
        public Guid? ReservationFromId { get; set; }
        [ForeignKey(nameof(ReservationTo))]

        public Guid? ReservationToId { get; set; }

        public DateOnly? ReservationDate { get; set; }

        public double? ReservationValue { get; set; } = 0.0;

        public string Description { get; set; }

        public Guid? ReservationStatusId { get; set; }


        public virtual CompanyData CompanyData { get; set; }

        public virtual CostCenter CostCenter { get; set; }

        public virtual ReservationStatus ReservationStatus { get; set; }
        //new addations
        public virtual BranchesData BranchesData { get; set; }
        public virtual ReservationDebit ReservationFrom { get; set; }
        public virtual ReservationDebit ReservationTo { get; set; }

    }
}
