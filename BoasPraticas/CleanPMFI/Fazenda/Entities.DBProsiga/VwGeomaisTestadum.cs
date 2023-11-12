using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class VwGeomaisTestadum
{
    public string NrCadastroImobiliario { get; set; } = null!;

    public string? CdDistrito { get; set; }

    public string? CdSetor { get; set; }

    public string? NrQuadra { get; set; }

    public string? NrLote { get; set; }

    public int NrTestada { get; set; }

    public int CdLogradouro { get; set; }

    public int? CdSecao { get; set; }

    public int? CdLadoSecao { get; set; }

    public decimal? MdTestada { get; set; }

    public int? Origem { get; set; }
}
