using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspItensNaturezasDespesa
    {
        public int IdItem { get; set; }
        public string CdNatDespesa { get; set; } = null!;

        public virtual TbDspIten IdItemNavigation { get; set; } = null!;
    }
}
