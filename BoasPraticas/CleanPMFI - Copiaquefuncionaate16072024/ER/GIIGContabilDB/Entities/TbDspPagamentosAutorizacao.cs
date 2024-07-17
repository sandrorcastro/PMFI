using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspPagamentosAutorizacao
{
    public int IdPagamentoAutorizacao { get; set; }

    public int? IdEmpenho { get; set; }

    public string? DsSituacao { get; set; }

    public string? DsMotivo { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public virtual ICollection<TbDspLiquidaco> IdLiquidacaos { get; set; } = new List<TbDspLiquidaco>();
}
