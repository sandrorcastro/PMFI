using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribBoletosBarra
{
    public string Bolenossonumero { get; set; } = null!;

    public byte[]? BoleCodigoBarra { get; set; }
}
