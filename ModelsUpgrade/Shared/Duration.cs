using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUpgrade.Shared
{
    [Owned]
    public record Duration
    {
        [Column(name: "StartDate")]
        public DateOnly? StartDate { get; set; }
        [Column(name: "EndDate")]
        public DateOnly? EndDate { get; set; }

        private Duration()
        {

        }
        public Duration(DateOnly? startDate, DateOnly? endDate)
        {
            if (startDate > endDate)
            {
                throw new ArgumentOutOfRangeException("End date Precedes start date");
            }
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
