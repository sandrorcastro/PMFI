using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribZonaAlertum
{
    public int ZoalId { get; set; }

    public long? TerrenoId { get; set; }

    public short? ZomsId { get; set; }

    public string? ZoalComplemento { get; set; }
}
