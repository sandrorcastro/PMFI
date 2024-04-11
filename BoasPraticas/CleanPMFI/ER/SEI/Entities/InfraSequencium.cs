using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class InfraSequencium
{
    public string NomeTabela { get; set; } = null!;

    public long QtdIncremento { get; set; }

    public long NumAtual { get; set; }

    public long NumMaximo { get; set; }
}
