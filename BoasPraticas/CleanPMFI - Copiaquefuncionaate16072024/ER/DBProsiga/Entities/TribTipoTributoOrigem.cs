using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribTipoTributoOrigem
{
    public short TrOrId { get; set; }

    public string? TrOrDescricao { get; set; }

    public virtual ICollection<TribTipoTributo> TribTipoTributos { get; set; } = new List<TribTipoTributo>();
}
