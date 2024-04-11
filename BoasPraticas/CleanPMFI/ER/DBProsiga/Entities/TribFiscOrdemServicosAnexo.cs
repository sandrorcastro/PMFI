using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscOrdemServicosAnexo
{
    public int Anexid { get; set; }

    public int? FiscOsid { get; set; }

    public int? ObjetoId { get; set; }

    public string? AnexObs { get; set; }
}
