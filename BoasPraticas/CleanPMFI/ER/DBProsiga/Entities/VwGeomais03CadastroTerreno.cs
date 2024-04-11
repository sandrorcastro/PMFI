using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VwGeomais03CadastroTerreno
{
    public long NrCadastroImobiliario { get; set; }

    public string? CdDistrito { get; set; }

    public string? CdSetor { get; set; }

    public string? NrQuadra { get; set; }

    public string? NrLote { get; set; }

    public int CdItem { get; set; }

    public int CdSubItem { get; set; }

    public int? VlrItem { get; set; }

    public string DtItem { get; set; } = null!;

    public string? TextoItem { get; set; }
}
