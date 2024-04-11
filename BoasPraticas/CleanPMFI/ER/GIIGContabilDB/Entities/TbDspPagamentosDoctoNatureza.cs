using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspPagamentosDoctoNatureza
{
    public int IdPagamento { get; set; }

    public int IdLiquidacaoDocto { get; set; }

    public int IdNatDespesa { get; set; }

    public decimal? VlPagamento { get; set; }

    public decimal? VlRetencao { get; set; }
}
