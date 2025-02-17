using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.BasicInformation.CompanyValueObjs
{
    [Owned]
    public record CompanyBasicInformation
    (
        string AdditionalInformation,
        string Description,
        string ImageUrl,
        string CommercialRegisterNumber,
        string TaxesErrand,
        string CompanyName,
        string SpecializationL1,
        string SpecializationL2
    );
}
