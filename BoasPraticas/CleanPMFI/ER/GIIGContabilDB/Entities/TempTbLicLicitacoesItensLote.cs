using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TempTbLicLicitacoesItensLote
{
    public int NrLote { get; set; }

    public int IdLicitacaoItem { get; set; }

    public short? NrSequencia { get; set; }

    public decimal? NrQuantidade { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }
}
