using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class PortalPublicaco
{
    public long Idpublicacao { get; set; }

    public string? Titulo { get; set; }

    public string? Descricao { get; set; }

    public DateTime? DtCad { get; set; }

    public DateTime? DtVal { get; set; }

    public long? Idsecao { get; set; }

    public string? UsuId { get; set; }

    public virtual PortalSecoesPagina? IdsecaoNavigation { get; set; }

    public virtual ICollection<PortalPublicacoesObjeto> PortalPublicacoesObjetos { get; set; } = new List<PortalPublicacoesObjeto>();

    public virtual Usuario? Usu { get; set; }
}
