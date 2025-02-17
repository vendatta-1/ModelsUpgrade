using Microsoft.AspNetCore.Identity;


namespace ModelsUpgrade.UpdatedModels.Security
{
    public class AppUser : IdentityUser
    {
        // Extended Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Guid? FacebookId { get; set; }
        public string PictureUrl { get; set; }
    }
}
