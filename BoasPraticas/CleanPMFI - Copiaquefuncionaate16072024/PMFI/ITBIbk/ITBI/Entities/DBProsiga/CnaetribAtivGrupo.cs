using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class CnaetribAtivGrupo
{
    public string AtivGrupo { get; set; } = null!;

    public string? AtivGrupoDenom { get; set; }

    public string? AtivDiv { get; set; }

    public virtual CnaetribAtivDivisao? AtivDivNavigation { get; set; }

    public virtual ICollection<CnaetribAtivClasse> CnaetribAtivClasses { get; set; } = new List<CnaetribAtivClasse>();
}
