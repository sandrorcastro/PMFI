using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class VisaoSimulado4
    {
        public int SimuId { get; set; }
        public long EdificacaoId { get; set; }
        public decimal? ValorVenalCalculo { get; set; }
    }
}
