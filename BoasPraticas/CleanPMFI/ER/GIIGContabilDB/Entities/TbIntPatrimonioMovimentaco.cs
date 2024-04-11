using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbIntPatrimonioMovimentaco
{
    public int IdMovimento { get; set; }

    public short? IdEmpresa { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public DateTime? DtMovimento { get; set; }

    public decimal? VlMovimento { get; set; }

    public string? TpBem { get; set; }

    public string? TpOperacao { get; set; }

    public string? CdNaturezaItem { get; set; }

    public string? CdContaContabil { get; set; }

    public int? IdBem { get; set; }

    public int? IdLancPatrimonio { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public string? DsHistorico { get; set; }
}
