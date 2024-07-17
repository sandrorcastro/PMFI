using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class WflowTipoProcesso
    {
        public WflowTipoProcesso()
        {
            WflowFluxoTramitacaos = new HashSet<WflowFluxoTramitacao>();
        }

        public long TipoProcId { get; set; }
        public string? WorkFlow { get; set; }
        public string? TipoProcNome { get; set; }

        public virtual ICollection<WflowFluxoTramitacao> WflowFluxoTramitacaos { get; set; }
    }
}
