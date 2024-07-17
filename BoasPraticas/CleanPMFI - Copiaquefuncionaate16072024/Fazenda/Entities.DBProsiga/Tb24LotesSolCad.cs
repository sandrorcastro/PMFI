using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Tb24LotesSolCad
{
    public int IdLotes { get; set; }

    public int IdProjeto { get; set; }

    public string? DsIndFiscal { get; set; }

    public string? DsSubLote { get; set; }

    public string? DsAreaAtingida { get; set; }

    public bool? FlLotePrincipal { get; set; }

    public decimal? NrAreaTerreno { get; set; }

    public decimal? NrDifLoteMenor { get; set; }
}
