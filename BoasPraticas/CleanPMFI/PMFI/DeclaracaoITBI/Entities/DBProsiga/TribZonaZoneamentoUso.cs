using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribZonaZoneamentoUso
{
    public short ZozoId { get; set; }

    public short ZousId { get; set; }

    public short ZotlId { get; set; }

    public virtual TribZonaTipoLiberacao Zotl { get; set; } = null!;

    public virtual TribZonaUso Zous { get; set; } = null!;

    public virtual TribZonaZoneamento Zozo { get; set; } = null!;
}
