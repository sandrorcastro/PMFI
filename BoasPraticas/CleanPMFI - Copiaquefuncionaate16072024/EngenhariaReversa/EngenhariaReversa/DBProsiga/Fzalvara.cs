using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Fzalvara
    {
        public long FzalvId { get; set; }
        public int? FzalvaraNum { get; set; }
        public int? FzalvaraAno { get; set; }
        public DateTime? FzalvaraDataEm { get; set; }
        public DateTime? FzalvaraVenc { get; set; }
        public long? PropId { get; set; }
    }
}
