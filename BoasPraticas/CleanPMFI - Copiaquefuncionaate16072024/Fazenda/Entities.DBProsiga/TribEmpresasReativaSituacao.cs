using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribEmpresasReativaSituacao
{
    public long EmprReativaId { get; set; }

    public long MovSitId { get; set; }

    public DateTime? EmprReatData { get; set; }

    public string? EmprReatMotivo { get; set; }

    public virtual TribEmpresasMovSituacao MovSit { get; set; } = null!;
}
