using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class RhvinculoEmpregaticio
{
    public long VincEid { get; set; }

    public string? VincEnome { get; set; }

    public virtual ICollection<RhdadosFuncionai> RhdadosFuncionais { get; set; } = new List<RhdadosFuncionai>();
}
