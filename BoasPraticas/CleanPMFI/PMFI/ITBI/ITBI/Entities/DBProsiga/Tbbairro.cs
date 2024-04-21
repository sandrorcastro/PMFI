using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Tbbairro
{
    public int Idbairro { get; set; }

    public string Nmbairro { get; set; } = null!;

    public int Idcidade { get; set; }

    public int? Idregiao { get; set; }

    public string? Flbairroslc303 { get; set; }

    public string? Fzfonetizado { get; set; }
}
