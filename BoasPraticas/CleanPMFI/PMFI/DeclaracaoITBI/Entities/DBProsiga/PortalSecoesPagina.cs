using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class PortalSecoesPagina
{
    public long Idsecao { get; set; }

    public string? NomeSecao { get; set; }

    public long? IdagrupaPag { get; set; }

    public DateTime? DtCad { get; set; }

    public DateTime? DtVal { get; set; }

    public string? Url { get; set; }

    public string? Target { get; set; }

    public string? TipoRedirect { get; set; }

    public long? Idobj { get; set; }

    public string? AbrirLink { get; set; }

    public int? Ordem { get; set; }

    public virtual PortalAgrupamentoPagina? IdagrupaPagNavigation { get; set; }

    public virtual ICollection<PortalPublicaco> PortalPublicacos { get; set; } = new List<PortalPublicaco>();
}
