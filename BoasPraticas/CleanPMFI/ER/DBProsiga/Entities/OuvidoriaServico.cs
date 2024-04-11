using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class OuvidoriaServico
{
    public int IdouvServico { get; set; }

    public string DescrServico { get; set; } = null!;

    public virtual ICollection<OuvidoriaProcesso> OuvidoriaProcessos { get; set; } = new List<OuvidoriaProcesso>();
}
