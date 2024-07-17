using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SisParametro
{
    public string SiPaIdSistema { get; set; } = null!;

    public string SiPaIdParametro { get; set; } = null!;

    public string? SiPaDescrParametro { get; set; }

    public string? SiPaValorParametro { get; set; }
}
