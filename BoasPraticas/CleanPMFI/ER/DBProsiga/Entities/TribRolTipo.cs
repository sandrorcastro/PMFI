using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribRolTipo
{
    public short RolTipoId { get; set; }

    public int RolTipoAno { get; set; }

    public DateTime RolTipoData { get; set; }

    public string RolTipoNome { get; set; } = null!;

    public string? RolTipoDescricao { get; set; }
}
