using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class NivelAcessoPermitido
{
    public int IdNivelAcessoPermitido { get; set; }

    public int IdTipoProcedimento { get; set; }

    public string StaNivelAcesso { get; set; } = null!;

    public virtual TipoProcedimento IdTipoProcedimentoNavigation { get; set; } = null!;
}
