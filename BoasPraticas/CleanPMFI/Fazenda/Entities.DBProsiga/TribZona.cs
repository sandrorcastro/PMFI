using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribZona
{
    public short ZonaId { get; set; }

    public string? ZonaDescricao { get; set; }

    public virtual ICollection<TribZonaZoneamento> TribZonaZoneamentos { get; set; } = new List<TribZonaZoneamento>();
}
