using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRecRegrasDiarioArrecadacaoConta
{
    public int IdConfig { get; set; }

    public int? IdRegra { get; set; }

    public string? CdContaContabil { get; set; }
}
