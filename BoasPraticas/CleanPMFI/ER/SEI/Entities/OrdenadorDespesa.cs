using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class OrdenadorDespesa
{
    public int IdOrdenadorDespesa { get; set; }

    public int IdUsuario { get; set; }

    public int IdOrgao { get; set; }

    public int IdUnidade { get; set; }

    public string SinPadrao { get; set; } = null!;

    public virtual Orgao IdOrgaoNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
