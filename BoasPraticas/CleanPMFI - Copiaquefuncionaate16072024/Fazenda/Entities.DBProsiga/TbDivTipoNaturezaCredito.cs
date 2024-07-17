using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TbDivTipoNaturezaCredito
{
    public short IdTipoNaturezaCredito { get; set; }

    public string? DsTipoNaturezaCredito { get; set; }

    public virtual ICollection<TbDivTipoCredito> TbDivTipoCreditos { get; set; } = new List<TbDivTipoCredito>();
}
