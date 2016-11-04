using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCodeFirstSqlVs.Models
{
    public class LanguageString : IEntity
    {
        public string Text { get; set; }

        public Language Language { get; set; }

        public int? UniqueClassId { get; set; }
        public UniqueClass UniqueClass { get; set; }
    }
}
