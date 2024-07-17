using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ProdRurImposto
{
    public int Idimposto { get; set; }

    public string? Nome { get; set; }

    public decimal? AliquotaPadrao { get; set; }

    public virtual ICollection<ProdRurNotaFiscalIten> ProdRurNotaFiscalItens { get; set; } = new List<ProdRurNotaFiscalIten>();
}
