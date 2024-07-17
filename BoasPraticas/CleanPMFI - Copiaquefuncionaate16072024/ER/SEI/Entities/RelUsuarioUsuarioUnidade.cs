using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RelUsuarioUsuarioUnidade
{
    public int IdUsuario { get; set; }

    public int IdUsuarioAtribuicao { get; set; }

    public int IdUnidade { get; set; }

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioAtribuicaoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
