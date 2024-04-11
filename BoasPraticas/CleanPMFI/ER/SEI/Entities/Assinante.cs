using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Assinante
{
    public int IdAssinante { get; set; }

    public string CargoFuncao { get; set; } = null!;

    public int IdOrgao { get; set; }

    public virtual Orgao IdOrgaoNavigation { get; set; } = null!;

    public virtual ICollection<Unidade> IdUnidades { get; set; } = new List<Unidade>();
}
