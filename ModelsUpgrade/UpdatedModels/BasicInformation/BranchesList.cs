using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.BasicInformation
{
    public class BranchesList : Entity
    {


        public Guid? CompanyDataId { get; set; }

        public Guid? BranchesDataId { get; set; }

        public virtual BranchesData BranchesData { get; set; }

        public virtual CompanyData CompanyData { get; set; }
    }
}
