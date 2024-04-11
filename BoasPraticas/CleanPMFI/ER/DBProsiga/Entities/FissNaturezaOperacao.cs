using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FissNaturezaOperacao
{
    public long NatOpId { get; set; }

    public string? NatOpDescricao { get; set; }

    public string? NatOpIsenta { get; set; }

    public string NatOpAlteraVlrServico { get; set; } = null!;

    public virtual ICollection<FissDocFiscai> FissDocFiscais { get; set; } = new List<FissDocFiscai>();
}
