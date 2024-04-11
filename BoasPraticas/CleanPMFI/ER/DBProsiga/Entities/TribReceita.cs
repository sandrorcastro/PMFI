using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribReceita
{
    public string RecId { get; set; } = null!;

    public int RecAno { get; set; }

    public string? RecNome { get; set; }
}
