using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class AmmLiquidacao
    {
        public decimal? IdPessoa { get; set; }
        public decimal? NrLiquidacao { get; set; }
        public decimal? NrAno { get; set; }
        public decimal? NrEmpenho { get; set; }
        public string? DtLiquidacao { get; set; }
        public decimal? VlLiquidacao { get; set; }
        public string? VlTotalEstorno { get; set; }
        public string? VlTotalPagamentoLiq { get; set; }
    }
}
