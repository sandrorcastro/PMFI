using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeTipoMovimentacao
{
    public int IdTipoMovimentacao { get; set; }

    public string? DsTipoMovimentacao { get; set; }

    public string? DsTipoGrupo { get; set; }
}
