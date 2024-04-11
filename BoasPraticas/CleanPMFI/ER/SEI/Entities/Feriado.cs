using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Feriado
{
    public int IdFeriado { get; set; }

    public int? IdOrgao { get; set; }

    public string Descricao { get; set; } = null!;

    public DateTime DtaFeriado { get; set; }

    public virtual Orgao? IdOrgaoNavigation { get; set; }
}
