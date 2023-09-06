using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspEstornosPagamento
    {
        public int IdEstorno { get; set; }
        public int IdPagamento { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public short? NrSequencia { get; set; }
        public short? NrSequenciaAnual { get; set; }
        public DateTime? DtEstorno { get; set; }
        public decimal? VlEstorno { get; set; }
        public decimal? VlRetencao { get; set; }
        public string? DsMotivo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public int? IdEstornoOrigem { get; set; }
        public string? FlOrigem { get; set; }

        public virtual TbDspPagamento IdPagamentoNavigation { get; set; } = null!;
    }
}
