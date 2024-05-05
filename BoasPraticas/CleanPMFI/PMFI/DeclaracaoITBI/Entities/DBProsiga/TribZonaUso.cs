using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribZonaUso
{
    public short ZousId { get; set; }

    public string? ZousNome { get; set; }

    public string? ZousDescricao { get; set; }

    public short? ZotuId { get; set; }

    public virtual ICollection<TribZonaZoneamentoUso> TribZonaZoneamentoUsos { get; set; } = new List<TribZonaZoneamentoUso>();

    public virtual TribZonaTipoUso? Zotu { get; set; }
}
