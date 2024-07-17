using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspEmpenhosCompoentesDespesa
    {
        public int IdEmpenho { get; set; }
        public short IdComponente { get; set; }
        public decimal? VlDespesa { get; set; }

        public virtual TbDspComponentesDespesa IdComponenteNavigation { get; set; } = null!;
        public virtual TbDspEmpenho IdEmpenhoNavigation { get; set; } = null!;
    }
}
