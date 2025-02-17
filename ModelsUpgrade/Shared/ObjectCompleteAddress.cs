using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.Shared
{
    [Owned]
    public record ObjectCompleteAddress
    {

        [MaxLength(200)]
        public string AddressInformation { get; set; }
        [MaxLength(5)]
        public string BuildingNumber { get; set; }
        [MaxLength(7)]
        public string PostalCode { get; set; }
        [MaxLength(5)]
        public string FloorNumber { get; set; }
        [MaxLength(3)]
        public string RoomNumber { get; set; }
        [MaxLength(200)]
        public string LandMark { get; set; }
    }
}
