using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRecRegrasDiarioArrecadacaoReceita
{
    public int IdConfig { get; set; }

    public int? IdRegra { get; set; }

    public string? CdReceita { get; set; }
}
