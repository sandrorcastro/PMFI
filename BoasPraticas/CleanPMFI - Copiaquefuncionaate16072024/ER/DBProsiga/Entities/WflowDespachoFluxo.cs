using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class WflowDespachoFluxo
{
    public string UsuId { get; set; } = null!;

    public long FluxoTramId { get; set; }

    public long DespPadraoId { get; set; }

    public string? Encaminhamento { get; set; }

    public string? Recebimentos { get; set; }

    public virtual WflowDespachoPadrao DespPadrao { get; set; } = null!;

    public virtual WflowFluxoTramitacao FluxoTram { get; set; } = null!;

    public virtual Usuario Usu { get; set; } = null!;
}
