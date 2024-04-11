using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribZonaTipoUso
{
    public short ZotuId { get; set; }

    public string? ZotuNome { get; set; }

    public virtual ICollection<TribZonaUso> TribZonaUsos { get; set; } = new List<TribZonaUso>();
}
