using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbWflDespachosFluxo
{
    public string DsLogin { get; set; } = null!;

    public short IdFluxoTramitacao { get; set; }

    public short IdDespachoPadrao { get; set; }

    public string? FlEncaminhamento { get; set; }

    public string? FlRecebimento { get; set; }

    public virtual TbWflDespachosPadrao IdDespachoPadraoNavigation { get; set; } = null!;

    public virtual TbWflFluxosTramitacao IdFluxoTramitacaoNavigation { get; set; } = null!;
}
