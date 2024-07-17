using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SisLogSistema
{
    public long LoSisId { get; set; }

    public string? LoSisUsuId { get; set; }

    public string? LoSisSituacao { get; set; }

    public DateTime? LoSisData { get; set; }

    public string? LoSisIp { get; set; }
}
