using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribProcTipoEmbargo
{
    public int ProcTipoEmbId { get; set; }

    public string? ProcTipoEmbNome { get; set; }

    public virtual ICollection<TribProcEmbargoTipo> TribProcEmbargoTipos { get; set; } = new List<TribProcEmbargoTipo>();
}
