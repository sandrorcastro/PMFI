using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class CnaetribAtivClasse
{
    public string AtivClasse { get; set; } = null!;

    public string? AtivClasseDenom { get; set; }

    public string? AtivGrupo { get; set; }

    public virtual CnaetribAtivGrupo? AtivGrupoNavigation { get; set; }

    public virtual ICollection<CnaetribAtivAtividade> CnaetribAtivAtividades { get; set; } = new List<CnaetribAtivAtividade>();
}
