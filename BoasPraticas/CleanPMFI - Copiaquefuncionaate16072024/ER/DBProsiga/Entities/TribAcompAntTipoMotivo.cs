using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAcompAntTipoMotivo
{
    public int AcoTipoId { get; set; }

    public string? AcoTipoDescricao { get; set; }

    public virtual ICollection<TribAcompAnterior> TribAcompAnteriors { get; set; } = new List<TribAcompAnterior>();
}
