using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Tbsisautonum
    {
        public string Nmtabela { get; set; } = null!;
        public string Flativo { get; set; } = null!;
        public long Nratual { get; set; }
        public long? Nrinicio { get; set; }
        public long? Nrlimite { get; set; }
    }
}
