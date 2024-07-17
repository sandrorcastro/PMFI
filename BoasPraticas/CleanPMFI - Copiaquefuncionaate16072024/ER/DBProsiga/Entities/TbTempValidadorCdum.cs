using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbTempValidadorCdum
{
    public int IdValidador { get; set; }

    public string? IdIdentificador { get; set; }

    public decimal? VlTotal { get; set; }

    public string? DsLogin { get; set; }
}
