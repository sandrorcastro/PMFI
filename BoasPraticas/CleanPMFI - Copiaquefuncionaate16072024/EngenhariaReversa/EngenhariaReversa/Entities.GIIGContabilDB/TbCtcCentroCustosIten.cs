using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCtcCentroCustosIten
    {
        public int IdCentroCusto { get; set; }
        public int IdItem { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }

        public virtual TbCtcCentroCusto IdCentroCustoNavigation { get; set; } = null!;
        public virtual TbDspIten IdItemNavigation { get; set; } = null!;
    }
}
