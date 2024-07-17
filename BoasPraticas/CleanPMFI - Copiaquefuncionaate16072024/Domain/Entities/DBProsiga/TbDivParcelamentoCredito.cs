using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbDivParcelamentoCredito
    {
        public int IdParcelamento { get; set; }
        public int? IdCredito { get; set; }
        public string? TpCredito { get; set; }
        public int? NrParcelamento { get; set; }
        public short? NrAnoParcelamento { get; set; }
        public string? TpParcelamento { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public short? NrParcelas { get; set; }
        public int? IdLeiAto { get; set; }
        public decimal? VlParcelamento { get; set; }

        public virtual TbDivLancamentoCredito? IdCreditoNavigation { get; set; }
    }
}
