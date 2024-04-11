using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAtivClasse
{
    public string AtivClasse { get; set; } = null!;

    public string? AtivClasseDenom { get; set; }

    public string? AtivGrupo { get; set; }

    public virtual TribAtivGrupo? AtivGrupoNavigation { get; set; }

    public virtual ICollection<TribAtivAtividade> TribAtivAtividades { get; set; } = new List<TribAtivAtividade>();
}
