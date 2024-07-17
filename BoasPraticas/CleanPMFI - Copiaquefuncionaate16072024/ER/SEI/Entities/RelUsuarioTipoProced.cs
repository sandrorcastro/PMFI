using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RelUsuarioTipoProced
{
    public int IdUsuario { get; set; }

    public int IdTipoProcedimento { get; set; }

    public int IdUnidade { get; set; }

    public virtual TipoProcedimento IdTipoProcedimentoNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
