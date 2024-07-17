using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TblogservicoRedesim
{
    public int Idlog { get; set; }

    /// <summary>
    /// A - Seriviço ativo
    /// </summary>
    public string Fltipo { get; set; } = null!;

    public DateTime Dtlog { get; set; }
}
