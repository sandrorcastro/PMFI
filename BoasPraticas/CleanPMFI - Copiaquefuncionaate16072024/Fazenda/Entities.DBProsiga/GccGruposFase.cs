using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class GccGruposFase
{
    public string GrpCnpjmembro { get; set; } = null!;

    public int GrupoId { get; set; }

    public string? GrpDescr { get; set; }

    public virtual ICollection<GccFase> GccFases { get; set; } = new List<GccFase>();
}
