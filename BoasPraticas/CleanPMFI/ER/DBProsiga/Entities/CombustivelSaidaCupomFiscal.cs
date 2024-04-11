using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class CombustivelSaidaCupomFiscal
{
    public long NumLanc { get; set; }

    public long? NumDocFiscal { get; set; }

    public long? Reqnum { get; set; }

    public decimal QtdeLitrosAbast { get; set; }

    public DateTime Datalanc { get; set; }

    public DateTime? DataDocFiscal { get; set; }

    public decimal? ValorCupom { get; set; }

    public decimal? KmAnterior { get; set; }

    public decimal? KmAtual { get; set; }

    public virtual CombustivelSaidum? ReqnumNavigation { get; set; }
}
