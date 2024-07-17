using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribGruposEstabelecimento
{
    public string EstabGrupo { get; set; } = null!;

    public string? EstabGrupoNome { get; set; }

    public decimal QtdeUfmbombeiros { get; set; }

    public virtual ICollection<TribEmpresa> TribEmpresas { get; set; } = new List<TribEmpresa>();
}
