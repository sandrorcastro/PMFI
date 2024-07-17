using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class PortalAgrupamentoPagina
{
    public long IdagrupaPag { get; set; }

    public string? NomeAgrupaPag { get; set; }

    public string? Posicao { get; set; }

    public long? Idobj { get; set; }

    public long? Idpagina { get; set; }

    public DateTime? DtCad { get; set; }

    public DateTime? DtVal { get; set; }

    public int? Ordem { get; set; }

    public virtual PortalObjeto? IdobjNavigation { get; set; }

    public virtual PortalSecoesPrincipal? IdpaginaNavigation { get; set; }

    public virtual ICollection<PortalSecoesPagina> PortalSecoesPaginas { get; set; } = new List<PortalSecoesPagina>();
}
