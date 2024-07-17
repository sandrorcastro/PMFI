using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Tbpai
{
    public int Idpais { get; set; }

    public string Nmpais { get; set; } = null!;

    public string? Dssigla { get; set; }

    public string? Nmnacionalidade { get; set; }
}
