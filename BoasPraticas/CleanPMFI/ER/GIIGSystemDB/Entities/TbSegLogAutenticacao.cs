using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbSegLogAutenticacao
{
    public long IdLog { get; set; }

    public string? DsIp { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtOcorrencia { get; set; }

    public string? DsSessionId { get; set; }

    public string? DsOcorrencia { get; set; }
}
