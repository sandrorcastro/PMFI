using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribSaneparLanc2009
    {
        public long Edificacaoid { get; set; }
        public int Parcela { get; set; }
        public DateTime? Vencimento { get; set; }
        public decimal? Valor { get; set; }
        public int? Tipobxid { get; set; }
        public int? TipotribId { get; set; }
    }
}
