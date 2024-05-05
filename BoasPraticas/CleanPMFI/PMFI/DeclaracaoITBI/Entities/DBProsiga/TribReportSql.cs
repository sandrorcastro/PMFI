using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribReportSql
{
    public int RsqlId { get; set; }

    public string? RsqlSessionId { get; set; }

    public string? RsqlSubReport { get; set; }

    public string? RsqlSql { get; set; }
}
