using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.ProgramSetting;
using ModelsUpgrade.UpdatedModels.Security;

namespace ModelsUpgrade.UpdatedModels.UserSetting
{
    public class UsePermissions : Entity
    {
        public string AppUserId { get; set; }

        public Guid? ApplicationMenuId { get; set; }

        public bool? OpenForm { get; set; }

        public bool? AddForm { get; set; }

        public bool? EditForm { get; set; }

        public bool? DeleteForm { get; set; }

        public bool? ReadForm { get; set; }

        public bool? SearchForm { get; set; }

        public bool? FilterForm { get; set; }

        public bool? PrinterReport { get; set; }

        public bool? ExportFile { get; set; }

        public bool? ExportDataGrid { get; set; }
        public virtual ApplicationMenu ApplicationMenu { get; set; }

        public virtual AppUser AppUser { get; set; }
    }
}
