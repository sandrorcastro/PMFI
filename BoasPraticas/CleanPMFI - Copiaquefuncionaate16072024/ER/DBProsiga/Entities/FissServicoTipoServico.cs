using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FissServicoTipoServico
{
    public long ServId { get; set; }

    public long ServTpId { get; set; }

    public long? ProcId { get; set; }

    public virtual Processo? Proc { get; set; }

    public virtual FissServico Serv { get; set; } = null!;

    public virtual FissTipoServico ServTp { get; set; } = null!;
}
