using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribSimuladosIptutestada
    {
        public int SimuId { get; set; }
        public long EdificacaoId { get; set; }
        public int LogradId { get; set; }
        public string? TestadasPrincipal { get; set; }
        public decimal? TestadasMetragem { get; set; }
        public int? SecaoId { get; set; }
        public long? FatorKid { get; set; }

        public virtual TribSimuladosIptuimovei TribSimuladosIptuimovei { get; set; } = null!;
    }
}
