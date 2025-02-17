using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ModelsUpgrade.Shared
{
    [Owned]
    public record ContactInfo
    (
        [MaxLength(40)]
        string Mobile,
        [MaxLength(10)]
        string Phone,
        [MaxLength(11)]
         string Whatsapp,
        [MaxLength(50)]
         string Email,
        [MaxLength(40)]
         string Fax

    );
}
