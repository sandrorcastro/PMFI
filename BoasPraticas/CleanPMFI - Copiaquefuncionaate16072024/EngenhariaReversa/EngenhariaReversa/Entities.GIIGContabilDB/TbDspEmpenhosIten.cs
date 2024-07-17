using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspEmpenhosIten
    {
        public int IdEmpenhoItem { get; set; }
        public int IdEmpenho { get; set; }
        public int IdItem { get; set; }
        public string? DsItemCompl { get; set; }
        public decimal? NrQtde { get; set; }
        public decimal? VlUnitario { get; set; }
        public decimal? VlTotal { get; set; }
        public int? IdNatDespesa { get; set; }
        public string? DsMarca { get; set; }
        public int? NrLote { get; set; }

        public virtual TbDspEmpenho IdEmpenhoNavigation { get; set; } = null!;
        public virtual TbDspIten IdItemNavigation { get; set; } = null!;
    }
}
