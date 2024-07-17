using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinAutorizacaoPagamento
{
    public int IdAutorizacao { get; set; }

    public int? NrSequencia { get; set; }

    public short? NrAno { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public decimal? VlRetencoes { get; set; }

    public decimal? VlPagamento { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public string? FlSituacao { get; set; }

    public string? DsAutorizacao { get; set; }

    public DateTime? DtAnulacao { get; set; }

    public string? DsJustificativa { get; set; }

    public string? DsLoginAnulacao { get; set; }

    public string? DsTipo { get; set; }
}
