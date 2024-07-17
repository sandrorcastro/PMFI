using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaIniciativa
{
    public int IdIniciativa { get; set; }

    public string? Cdiniciativa { get; set; }

    public string? DsIniciativa { get; set; }

    public int IdObjetivo { get; set; }

    public virtual TbPlaObjetivo IdObjetivoNavigation { get; set; } = null!;

    public virtual ICollection<TbOrcProgramasAco> IdAcaos { get; set; } = new List<TbOrcProgramasAco>();
}
