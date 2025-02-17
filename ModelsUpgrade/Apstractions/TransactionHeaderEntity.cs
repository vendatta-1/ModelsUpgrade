using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsUpgrade.Apstractions
{
    public abstract class TransactionHeaderEntity : HeaderEntity
    {
        protected TransactionHeaderEntity(Guid id) : base(id) { }
        protected TransactionHeaderEntity()
        {

        }
        public double? TotalDebit { get; set; }

        public double? TotalCredit { get; set; }

        public decimal? TotalBalance { get; set; }
    }
}
