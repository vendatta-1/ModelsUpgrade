using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.UpdatedModels.Purchasing.PurchasingValueObjs
{
    public record SupplierContacts
    {
        [MaxLength(40)]
        public string Mobile { get; set; }
        [MaxLength(10)]
        public string Phone { get; set; }
        [MaxLength(10)]
        public string Fax { get; set; }
        [MaxLength(11)]
        public string Whatsapp { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
