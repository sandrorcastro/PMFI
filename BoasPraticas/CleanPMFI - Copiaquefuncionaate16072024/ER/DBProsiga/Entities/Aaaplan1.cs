using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Aaaplan1
{
    public string Cnpjempresa { get; set; } = null!;

    public DateTime? DataInicial { get; set; }

    public DateTime? DataFinal { get; set; }
}
