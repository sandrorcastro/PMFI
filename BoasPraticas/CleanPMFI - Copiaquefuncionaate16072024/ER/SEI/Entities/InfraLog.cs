using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class InfraLog
{
    public long IdInfraLog { get; set; }

    public DateTime? DthLog { get; set; }

    public string TextoLog { get; set; } = null!;

    public string? Ip { get; set; }

    public string StaTipo { get; set; } = null!;
}
