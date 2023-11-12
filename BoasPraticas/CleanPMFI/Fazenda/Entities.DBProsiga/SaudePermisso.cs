using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SaudePermisso
{
    public string PrmIdForm { get; set; } = null!;

    public string PrmIdUsuario { get; set; } = null!;

    public long LocId { get; set; }

    public string? PrmInclusao { get; set; }

    public string? PrmAlteracao { get; set; }

    public string? PrmRemocao { get; set; }

    public string? PrmRelatorios { get; set; }

    public string? PrmConsultas { get; set; }
}
