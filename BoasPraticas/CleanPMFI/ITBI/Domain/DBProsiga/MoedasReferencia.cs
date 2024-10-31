using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class MoedasReferencia
    {
        public short Idmoeda { get; set; }
        public DateTime DataReferencia { get; set; }
        public decimal? ValorReferencia { get; set; }

        public virtual Moeda IdmoedaNavigation { get; set; } = null!;
    }
}
