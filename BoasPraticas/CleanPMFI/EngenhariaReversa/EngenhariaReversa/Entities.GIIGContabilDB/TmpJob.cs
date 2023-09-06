using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TmpJob
    {
        public int? IdPessoa { get; set; }
        public int? NrEstorno { get; set; }
        public short? NrAnoEstorno { get; set; }
        public int? IdOperacaoConta { get; set; }
        public short? NrAnoOperacaoConta { get; set; }
        public string? DtEstorno { get; set; }
        public decimal? VlLancamento { get; set; }
        public string? DsMotivo { get; set; }
        public int? Idlancamentodiario { get; set; }
    }
}
