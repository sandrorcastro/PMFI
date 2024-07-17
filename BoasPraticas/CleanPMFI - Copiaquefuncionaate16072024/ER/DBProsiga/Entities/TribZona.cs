using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribZona
{
    public short ZonaId { get; set; }

    public string? ZonaDescricao { get; set; }

    public virtual ICollection<TribZonaZoneamento> TribZonaZoneamentos { get; set; } = new List<TribZonaZoneamento>();
}
