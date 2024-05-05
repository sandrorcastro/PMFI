using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Psiaplicativo
{
    public long AplicativoId { get; set; }

    public string? AplicNome { get; set; }

    public string? AplicSigla { get; set; }

    public virtual ICollection<Psimodulo> Psimodulos { get; set; } = new List<Psimodulo>();
}
