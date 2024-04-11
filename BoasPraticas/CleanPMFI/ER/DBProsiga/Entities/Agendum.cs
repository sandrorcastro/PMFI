using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Agendum
{
    public string AgeUsuario { get; set; } = null!;

    public DateTime AgeData { get; set; }

    public string AgeHora { get; set; } = null!;

    public string? AgeAssunto { get; set; }

    public virtual Usuario AgeUsuarioNavigation { get; set; } = null!;
}
