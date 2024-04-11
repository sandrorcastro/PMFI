using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class PortalIdioma
{
    public long Ididioma { get; set; }

    public string? Idioma { get; set; }

    public long? Idobj { get; set; }

    public int? AcessosPrincipal { get; set; }

    public virtual PortalObjeto? IdobjNavigation { get; set; }

    public virtual ICollection<PortalAgrupamentoPrincipal> PortalAgrupamentoPrincipals { get; set; } = new List<PortalAgrupamentoPrincipal>();
}
