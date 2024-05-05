using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribLegislacao
{
    public int LeiId { get; set; }

    public string? LeiNome { get; set; }

    public DateTime? LeiData { get; set; }

    public string? Epigrafe { get; set; }

    public string? Ementa { get; set; }

    public string? Preambulo { get; set; }

    public virtual ICollection<TribLegislacaoComponente> LeiComps { get; set; } = new List<TribLegislacaoComponente>();
}
