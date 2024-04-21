using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class WflowDespachoPadrao
{
    public long DespPadraoId { get; set; }

    public string? DespPadraoNome { get; set; }

    public string? InterrompeFluxo { get; set; }

    public string? CancelaRequisicao { get; set; }

    public string? RetornaOrigem { get; set; }

    public string? AprovaRequisicao { get; set; }

    public virtual ICollection<WflowDespachoFluxo> WflowDespachoFluxos { get; set; } = new List<WflowDespachoFluxo>();

    public virtual ICollection<WflowRemessa> WflowRemessas { get; set; } = new List<WflowRemessa>();
}
