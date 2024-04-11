using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspOrdensPagamentoDocumento
{
    public int IdOrdemPagamento { get; set; }

    public int IdLiquidacaoDocto { get; set; }

    public decimal? VlPagamento { get; set; }

    public decimal? VlRetencoes { get; set; }

    public string? DsSituacao { get; set; }

    public virtual TbDspLiquidacoesDocumento IdLiquidacaoDoctoNavigation { get; set; } = null!;

    public virtual TbDspOrdensPagamento IdOrdemPagamentoNavigation { get; set; } = null!;
}
