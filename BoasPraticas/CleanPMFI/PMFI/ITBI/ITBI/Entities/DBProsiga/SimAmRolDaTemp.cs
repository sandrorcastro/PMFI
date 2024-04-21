using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SimAmRolDaTemp
{
    public long CdDivida { get; set; }

    public long? IdPessoa { get; set; }

    public long? CdTributo { get; set; }

    public long? NrAnoDivida { get; set; }

    public long? NrAnoDividaAtiva { get; set; }

    public string? TpDocumento { get; set; }

    public string? NrdocumentoContratado { get; set; }

    public string? NmContribuinte { get; set; }

    public decimal? VlLancado { get; set; }

    public string? CodDivida { get; set; }
}
