using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspPrestacaoContasAdiantamento
    {
        public int IdPrestacaoAdiantamento { get; set; }
        public int? IdEmpenho { get; set; }
        public DateTime? DtPrestacaoAdiantamento { get; set; }
        public string? DsPrestacaoAdiantamento { get; set; }
        public decimal? VlConsumido { get; set; }
        public decimal? VlNaoUtilizado { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
    }
}
