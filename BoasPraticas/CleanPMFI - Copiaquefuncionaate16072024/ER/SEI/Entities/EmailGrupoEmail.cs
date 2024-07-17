using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class EmailGrupoEmail
{
    public int IdEmailGrupoEmail { get; set; }

    public int IdGrupoEmail { get; set; }

    public string Email { get; set; } = null!;

    public string? Descricao { get; set; }

    public string? IdxEmailGrupoEmail { get; set; }

    public virtual GrupoEmail IdGrupoEmailNavigation { get; set; } = null!;
}
