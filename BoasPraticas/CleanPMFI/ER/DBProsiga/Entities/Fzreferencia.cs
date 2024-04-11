using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Fzreferencia
{
    public int TxReferId { get; set; }

    public decimal? TxReferValor { get; set; }

    /// <summary>
    /// valores de referencias para as taxas
    /// </summary>
    public string? TxReferNome { get; set; }

    public virtual ICollection<Fztaxa> Fztaxas { get; set; } = new List<Fztaxa>();
}
