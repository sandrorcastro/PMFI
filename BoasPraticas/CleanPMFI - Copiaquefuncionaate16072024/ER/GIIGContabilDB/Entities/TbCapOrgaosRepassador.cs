using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCapOrgaosRepassador
{
    public int IdOrgaoRepassador { get; set; }

    public string? DsOrgaoRepassador { get; set; }

    public int? IdTcerepassador { get; set; }

    public string? DsOrigem { get; set; }

    public int? IdPessoa { get; set; }

    public virtual ICollection<TbCapRecurso> TbCapRecursos { get; set; } = new List<TbCapRecurso>();
}
