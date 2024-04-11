using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRelBalanco
{
    public short IdRelatorio { get; set; }

    public string? DsRelatorio { get; set; }

    public string? DsFormatacaoPeriodo { get; set; }

    public string? DsAnexo { get; set; }

    public string? DsMoedaReferencia { get; set; }

    public string? DsFonte { get; set; }

    public string? DsNotas { get; set; }

    public virtual ICollection<TbRelBalancosDetalhe> TbRelBalancosDetalhes { get; set; } = new List<TbRelBalancosDetalhe>();
}
