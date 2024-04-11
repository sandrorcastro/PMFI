using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspEstornosPagamentoDoctoNatureza
{
    public int IdEstorno { get; set; }

    public int IdLiquidacaoDocto { get; set; }

    public int IdNatDespesa { get; set; }

    public decimal? VlEstorno { get; set; }

    public decimal? VlRetencao { get; set; }
}
