using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbDivLancamentoCreditoEstorno
    {
        public int IdEstono { get; set; }
        public int? IdLancamento { get; set; }
        public int? NrEstono { get; set; }
        public short? NrAnoEstorno { get; set; }
        public int? IdLeiAto { get; set; }
        public DateTime? DtEstono { get; set; }
        public decimal? VlEstorno { get; set; }
        public string? DsMotivo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLoginInclusao { get; set; }

        public virtual TbDivLancamentoCredito? IdLancamentoNavigation { get; set; }
        public virtual TbGerLeiAto? IdLeiAtoNavigation { get; set; }
    }
}
