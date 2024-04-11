using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscOrdemFiscalizacaoAnexo
{
    public int AnexoId { get; set; }

    public int? FiscOfid { get; set; }

    public int? ObjetoId { get; set; }

    public string? AnexoObs { get; set; }
}
