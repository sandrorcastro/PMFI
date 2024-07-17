using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspEstornosPagamentoDocumento
{
    public int IdEstorno { get; set; }

    public int IdLiquidacaoDocto { get; set; }

    public decimal? VlEstorno { get; set; }

    public decimal? VlRetencoes { get; set; }
}
