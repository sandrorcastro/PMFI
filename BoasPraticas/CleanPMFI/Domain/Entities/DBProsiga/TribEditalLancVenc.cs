using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEditalLancVenc
    {
        public int EdVeId { get; set; }
        public int? EdiId { get; set; }
        public int? TipoTribId { get; set; }
        public short? EdVeParcela { get; set; }
        public DateTime? EdVeVencimento { get; set; }
        public string? EdVeParcelaUnica { get; set; }
        public decimal? EdVeDesconto { get; set; }
        public int? TipoTribIddesconto { get; set; }

        public virtual TribEditalLanc? Edi { get; set; }
    }
}
