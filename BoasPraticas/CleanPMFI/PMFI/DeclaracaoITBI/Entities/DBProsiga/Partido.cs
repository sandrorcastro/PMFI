using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Partido
{
    public string? Sigla { get; set; }

    public string? Nome { get; set; }

    public string? Cidade { get; set; }

    public string? Uf { get; set; }

    public string? NomePresidente { get; set; }

    public byte[]? LogoPartido { get; set; }
}
