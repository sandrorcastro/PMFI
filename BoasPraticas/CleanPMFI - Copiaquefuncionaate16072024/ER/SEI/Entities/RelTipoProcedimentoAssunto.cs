using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RelTipoProcedimentoAssunto
{
    public int IdTipoProcedimento { get; set; }

    public int Sequencia { get; set; }

    public int IdAssuntoProxy { get; set; }

    public virtual AssuntoProxy IdAssuntoProxyNavigation { get; set; } = null!;

    public virtual TipoProcedimento IdTipoProcedimentoNavigation { get; set; } = null!;
}
