using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TblogservicoRedesim
{
    public int Idlog { get; set; }

    /// <summary>
    /// A - Seriviço ativo
    /// </summary>
    public string Fltipo { get; set; } = null!;

    public DateTime Dtlog { get; set; }
}
