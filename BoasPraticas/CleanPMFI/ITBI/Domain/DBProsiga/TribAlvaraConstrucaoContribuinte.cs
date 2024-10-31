using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAlvaraConstrucaoContribuinte
    {
        public long Numero { get; set; }
        public long ConId { get; set; }

        public virtual Contribuinte Con { get; set; } = null!;
    }
}
