using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SysTabela
{
    public string Tabela { get; set; } = null!;

    public string? NomeAmigavel { get; set; }
}
