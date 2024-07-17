using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRecMovimentoReceitasRepass
{
    public int IdMovReceita { get; set; }

    public int? NrEmpenhoEstado { get; set; }

    public DateTime? DtEmpenhoEstado { get; set; }

    public decimal? VlEmpenhoEstado { get; set; }

    public decimal? VlLiquidacaoEstado { get; set; }

    public DateTime? DtLiquidacaoEstado { get; set; }

    public int? NrLiquidacaoEstado { get; set; }

    public virtual TbRecMovimentoReceita IdMovReceitaNavigation { get; set; } = null!;
}
