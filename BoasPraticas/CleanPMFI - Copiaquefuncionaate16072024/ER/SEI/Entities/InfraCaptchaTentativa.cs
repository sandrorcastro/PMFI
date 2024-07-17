using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class InfraCaptchaTentativa
{
    public string Identificacao { get; set; } = null!;

    public string IdUsuarioOrigem { get; set; } = null!;

    public int Tentativas { get; set; }

    public DateTime DthTentativa { get; set; }

    public string UserAgent { get; set; } = null!;

    public string Ip { get; set; } = null!;
}
