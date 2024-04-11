using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class AtributoAndamento
{
    public int IdAtributoAndamento { get; set; }

    public int IdAtividade { get; set; }

    public string Nome { get; set; } = null!;

    public string? Valor { get; set; }

    public string? IdOrigem { get; set; }

    public virtual Atividade IdAtividadeNavigation { get; set; } = null!;
}
