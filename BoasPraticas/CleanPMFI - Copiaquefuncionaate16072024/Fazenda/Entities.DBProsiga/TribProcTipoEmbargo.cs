using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribProcTipoEmbargo
{
    public int ProcTipoEmbId { get; set; }

    public string? ProcTipoEmbNome { get; set; }

    public virtual ICollection<TribProcEmbargoTipo> TribProcEmbargoTipos { get; set; } = new List<TribProcEmbargoTipo>();
}
