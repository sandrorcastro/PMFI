using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SysTabela
{
    public string Tabela { get; set; } = null!;

    public string? NomeAmigavel { get; set; }
}
