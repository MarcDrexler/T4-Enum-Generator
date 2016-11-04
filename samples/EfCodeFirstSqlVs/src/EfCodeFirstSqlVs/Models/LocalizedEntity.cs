using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCodeFirstSqlVs.Models
{
    public class LocalizedEntity : IEntity
    {
        public LocalizedEntity()
        {
            Name = new List<LanguageString>();
        }

        public List<LanguageString> Name { get; set; }
    }
}
