using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SaudeTipoMovimentacao
{
    public int IdTipoMovimentacao { get; set; }

    public string? DsTipoMovimentacao { get; set; }

    public string? DsTipoGrupo { get; set; }
}
