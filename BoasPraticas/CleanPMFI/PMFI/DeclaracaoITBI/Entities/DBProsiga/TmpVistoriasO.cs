using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TmpVistoriasO
{
    public long IdVistoria { get; set; }

    public long? Cmc { get; set; }

    public DateOnly? Data { get; set; }
}
