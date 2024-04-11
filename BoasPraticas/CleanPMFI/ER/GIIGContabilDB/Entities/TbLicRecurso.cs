using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicRecurso
{
    public int IdLicitacao { get; set; }

    public int IdRecurso { get; set; }

    public DateTime? DtVinculacao { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public virtual TbLicLicitaco IdLicitacaoNavigation { get; set; } = null!;

    public virtual TbCapRecurso IdRecursoNavigation { get; set; } = null!;
}
