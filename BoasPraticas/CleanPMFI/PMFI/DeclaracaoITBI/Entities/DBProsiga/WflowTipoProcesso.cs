using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class WflowTipoProcesso
{
    public long TipoProcId { get; set; }

    public string? WorkFlow { get; set; }

    public string? TipoProcNome { get; set; }

    public virtual ICollection<WflowFluxoTramitacao> WflowFluxoTramitacaos { get; set; } = new List<WflowFluxoTramitacao>();
}
