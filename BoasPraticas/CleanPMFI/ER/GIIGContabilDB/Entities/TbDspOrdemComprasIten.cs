using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspOrdemComprasIten
{
    public int IdOrdemCompraItem { get; set; }

    public int IdOrdemCompra { get; set; }

    public int IdItem { get; set; }

    public decimal? NrQtde { get; set; }

    public decimal? VlTotal { get; set; }

    public int? NrLote { get; set; }

    public decimal? VlDesconto { get; set; }

    public virtual TbDspOrdemCompra IdOrdemCompraNavigation { get; set; } = null!;
}
