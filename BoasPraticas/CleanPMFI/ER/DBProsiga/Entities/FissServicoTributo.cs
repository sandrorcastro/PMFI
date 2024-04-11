using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FissServicoTributo
{
    public long ServId { get; set; }

    public int TipoTribId { get; set; }

    public long ServTribId { get; set; }

    public virtual FissServico Serv { get; set; } = null!;

    public virtual TribTipoTributo TipoTrib { get; set; } = null!;
}
