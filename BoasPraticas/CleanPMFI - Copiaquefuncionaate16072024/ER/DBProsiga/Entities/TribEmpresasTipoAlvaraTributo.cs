using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEmpresasTipoAlvaraTributo
{
    public long EmprCmc { get; set; }

    public int TipoTribId { get; set; }

    public int TalvId { get; set; }

    public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;

    public virtual TribEmpresasTiposAlvara Talv { get; set; } = null!;

    public virtual TribTipoTributo TipoTrib { get; set; } = null!;

    public virtual TribEmpresasTributo TribEmpresasTributo { get; set; } = null!;
}
