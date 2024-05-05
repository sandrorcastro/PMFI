using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class OuvidoriaOrgao
{
    public int IdouvOrgao { get; set; }

    public string NmOrgao { get; set; } = null!;

    public virtual ICollection<OuvidoriaProcesso> OuvidoriaProcessos { get; set; } = new List<OuvidoriaProcesso>();
}
