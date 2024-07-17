using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VwCepcorreio
{
    public string? Cep { get; set; }

    public string? TipoLogradouro { get; set; }

    public string? Logradouro { get; set; }

    public string? BairroNovo { get; set; }

    public string Flexistenosite { get; set; } = null!;
}
