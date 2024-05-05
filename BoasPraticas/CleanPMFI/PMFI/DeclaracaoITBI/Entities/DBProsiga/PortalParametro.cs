using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class PortalParametro
{
    public long Idparam { get; set; }

    public long? IdobjCabecalho { get; set; }

    public long? IdobjRodape { get; set; }

    public string? ParamPadrao { get; set; }

    public string? ParamPeriodo { get; set; }

    public virtual ICollection<PortalSecoesPrincipal> PortalSecoesPrincipals { get; set; } = new List<PortalSecoesPrincipal>();
}
