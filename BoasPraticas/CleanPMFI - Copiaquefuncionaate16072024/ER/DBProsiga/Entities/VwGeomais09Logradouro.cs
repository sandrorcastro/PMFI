using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VwGeomais09Logradouro
{
    public int CdLogradouro { get; set; }

    public int? CdTipoLogradouro { get; set; }

    public string? NmLogradouro { get; set; }

    public int? DsLeiRegulamentacao { get; set; }
}
