using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class PubTipoDocumento
{
    public int TipoId { get; set; }

    public string? TipoDescricao { get; set; }

    public virtual ICollection<PubDocumento> PubDocumentos { get; set; } = new List<PubDocumento>();
}
