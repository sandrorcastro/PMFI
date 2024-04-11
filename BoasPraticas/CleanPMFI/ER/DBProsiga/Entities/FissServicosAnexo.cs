using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FissServicosAnexo
{
    public long AnexId { get; set; }

    public long? ServId { get; set; }

    public byte[]? AnexDocumento { get; set; }

    public string? AnexDescricao { get; set; }

    public string? AnexExtensao { get; set; }

    public virtual FissServico? Serv { get; set; }
}
