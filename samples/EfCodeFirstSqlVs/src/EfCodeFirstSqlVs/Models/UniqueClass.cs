using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCodeFirstSqlVs.Models
{
    public class UniqueClass : LocalizedEntity
    {
        public Guid InternalId { get; set; }
    }
}
