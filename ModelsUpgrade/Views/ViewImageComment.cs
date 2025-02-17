using ModelsUpgrade.Apstractions;

namespace ModelsUpgrade.Views;

public class ViewImageComment : View
{
    public Guid FooterId { get; set; }

    public Guid DetailsId { get; set; }

    public string ImageBefor { get; set; }

    public string Comment { get; set; }

    public int? ImageId { get; set; }

    public bool? IsNotActive { get; set; }

    public bool? IsDeleted { get; set; }
}
