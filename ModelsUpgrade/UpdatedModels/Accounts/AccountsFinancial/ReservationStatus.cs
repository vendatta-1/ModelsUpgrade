
using ModelsUpgrade.Apstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsUpgrade.UpdatedModels.Accounts.AccountsFinancial
{
    public class ReservationStatus:NamedEntity
    {
      
        public virtual ICollection<ReservationDebit> ReservationDebits { get; set; } = new HashSet<ReservationDebit>();
    }
}
