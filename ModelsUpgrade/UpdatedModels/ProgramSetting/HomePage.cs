using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.UpdatedModels.ProgramSetting
{
    public class HomePage : Entity
    {
        public string HeaderText { get; set; }

        public string CardTextRight { get; set; }

        public string CardTextLeft { get; set; }

        public string FooterText { get; set; }
    }
}
