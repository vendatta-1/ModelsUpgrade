using ModelsUpgrade.Apstractions;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.ProgramSetting
{
    public class AttatchmentFile : Entity
    {

        public Guid? AttachmentFilesTypeId { get; set; }

        public int? AttachmentNumber { get; set; } = 0;

        public string Description { get; set; }
        [MaxLength(250)]
        public string FilesUrl { get; set; }
        public virtual AttachmentFilesType AttachmentFilesType { get; set; }

    }
}
