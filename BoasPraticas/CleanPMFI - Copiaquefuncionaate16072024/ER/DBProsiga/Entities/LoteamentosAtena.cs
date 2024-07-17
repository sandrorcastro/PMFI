using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class LoteamentosAtena
{
    public int Idloteamento { get; set; }

    public string? Descricao { get; set; }

    public int? IdRegiao { get; set; }
}
