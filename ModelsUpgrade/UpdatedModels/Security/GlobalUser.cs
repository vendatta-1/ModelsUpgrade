namespace ModelsUpgrade.UpdatedModels.Security
{
    public class GlobalUser
    {
        public Guid Id { get; set; }
        public Guid IdentityId { get; set; }
        public AppUser Identity { get; set; }  // navigation property
        public string Location { get; set; }
        public string Locale { get; set; }
        public string Gender { get; set; }
    }
}

