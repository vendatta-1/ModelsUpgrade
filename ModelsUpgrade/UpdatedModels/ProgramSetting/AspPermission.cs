
using ModelsUpgrade.Apstractions;
using ModelsUpgrade.UpdatedModels.Security;

namespace ModelsUpgrade.UpdatedModels.ProgramSetting
{
    public class AspPermission : Entity
    {
        //public string AspNetUsersId { get; set; }

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

        public virtual AppUser AspNetUser { get; set; }//////////need Fk of it 
    }
}
