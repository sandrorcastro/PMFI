using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class PortalObjeto
{
    public long Idobj { get; set; }

    public byte[]? Objeto { get; set; }

    public string? NomeObj { get; set; }

    public string? Extensao { get; set; }

    public virtual ICollection<PortalAgrupamentoPagina> PortalAgrupamentoPaginas { get; set; } = new List<PortalAgrupamentoPagina>();

    public virtual ICollection<PortalAgrupamentoPrincipal> PortalAgrupamentoPrincipals { get; set; } = new List<PortalAgrupamentoPrincipal>();

    public virtual ICollection<PortalIdioma> PortalIdiomas { get; set; } = new List<PortalIdioma>();

    public virtual ICollection<PortalPublicacoesObjeto> PortalPublicacoesObjetos { get; set; } = new List<PortalPublicacoesObjeto>();
}
