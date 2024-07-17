using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbWflDespachosPadrao
{
    public short IdDespachoPadrao { get; set; }

    public string? NmDespachoPadrao { get; set; }

    public string? DsDespachoPadrao { get; set; }

    public string? FlInterrompeFluxo { get; set; }

    public string? FlCancelaRequisicao { get; set; }

    public string? FlRetornaOrigem { get; set; }

    public string? FlAprovaRequisicao { get; set; }

    public string? FlEncaminhaRmsLicitacao { get; set; }

    public string? FlDespachaEmpenho { get; set; }

    public string? FlRequisicaoPendente { get; set; }

    public virtual ICollection<TbWflDespachosFluxo> TbWflDespachosFluxos { get; set; } = new List<TbWflDespachosFluxo>();

    public virtual ICollection<TbWflRemessa> TbWflRemessas { get; set; } = new List<TbWflRemessa>();
}
