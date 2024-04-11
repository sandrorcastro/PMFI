using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbDivTipoNaturezaCredito
{
    public short IdTipoNaturezaCredito { get; set; }

    public string? DsTipoNaturezaCredito { get; set; }

    public virtual ICollection<TbDivTipoCredito> TbDivTipoCreditos { get; set; } = new List<TbDivTipoCredito>();
}
