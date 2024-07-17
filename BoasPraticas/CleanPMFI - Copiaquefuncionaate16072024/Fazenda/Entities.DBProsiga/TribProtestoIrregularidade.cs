using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribProtestoIrregularidade
{
    public short IdIrregularidade { get; set; }

    public string? Descricao { get; set; }
}
