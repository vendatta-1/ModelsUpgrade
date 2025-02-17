using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.ProgramSetting;

public class DatabaseDescription : NamedEntity
{


    public string ShortName { get; set; }

    public Guid? ParentCode { get; set; }

    public int? LeavelCode { get; set; } = 0;


    public virtual ICollection<DatabaseDescription> InverseParentCodeNavigation { get; set; } = new HashSet<DatabaseDescription>();

    public virtual DatabaseDescription ParentCodeNavigation { get; set; }
}
