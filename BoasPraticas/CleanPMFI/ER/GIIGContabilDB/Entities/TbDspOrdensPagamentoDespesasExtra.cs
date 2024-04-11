using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspOrdensPagamentoDespesasExtra
{
    public int IdOrdemPagamento { get; set; }

    public int IdDespesa { get; set; }

    public decimal? VlPagamento { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public virtual TbDspDespesaExtraOrcamentarium IdDespesaNavigation { get; set; } = null!;

    public virtual TbDspOrdensPagamento IdOrdemPagamentoNavigation { get; set; } = null!;
}
