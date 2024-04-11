using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAlvTipoCalculo
{
    public short IdTipoCalculo { get; set; }

    public string? DsTipoCalculo { get; set; }

    public int? TipoTribId { get; set; }

    public virtual TribTipoTributo? TipoTrib { get; set; }

    public virtual ICollection<TribAlvFormula> TribAlvFormulas { get; set; } = new List<TribAlvFormula>();
}
