using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class WflowTiposFluxo
{
    public long TipoFluxoId { get; set; }

    public string? TipoFluxoNome { get; set; }

    public string TipoFluxoRestringeOrgaoUnidade { get; set; } = null!;

    public string? TipoFluxoDescricao { get; set; }

    public virtual ICollection<WflowFluxoTramitacao> WflowFluxoTramitacaos { get; set; } = new List<WflowFluxoTramitacao>();
}
