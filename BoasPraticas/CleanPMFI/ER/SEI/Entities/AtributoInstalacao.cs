using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class AtributoInstalacao
{
    public int IdAtributoInstalacao { get; set; }

    public int IdAndamentoInstalacao { get; set; }

    public string Nome { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public string? IdOrigem { get; set; }

    public virtual AndamentoInstalacao IdAndamentoInstalacaoNavigation { get; set; } = null!;
}
