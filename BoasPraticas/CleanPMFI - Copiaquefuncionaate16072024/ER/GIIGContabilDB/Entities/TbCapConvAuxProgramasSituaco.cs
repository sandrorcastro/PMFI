using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCapConvAuxProgramasSituaco
{
    public int IdCapSit { get; set; }

    public int IdRecurso { get; set; }

    public short IdSituacao { get; set; }

    public DateTime? DtSituacao { get; set; }

    public string? DsObs { get; set; }

    public string? DsLogin { get; set; }

    public short? NrSequencial { get; set; }

    public virtual TbCapConvAuxPrograma IdRecursoNavigation { get; set; } = null!;

    public virtual TbCapSituaco IdSituacaoNavigation { get; set; } = null!;
}
