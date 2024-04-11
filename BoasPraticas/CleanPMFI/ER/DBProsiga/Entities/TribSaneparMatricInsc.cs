using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribSaneparMatricInsc
{
    public string SaneMatricula { get; set; } = null!;

    public long EdificacaoId { get; set; }

    public string? SainObservacao { get; set; }
}
