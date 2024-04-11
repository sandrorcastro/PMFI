using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSisQueriesParam
{
    public int IdParam { get; set; }

    public int? IdQuery { get; set; }

    public string? NmParam { get; set; }

    public string? DsParam { get; set; }

    public string? DsTipo { get; set; }

    public int? IdQueryCarga { get; set; }
}
