using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class ProdRurNaturezaOperacao
{
    public int IdnatOperacao { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<ProdRurNotaFiscal> ProdRurNotaFiscals { get; set; } = new List<ProdRurNotaFiscal>();
}
