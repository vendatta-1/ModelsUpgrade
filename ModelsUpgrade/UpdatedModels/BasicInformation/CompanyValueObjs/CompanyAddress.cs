namespace ModelsUpgrade.UpdatedModels.BasicInformation.CompanyValueObjs
{
    public record CompanyAddress
    (
         short BuildingNumber,
         string PostalCode,
         string FloorNumber,
         string RoomNumber,
         string LandMark
    );
}
