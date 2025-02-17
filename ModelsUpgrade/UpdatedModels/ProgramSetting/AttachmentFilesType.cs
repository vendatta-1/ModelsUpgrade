
using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.ProgramSetting
{
    public class AttachmentFilesType : NamedEntity
    {
        public virtual ICollection<AttatchmentFile> AttachmentFiles { get; set; } = new HashSet<AttatchmentFile>();
    }
}
