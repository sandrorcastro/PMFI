using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribReportPar
{
    public int RparId { get; set; }

    public string? RparSessionId { get; set; }

    public string? RparParametro { get; set; }

    public string? RparTipo { get; set; }

    public string? RparValor { get; set; }
}
