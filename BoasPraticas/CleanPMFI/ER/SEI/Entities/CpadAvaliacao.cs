using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class CpadAvaliacao
{
    public int IdCpadAvaliacao { get; set; }

    public int IdAvaliacaoDocumental { get; set; }

    public int IdCpadComposicao { get; set; }

    public DateTime DthAvaliacao { get; set; }

    public string StaCpadAvaliacao { get; set; } = null!;

    public string? Motivo { get; set; }

    public string? Justificativa { get; set; }

    public string SinAtivo { get; set; } = null!;

    public virtual AvaliacaoDocumental IdAvaliacaoDocumentalNavigation { get; set; } = null!;

    public virtual CpadComposicao IdCpadComposicaoNavigation { get; set; } = null!;
}
