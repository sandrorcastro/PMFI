using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribAtividadeTipoAlvaraTributo
{
    public string Atividade { get; set; } = null!;

    public int TipoTribId { get; set; }

    public int TalvId { get; set; }

    public virtual TribAtivAtividade AtividadeNavigation { get; set; } = null!;

    public virtual TribEmpresasTiposAlvara Talv { get; set; } = null!;

    public virtual TribTipoTributo TipoTrib { get; set; } = null!;

    public virtual TribAtivTributosEmpresa TribAtivTributosEmpresa { get; set; } = null!;
}
