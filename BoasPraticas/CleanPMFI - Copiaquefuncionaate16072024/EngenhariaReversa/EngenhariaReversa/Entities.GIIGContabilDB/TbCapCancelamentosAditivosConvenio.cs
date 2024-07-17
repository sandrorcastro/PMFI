using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapCancelamentosAditivosConvenio
    {
        public int IdCancelamento { get; set; }
        public int IdAditivo { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public string? DsMotivo { get; set; }

        public virtual TbCapAditivosConvenio IdAditivoNavigation { get; set; } = null!;
    }
}
