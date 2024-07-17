using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class WflowRequisicao
{
    public long RequiId { get; set; }

    public string? RequiJust { get; set; }

    public string? RequiSolicitante { get; set; }

    public DateTime? RequiData { get; set; }

    public virtual ICollection<WflowRemessa> WflowRemessas { get; set; } = new List<WflowRemessa>();

    public virtual ICollection<WflowRequisicaoIten> WflowRequisicaoItens { get; set; } = new List<WflowRequisicaoIten>();
}
