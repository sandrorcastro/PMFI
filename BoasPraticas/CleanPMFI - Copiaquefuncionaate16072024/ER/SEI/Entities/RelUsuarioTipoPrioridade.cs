using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RelUsuarioTipoPrioridade
{
    public int IdUnidade { get; set; }

    public int IdUsuario { get; set; }

    public int IdTipoPrioridade { get; set; }

    public virtual TipoPrioridade IdTipoPrioridadeNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
