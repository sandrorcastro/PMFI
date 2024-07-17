using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SeriTurPai
{
    public long Idpais { get; set; }

    public string? PaisNome { get; set; }

    public long? Idcontinente { get; set; }
}
