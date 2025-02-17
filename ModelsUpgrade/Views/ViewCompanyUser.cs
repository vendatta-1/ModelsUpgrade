using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.Views;

public class ViewCompanyUser : View
{
    public string CompanyName { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public Guid CompanyId { get; set; }
}
