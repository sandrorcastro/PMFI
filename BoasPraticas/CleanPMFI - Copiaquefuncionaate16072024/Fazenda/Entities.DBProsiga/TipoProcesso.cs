using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TipoProcesso
{
    public int TipoProId { get; set; }

    public string? TipoProNome { get; set; }

    /// <summary>
    /// dias previstos para a tramitação do processo
    /// </summary>
    public int? TipoProDiasTramite { get; set; }

    public int? TipoProPermanencia { get; set; }

    public virtual ICollection<FluxoProcesso> FluxoProcessos { get; set; } = new List<FluxoProcesso>();

    public virtual ICollection<Processo> Processos { get; set; } = new List<Processo>();

    public virtual ICollection<TribTipoTributosTipoProcesso> TribTipoTributosTipoProcessos { get; set; } = new List<TribTipoTributosTipoProcesso>();

    public virtual ICollection<Documento> DocProDocs { get; set; } = new List<Documento>();
}
