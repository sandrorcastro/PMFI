using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class PortalPublicacoesObjeto
{
    public long Idpublicacao { get; set; }

    public long Idobj { get; set; }

    public string? Padrao { get; set; }

    public virtual PortalObjeto IdobjNavigation { get; set; } = null!;

    public virtual PortalPublicaco IdpublicacaoNavigation { get; set; } = null!;
}
