using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspPagamentosAporte
{
    public int IdPagamento { get; set; }

    public int IdAporte { get; set; }

    public decimal? VlPagamento { get; set; }

    public virtual TbRecMovimentoReceitasAporte IdAporteNavigation { get; set; } = null!;

    public virtual TbDspPagamento IdPagamentoNavigation { get; set; } = null!;
}
