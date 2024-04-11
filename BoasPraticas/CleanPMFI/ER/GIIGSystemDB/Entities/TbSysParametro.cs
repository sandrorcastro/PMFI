using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbSysParametro
{
    public string IdSistema { get; set; } = null!;

    public string IdParametro { get; set; } = null!;

    public string? DsParametro { get; set; }

    public string? VlParametro { get; set; }

    public string? DsRotina { get; set; }

    public DateTime? DtInclusao { get; set; }
}
