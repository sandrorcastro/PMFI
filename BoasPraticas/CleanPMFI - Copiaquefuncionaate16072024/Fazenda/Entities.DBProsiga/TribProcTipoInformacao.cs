using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribProcTipoInformacao
{
    public int ProcTipoInfoId { get; set; }

    public string? ProcTipoInfoNome { get; set; }

    public virtual ICollection<TribProcInfoComplementar> TribProcInfoComplementars { get; set; } = new List<TribProcInfoComplementar>();
}
