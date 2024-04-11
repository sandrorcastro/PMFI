using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspCodigosPagamentoInss
{
    public short CdPagamento { get; set; }

    public string? DsPagamento { get; set; }

    public virtual ICollection<TbDspGp> TbDspGps { get; set; } = new List<TbDspGp>();
}
