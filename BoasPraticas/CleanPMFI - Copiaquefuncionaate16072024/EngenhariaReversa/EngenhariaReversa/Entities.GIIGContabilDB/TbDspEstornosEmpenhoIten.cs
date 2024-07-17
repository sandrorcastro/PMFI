using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspEstornosEmpenhoIten
    {
        public int IdEstornoItem { get; set; }
        public int IdEstorno { get; set; }
        public int IdItem { get; set; }
        public int? NrLote { get; set; }
        public string? DsItemCompl { get; set; }
        public decimal? NrQtde { get; set; }
        public decimal? VlTotal { get; set; }
        public int? IdNatDespesa { get; set; }

        public virtual TbDspEstornosEmpenho IdEstornoNavigation { get; set; } = null!;
    }
}
