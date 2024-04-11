using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Telefone
{
    public int Foneid { get; set; }

    public long? Conid { get; set; }

    public string? Numero { get; set; }
}
