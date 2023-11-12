using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class FzveiculosFoto
{
    public long VeiId { get; set; }

    public long FoveiId { get; set; }

    public byte[]? FoveiFoto { get; set; }

    public virtual Fzveiculo Vei { get; set; } = null!;
}
