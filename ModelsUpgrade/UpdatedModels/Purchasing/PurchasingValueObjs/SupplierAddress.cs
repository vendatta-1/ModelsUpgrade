using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.Purchasing.PurchasingValueObjs
{
    public record SupplierAddress
    {
        [MaxLength(100)]
        public string AddressInformation { get; set; }
        [MaxLength(5)]
        public string BuildingNumber { get; set; }
        [MaxLength(7)]
        public string PostalCode { get; set; }
        [MaxLength(5)]
        public string FloorNumber { get; set; }
        [MaxLength(3)]
        public string RoomNumber { get; set; }
        [MaxLength(50)]
        public string LandMark { get; set; }
    }
}
