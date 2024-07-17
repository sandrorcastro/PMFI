using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TmpDspLiquidacoesDoctosItensCmfi
    {
        public int? IdLiquidacaoDoctoItem { get; set; }
        public int? IdLiquidacaoDocto { get; set; }
        public int? IdItem { get; set; }
        public int? NrLote { get; set; }
        public int? IdNatDespesa { get; set; }
        public decimal? NrQtde { get; set; }
        public decimal? VlTotal { get; set; }
        public decimal? VlDesconto { get; set; }
        public int? Idempenho { get; set; }
    }
}
