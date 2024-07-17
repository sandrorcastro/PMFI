using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class DbDefrag
{
    public string? TableOwner { get; set; }

    public string? TableName { get; set; }

    public string? TableIndexName { get; set; }

    public double? AvgFragmentationInPercent { get; set; }

    public long Rows { get; set; }

    public DateTime? Timestamp { get; set; }
}
