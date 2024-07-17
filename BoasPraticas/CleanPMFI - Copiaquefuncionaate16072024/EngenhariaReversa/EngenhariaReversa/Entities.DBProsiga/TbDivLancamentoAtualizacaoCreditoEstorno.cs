using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TbDivLancamentoAtualizacaoCreditoEstorno
    {
        public int IdAtualizacaoEstorno { get; set; }
        public int? IdAtualizacao { get; set; }
        public string? TpCredito { get; set; }
        public int? NrEstorno { get; set; }
        public short? NrAnoEstorno { get; set; }
        public int? IdLeiAto { get; set; }
        public DateTime? DtEstorno { get; set; }
        public decimal? VlEstorno { get; set; }
        public string? DsMotivo { get; set; }

        public virtual TbDivLancamentoAtualizacaoMonetariaCredito? IdAtualizacaoNavigation { get; set; }
    }
}
