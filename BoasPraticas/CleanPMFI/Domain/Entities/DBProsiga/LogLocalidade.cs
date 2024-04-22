using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class LogLocalidade
    {
        public int LocNu { get; set; }
        public string LocNo { get; set; } = null!;
        public string UfeSg { get; set; } = null!;
        public string? CidNome { get; set; }
    }
}
