using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class FzitensVistoriadosTwoPk
{
    public long VistId { get; set; }

    public int ItemVistId { get; set; }

    public string? Vvobs { get; set; }
}
