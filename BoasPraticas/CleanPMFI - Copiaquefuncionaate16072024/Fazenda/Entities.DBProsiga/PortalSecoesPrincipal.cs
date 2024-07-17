using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class PortalSecoesPrincipal
{
    public long Idpaginas { get; set; }

    public string? NomePag { get; set; }

    public long? IdagrupaPrincipal { get; set; }

    public DateTime? DtCad { get; set; }

    public DateTime? DtVal { get; set; }

    public long? Idparam { get; set; }

    public string? Url { get; set; }

    public string? Target { get; set; }

    public string? TipoRedirect { get; set; }

    public long? Idobj { get; set; }

    public string? AbrirLink { get; set; }

    public int? Ordem { get; set; }

    public int? Acessos { get; set; }

    public virtual PortalAgrupamentoPrincipal? IdagrupaPrincipalNavigation { get; set; }

    public virtual PortalParametro? IdparamNavigation { get; set; }

    public virtual ICollection<PortalAgrupamentoPagina> PortalAgrupamentoPaginas { get; set; } = new List<PortalAgrupamentoPagina>();

    public virtual ICollection<PortalPermissoesPagina> PortalPermissoesPaginas { get; set; } = new List<PortalPermissoesPagina>();
}
