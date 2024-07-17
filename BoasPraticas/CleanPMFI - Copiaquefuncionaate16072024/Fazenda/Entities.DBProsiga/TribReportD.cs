using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribReportD
{
    public int RdsId { get; set; }

    public string? RdsSessionId { get; set; }

    public string? RdsDados { get; set; }

    public string? RdsXsd { get; set; }
}
