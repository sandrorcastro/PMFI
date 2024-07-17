using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbTribExclusaoCalculo
{
    public int? TipoTribId { get; set; }

    public int? NrAno { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }
}
