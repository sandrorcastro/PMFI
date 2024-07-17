using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class LrfInscricaoSaldoDividaAtiva
{
    public string? IdPessoa { get; set; }

    public string? CdTributo { get; set; }

    public string? CdDivida { get; set; }

    public string? NrAnoDividaAtiva { get; set; }

    public string? NrAnoDivida { get; set; }

    public string? TpDocumento { get; set; }

    public string? NrDocumentoContratado { get; set; }

    public string? NmContribuinte { get; set; }

    public decimal? VlLancado { get; set; }

    public string? NrBimestreInclusao { get; set; }

    public string? NrAnoInclusao { get; set; }
}
