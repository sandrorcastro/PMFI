using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TiposDocumentosOficiai
{
    public long IdtipoDoc { get; set; }

    public string? NomeDoc { get; set; }

    public virtual ICollection<ParametroAssinatura> ParametroAssinaturas { get; set; } = new List<ParametroAssinatura>();
}
