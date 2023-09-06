using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinEstornoDetalheOrdemCredito
    {
        public int IdEstornoDetalhe { get; set; }
        public int? IdDetalhe { get; set; }
        public int? IdOrdemCredito { get; set; }
        public int? IdLiquidacaoDocto { get; set; }
        public int? IdPagamento { get; set; }
        public int? IdEstorno { get; set; }
        public string? DsTipo { get; set; }
        public int? NrSequencia { get; set; }
        public string? DsMotivo { get; set; }
        public DateTime? DtEstorno { get; set; }
        public decimal? VlEstorno { get; set; }
        public decimal? VlRetencao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public short? NrAno { get; set; }
    }
}
