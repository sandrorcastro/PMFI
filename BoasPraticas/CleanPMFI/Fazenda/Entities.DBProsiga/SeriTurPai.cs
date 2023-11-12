using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SeriTurPai
{
    public long Idpais { get; set; }

    public string? PaisNome { get; set; }

    public long? Idcontinente { get; set; }
}
