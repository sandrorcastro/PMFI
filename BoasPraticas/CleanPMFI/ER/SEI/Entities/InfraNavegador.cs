using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class InfraNavegador
{
    public long IdInfraNavegador { get; set; }

    public string Identificacao { get; set; } = null!;

    public string? Versao { get; set; }

    public string UserAgent { get; set; } = null!;

    public string? Ip { get; set; }

    public DateTime DthAcesso { get; set; }
}
