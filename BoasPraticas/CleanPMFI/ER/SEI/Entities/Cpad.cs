using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Cpad
{
    public int IdCpad { get; set; }

    public int IdOrgao { get; set; }

    public string Sigla { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual ICollection<CpadVersao> CpadVersaos { get; set; } = new List<CpadVersao>();

    public virtual Orgao IdOrgaoNavigation { get; set; } = null!;
}
