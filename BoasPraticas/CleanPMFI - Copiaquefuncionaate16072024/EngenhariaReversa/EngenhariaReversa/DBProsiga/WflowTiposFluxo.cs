using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class WflowTiposFluxo
    {
        public WflowTiposFluxo()
        {
            WflowFluxoTramitacaos = new HashSet<WflowFluxoTramitacao>();
        }

        public long TipoFluxoId { get; set; }
        public string? TipoFluxoNome { get; set; }
        public string TipoFluxoRestringeOrgaoUnidade { get; set; } = null!;
        public string? TipoFluxoDescricao { get; set; }

        public virtual ICollection<WflowFluxoTramitacao> WflowFluxoTramitacaos { get; set; }
    }
}
