using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsDevolucaoSaldo
{
    public int IdDevolucaoSaldo { get; set; }

    public int? IdSubvencaoSocial { get; set; }

    public string? CdTipoDocPagamento { get; set; }

    public string? NrDocDevolucao { get; set; }

    public DateTime? DtDevolucao { get; set; }

    public decimal? VlDevolucao { get; set; }

    public virtual TbSbsSubvencaoSocial? IdSubvencaoSocialNavigation { get; set; }
}
