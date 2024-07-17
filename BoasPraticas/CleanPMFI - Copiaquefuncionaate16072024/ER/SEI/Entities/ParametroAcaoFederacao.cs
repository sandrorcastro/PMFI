using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class ParametroAcaoFederacao
{
    public string IdAcaoFederacao { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public virtual AcaoFederacao IdAcaoFederacaoNavigation { get; set; } = null!;
}
