using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VwGeomais07SubItemCadastro
{
    public int CdItem { get; set; }

    public int CdSubItem { get; set; }

    public string? DsItem { get; set; }

    public decimal? Fator { get; set; }

    public int? Pontos { get; set; }
}
