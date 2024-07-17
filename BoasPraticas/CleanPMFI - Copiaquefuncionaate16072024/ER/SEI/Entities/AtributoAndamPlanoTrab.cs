using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class AtributoAndamPlanoTrab
{
    public int IdAtributoAndamPlanoTrab { get; set; }

    public int IdAndamentoPlanoTrabalho { get; set; }

    public string Chave { get; set; } = null!;

    public string? Valor { get; set; }

    public string? IdOrigem { get; set; }

    public virtual AndamentoPlanoTrabalho IdAndamentoPlanoTrabalhoNavigation { get; set; } = null!;
}
