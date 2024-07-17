using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribArquivoPendenciasSn
{
    public long IdEventoEmpresa { get; set; }

    public string? DsArquivo { get; set; }

    public DateTime? DtArquivo { get; set; }

    public string? DsLogin { get; set; }
}
