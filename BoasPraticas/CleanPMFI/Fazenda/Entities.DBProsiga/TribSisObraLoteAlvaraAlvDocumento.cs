using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribSisObraLoteAlvaraAlvDocumento
{
    public int IdloteAlvara { get; set; }

    public int IdDocumento { get; set; }

    public string? FlSituacao { get; set; }

    public string? RetornoProtocolo { get; set; }

    public string? RetornoNumero { get; set; }

    public int? Idmensagem { get; set; }

    public virtual TribAlvDocumento IdDocumentoNavigation { get; set; } = null!;

    public virtual TribSisObraLoteAlvara IdloteAlvaraNavigation { get; set; } = null!;
}
