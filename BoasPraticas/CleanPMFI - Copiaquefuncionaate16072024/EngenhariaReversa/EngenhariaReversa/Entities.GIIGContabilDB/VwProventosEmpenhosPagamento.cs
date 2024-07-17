using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class VwProventosEmpenhosPagamento
    {
        public string? CdProvento { get; set; }
        public string TpDespesa { get; set; } = null!;
        public short? NrEmpenho { get; set; }
        public short? NrAnoEmpenho { get; set; }
        public int? EmpresaOrigem { get; set; }
        public short? NrAnoOperacaoBancoCaixa { get; set; }
        public int NrOperacaoBancoCaixa { get; set; }
        public int? IdTipoOperacaoPagamento { get; set; }
        public decimal? VlPagamento { get; set; }
        public string? CdContaExtraOuDesconto { get; set; }
        public string? DsContaExtraOuDesconto { get; set; }
        public decimal VlEstornadoEmpenho { get; set; }
        public decimal VlEstornadoPagamento { get; set; }
    }
}
